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
    public partial class Bai4 : Form
    {
        private System.Collections.Generic.List<SinhVien> dsnhap = new System.Collections.Generic.List<SinhVien>();
        private System.Collections.Generic.List<SinhVien> dsdoc = new System.Collections.Generic.List<SinhVien>();
        private int index = 0;
        private const string InputFile = "input4.txt";
        private const string OutputFile = "output4.txt";
        public Bai4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        public class SinhVien
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public string Phone { get; set; }
            public float Course1 { get; set; }
            public float Course2 { get; set; }
            public float Course3 { get; set; }
            public float Average { get; set; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNameIn.Text))
                    throw new Exception("Vui lòng ghi đầy đủ họ tên!");
                if (txtIDIn.Text.Length != 8 || !int.TryParse(txtIDIn.Text, out int id))
                    throw new Exception("Mã số sinh viên phải có 8 chữ số!");

                string phone = txtPhoneIn.Text;
                if (phone.Length != 10 || !phone.StartsWith("0"))
                    throw new Exception("Số điện thoại phải bắt đầu bằng số 0 và có 10 chữ số!");

                if (!float.TryParse(txtCourse1In.Text, out float c1) || c1 < 0 || c1 > 10 ||
                    !float.TryParse(txtCourse2In.Text, out float c2) || c2 < 0 || c2 > 10 ||
                    !float.TryParse(txtCourse3In.Text, out float c3) || c3 < 0 || c3 > 10)
                {
                    throw new Exception("Điểm môn học phải là số từ 0 đến 10.");
                }

                SinhVien sv = new SinhVien
                {
                    Name = txtNameIn.Text,
                    ID = id,
                    Phone = phone,
                    Course1 = c1,
                    Course2 = c2,
                    Course3 = c3,
                    Average = 0
                };
                dsnhap.Add(sv);

                rtbContent.AppendText($"{sv.Name}\n{sv.ID}\n{sv.Phone}\n{sv.Course1}\n{sv.Course2}\n{sv.Course3}\n\n");

                txtNameIn.Clear(); txtIDIn.Clear(); txtPhoneIn.Clear();
                txtCourse1In.Clear(); txtCourse2In.Clear(); txtCourse3In.Clear();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (dsnhap.Count == 0)
            {
                MessageBox.Show("Chưa có sinh viên nào để thực hiện thao tác lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string jsonString = System.Text.Json.JsonSerializer.Serialize(dsnhap, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(InputFile, jsonString);
            MessageBox.Show("Đã lưu danh sách xuống file input4.txt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(InputFile))
            {
                MessageBox.Show("Không tìm thấy file input4.txt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string jsonString = System.IO.File.ReadAllText(InputFile);
            if (string.IsNullOrWhiteSpace(jsonString))
            {
                MessageBox.Show("File input4.txt đang trống! Vui lòng thêm sinh viên và bấm 'Write to a file' trước.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dsdoc = System.Text.Json.JsonSerializer.Deserialize<System.Collections.Generic.List<SinhVien>>(jsonString);
            if (dsdoc == null || dsdoc.Count == 0) return;

            foreach (var sv in dsdoc)
            {
                sv.Average = (float)Math.Round((sv.Course1 + sv.Course2 + sv.Course3) / 3, 2);
            }

            string outputJson = System.Text.Json.JsonSerializer.Serialize(dsdoc, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(OutputFile, outputJson);
            MessageBox.Show("Đã đọc file, tính điểm TB và lưu vào output4.txt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            index = 0;
            HienThiSinhVien(index);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (dsdoc.Count > 0 && index > 0)
            {
                index--;
                HienThiSinhVien(index);
            }
        }


        private void HienThiSinhVien(int index)
        {
            if (index < 0 || index >= dsdoc.Count) return;

            SinhVien sv = dsdoc[index];
            txtNameOut.Text = sv.Name;
            txtIDOut.Text = sv.ID.ToString();
            txtPhoneOut.Text = sv.Phone;
            txtCourse1Out.Text = sv.Course1.ToString();
            txtCourse2Out.Text = sv.Course2.ToString();
            txtCourse3Out.Text = sv.Course3.ToString();
            txtAverageOut.Text = sv.Average.ToString();

            lblPage.Text = $"{index + 1}/{dsdoc.Count}";
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (dsdoc.Count > 0 && index < dsdoc.Count - 1)
            {
                index++;
                HienThiSinhVien(index);
            }
        }
    }
}
