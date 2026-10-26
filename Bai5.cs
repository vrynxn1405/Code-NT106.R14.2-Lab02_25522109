using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai5 : Form
    {
        private Dictionary<string, Phim> dicPhim = new Dictionary<string, Phim>();
        private Dictionary<int, HashSet<string>> gheDaMuaTheoPhong = new Dictionary<int, HashSet<string>>();
        private Dictionary<string, List<(int Phong, string Ghe)>> lichSuKhachHang = new Dictionary<string, List<(int Phong, string Ghe)>>();

        private const string InputFile = "input5.txt";
        private const string OutputFile = "output5.txt";

        public Bai5()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (!System.IO.File.Exists(InputFile))
                {
                    MessageBox.Show("Không tìm thấy file input5.txt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lines = System.IO.File.ReadAllLines(InputFile, Encoding.UTF8)
                                    .Where(l => !string.IsNullOrWhiteSpace(l))
                                    .ToArray();

                dicPhim.Clear();
                gheDaMuaTheoPhong.Clear();
                lichSuKhachHang.Clear();
                cbPhim.Items.Clear();
                rtbOutput.Clear();

                for (int i = 0; i + 2 < lines.Length; i += 3)
                {
                    string tenPhim = lines[i].Trim();
                    double giaChuan = double.Parse(lines[i + 1].Trim());
                    List<int> phongChieu = lines[i + 2]
                        .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList();

                    foreach (int p in phongChieu)
                    {
                        if (!gheDaMuaTheoPhong.ContainsKey(p))
                            gheDaMuaTheoPhong[p] = new HashSet<string>();
                    }

                    dicPhim[tenPhim] = new Phim
                    {
                        TenPhim = tenPhim,
                        GiaVeChuan = giaChuan,
                        DanhSachPhong = phongChieu
                    };
                    cbPhim.Items.Add(tenPhim);
                }

                if (cbPhim.Items.Count > 0) cbPhim.SelectedIndex = 0;
                MessageBox.Show($"Đã đọc thành công {dicPhim.Count} bộ phim!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi đọc file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRoom.Items.Clear();
            string tenPhim = cbPhim.Text;
            if (dicPhim.ContainsKey(tenPhim))
            {
                foreach (int phong in dicPhim[tenPhim].DanhSachPhong)
                {
                    cbRoom.Items.Add(phong);
                }
                if (cbRoom.Items.Count > 0) cbRoom.SelectedIndex = 0;
            }
        }

        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clbGhe.Items.Count; i++)
            {
                clbGhe.SetItemChecked(i, false);
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            try
            {
                if (dicPhim.Count == 0) throw new Exception("Vui lòng nhấn 'ĐỌC FILE' trước!");

                string tenKhach = txtName.Text.Trim();
                if (string.IsNullOrEmpty(tenKhach)) throw new Exception("Vui lòng nhập họ và tên khách hàng!");
                if (clbGhe.CheckedItems.Count == 0) throw new Exception("Vui lòng chọn ít nhất 1 ghế!");

                string tenPhim = cbPhim.Text;
                int phong = int.Parse(cbRoom.Text);
                Phim phimHienTai = dicPhim[tenPhim];

                List<string> gheDangChon = clbGhe.CheckedItems
                    .Cast<object>()
                    .Select(item => item.ToString().Trim())
                    .ToList();

                foreach (string ghe in gheDangChon)
                {
                    if (gheDaMuaTheoPhong[phong].Contains(ghe))
                    {
                        throw new Exception($"Ghế {ghe} tại Phòng {phong} đã có người mua! Vui lòng chọn ghế khác.");
                    }
                }

                if (!lichSuKhachHang.ContainsKey(tenKhach))
                {
                    lichSuKhachHang[tenKhach] = new List<(int Phong, string Ghe)>();
                }
                var danhSachDuKien = new List<(int Phong, string Ghe)>(lichSuKhachHang[tenKhach]);
                foreach (string ghe in gheDangChon)
                {
                    danhSachDuKien.Add((phong, ghe));
                }

                int soPhongKhacNhau = danhSachDuKien.Select(x => x.Phong).Distinct().Count();
                int tongSoVeCuaKhach = danhSachDuKien.Count;

                if (soPhongKhacNhau >= 2 && tongSoVeCuaKhach > 2)
                {
                    throw new Exception($"Khách hàng '{tenKhach}' đang chọn vé ở {soPhongKhacNhau} phòng chiếu khác nhau.\nKhông thể chọn nhiều hơn 2 vé ở 2 phòng chiếu khác nhau!");
                }

                double tienThanhToan = 0;
                foreach (string ghe in gheDangChon)
                {
                    double giaVe = TinhGiaVe(ghe, phimHienTai.GiaVeChuan);
                    tienThanhToan += giaVe;
                    gheDaMuaTheoPhong[phong].Add(ghe);
                    lichSuKhachHang[tenKhach].Add((phong, ghe));
                }

                phimHienTai.SoVeBanRa += gheDangChon.Count;
                phimHienTai.DoanhThu += tienThanhToan;

                rtbOutput.AppendText("==========================================\n");
                rtbOutput.AppendText($"Họ và tên: {tenKhach}\n");
                rtbOutput.AppendText($"Vé đã chọn: {string.Join(", ", gheDangChon)}\n");
                rtbOutput.AppendText($"Tên phim: {tenPhim}\n");
                rtbOutput.AppendText($"Phòng chiếu: {phong}\n");
                rtbOutput.AppendText($"Số tiền thanh toán: {tienThanhToan:N0} đ\n");
                rtbOutput.AppendText("==========================================\n\n");

                for (int i = 0; i < clbGhe.Items.Count; i++)
                {
                    clbGhe.SetItemChecked(i, false);
                }
                MessageBox.Show("Đặt vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private double TinhGiaVe(string ghe, double giaChuan)
        {
            string[] veVot = { "A1", "A5", "C1", "C5" };
            string[] veVIP = { "B2", "B3", "B4" };
            if (veVot.Contains(ghe)) return giaChuan * 0.25;
            if (veVIP.Contains(ghe)) return giaChuan * 2.0;
            return giaChuan * 1.0;
        }

        private async void btnXuatFile_Click(object sender, EventArgs e)
        {
            if (dicPhim.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu phim! Vui lòng đọc file trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnXuatFile.Enabled = false;
            var danhSachXepHang = dicPhim.Values.OrderByDescending(p => p.DoanhThu).ToList();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = danhSachXepHang.Count;
            progressBar1.Value = 0;

            List<string> outputLines = new List<string>();
            outputLines.Add("BẢNG THỐNG KÊ DOANH THU PHÒNG VÉ");
            outputLines.Add("==========================================");
            rtbOutput.Clear();

            for (int i = 0; i < danhSachXepHang.Count; i++)
            {
                Phim p = danhSachXepHang[i];
                int hang = i + 1;
                string thongKe = $"Xếp hạng doanh thu: {hang}\n" +
                                 $"Tên phim: {p.TenPhim}\n" +
                                 $"Số lượng vé bán ra: {p.SoVeBanRa}\n" +
                                 $"Số lượng vé tồn: {p.SoVeTon}\n" +
                                 $"Tỉ lệ vé bán ra: {p.TiLeBanRa:0.00}%\n" +
                                 $"Doanh thu: {p.DoanhThu:N0} đ\n" +
                                 $"------------------------------------------";
                outputLines.Add(thongKe);
                rtbOutput.AppendText(thongKe + "\n");

                progressBar1.Value = i + 1;
                await Task.Delay(400); 
            }

            System.IO.File.WriteAllLines(OutputFile, outputLines, Encoding.UTF8);
            btnXuatFile.Enabled = true;
            MessageBox.Show("Đã xuất thống kê ra file output5.txt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbRoom_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }

    public class Phim
    {
        public string TenPhim { get; set; }
        public double GiaVeChuan { get; set; }
        public List<int> DanhSachPhong { get; set; } = new List<int>();
        public int SoVeBanRa { get; set; } = 0;
        public double DoanhThu { get; set; } = 0;
        public int TongSoVe => DanhSachPhong.Count * 15;
        public int SoVeTon => TongSoVe - SoVeBanRa;
        public double TiLeBanRa => TongSoVe > 0 ? (double)SoVeBanRa / TongSoVe * 100 : 0;
    }

}

