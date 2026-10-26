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
    public partial class Bai6 : Form
    {

        private string connectionString = "Data Source=HomNayAnGi.db; Version=3;";

        public Bai6()
        {
            InitializeComponent();
            CauHinhListView();
            KhoiTaoDatabase();
            TaiDanhSachMonAn();
        }

        private void CauHinhListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Clear();
            listView1.Columns.Add("ID", 40);
            listView1.Columns.Add("Tên Món Ăn", 130);
            listView1.Columns.Add("Người Đóng Góp", 130);
            listView1.Columns.Add("Hình Ảnh", 150);
        }

        private void KhoiTaoDatabase()
        {
            using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection(connectionString))
            {
                conn.Open();
                string sqlNguoiDung = @"CREATE TABLE IF NOT EXISTS NguoiDung (
                                        IDNCC INTEGER PRIMARY KEY AUTOINCREMENT,
                                        HoVaTen TEXT NOT NULL,
                                        QuyenHan TEXT);";

                string sqlMonAn = @"CREATE TABLE IF NOT EXISTS MonAn (
                                    IDMA INTEGER PRIMARY KEY AUTOINCREMENT,
                                    TenMonAn TEXT NOT NULL,
                                    HinhAnh TEXT,
                                    IDNCC INTEGER,
                                    FOREIGN KEY (IDNCC) REFERENCES NguoiDung (IDNCC));";

                using (System.Data.SQLite.SQLiteCommand cmd1 = new System.Data.SQLite.SQLiteCommand(sqlNguoiDung, conn)) cmd1.ExecuteNonQuery();
                using (System.Data.SQLite.SQLiteCommand cmd2 = new System.Data.SQLite.SQLiteCommand(sqlMonAn, conn)) cmd2.ExecuteNonQuery();
            }
        }

        private void TaiDanhSachMonAn()
        {
            listView1.Items.Clear();
            using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT MonAn.IDMA, MonAn.TenMonAn, NguoiDung.HoVaTen, MonAn.HinhAnh 
                                 FROM MonAn 
                                 INNER JOIN NguoiDung ON MonAn.IDNCC = NguoiDung.IDNCC";

                using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(query, conn))
                using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["IDMA"].ToString());
                        item.SubItems.Add(reader["TenMonAn"].ToString());
                        item.SubItems.Add(reader["HoVaTen"].ToString());
                        item.SubItems.Add(reader["HinhAnh"].ToString());
                        listView1.Items.Add(item);
                    }
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                    throw new Exception("Vui lòng nhập họ và tên người dùng!");

                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string sql = "INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES (@ten, @quyen)";
                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ten", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@quyen", txtQuyenHan.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }
                txtNguoiDG.Text = txtName.Text.Trim();
                txtName.Clear();
                txtQuyenHan.Clear();
                MessageBox.Show("Đã thêm người dùng vào cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFood.Text)) throw new Exception("Vui lòng nhập tên món ăn!");
                if (string.IsNullOrWhiteSpace(txtNguoiDG.Text)) throw new Exception("Vui lòng nhập tên người đóng góp!");

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = $"Chọn hình ảnh cho món '{txtFood.Text}'";
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() != DialogResult.OK) return;

                string duongDanAnh = ofd.FileName;
                string nguoiDG = txtNguoiDG.Text.Trim();

                using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection(connectionString))
                {
                    conn.Open();
                    int idNCC = LayHoacTaoIDNguoiDung(nguoiDG, conn);
                    string sql = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES (@tenMon, @hinh, @idNCC)";

                    using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@tenMon", txtFood.Text.Trim());
                        cmd.Parameters.AddWithValue("@hinh", duongDanAnh);
                        cmd.Parameters.AddWithValue("@idNCC", idNCC);
                        cmd.ExecuteNonQuery();
                    }
                }
                txtFood.Clear();
                TaiDanhSachMonAn();
                MessageBox.Show("Đã thêm món ăn và hình ảnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int LayHoacTaoIDNguoiDung(string tenHoacID, System.Data.SQLite.SQLiteConnection conn)
        {
            string queryTim = "SELECT IDNCC FROM NguoiDung WHERE HoVaTen = @ten LIMIT 1";
            using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(queryTim, conn))
            {
                cmd.Parameters.AddWithValue("@ten", tenHoacID);
                object result = cmd.ExecuteScalar();
                if (result != null) return Convert.ToInt32(result);
            }

            string queryTaoMoi = "INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES (@ten, 'Người đóng góp'); SELECT last_insert_rowid();";
            using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(queryTaoMoi, conn))
            {
                cmd.Parameters.AddWithValue("@ten", tenHoacID);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void btnTimMon_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống! Vui lòng thêm món ăn trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Random rand = new Random();
            int index = rand.Next(0, listView1.Items.Count);
            ListViewItem item = listView1.Items[index];

            lblKetQuaMon.Text = item.SubItems[1].Text;
            lblKetQuaNCC.Text = item.SubItems[2].Text;
            string duongDanAnh = item.SubItems[3].Text;

            if (System.IO.File.Exists(duongDanAnh))
            {
                if (picFood.Image != null) picFood.Image.Dispose();
                picFood.Image = Image.FromFile(duongDanAnh);
                picFood.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                picFood.Image = null;
                MessageBox.Show("Không tìm thấy file ảnh của món ăn này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaToanBo_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa TOÀN BỘ dữ liệu không?", "Cảnh báo khẩn", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection(connectionString))
                    {
                        conn.Open();
                        string sql = "DELETE FROM MonAn; DELETE FROM NguoiDung;";
                        using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(sql, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    TaiDanhSachMonAn();
                    MessageBox.Show("Đã làm mới toàn bộ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
