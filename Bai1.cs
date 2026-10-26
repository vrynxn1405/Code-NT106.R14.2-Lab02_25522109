using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai1 : Form
    {
        private const string Input = "input1.txt";
        private const string Output = "output1.txt";
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(Input))
                {
                    MessageBox.Show("Không tìm thấy file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (StreamReader sr = new StreamReader(Input))
                {
                    rtbContent.Text = sr.ReadToEnd();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Gặp lỗi khi đọc file: {error.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string upper_content = rtbContent.Text.ToUpper();
                using (StreamWriter sw = new StreamWriter(Output))
                {
                    sw.Write(upper_content);
                }
                MessageBox.Show("Đã ghi file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Không thể ghi file: {error.Message}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
