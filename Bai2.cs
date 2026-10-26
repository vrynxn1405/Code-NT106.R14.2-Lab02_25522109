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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnReadFromFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                ofd.Title = "Chọn file: ";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string name = ofd.SafeFileName.ToString();
                        txtName.Text = name;

                        using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                        {
                            string File_Path = fs.Name.ToString();
                            txtURL.Text = File_Path;
                            txtSize.Text = $"{fs.Length} bytes";

                            using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                            {
                                string content = sr.ReadToEnd();
                                rtbContent.Text = content;

                                txtCharCount.Text = content.Length.ToString();

                                txtLineCount.Text = content.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries).Length.ToString();

                                char[] separators = new char[] { ' ', '\r', '\n', '\t' };
                                string[] words = content.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                                txtWordsCount.Text = words.Length.ToString();
                            }
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show($"Không thể đọc file: {error.Message}!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
