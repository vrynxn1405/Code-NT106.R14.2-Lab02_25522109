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
    public partial class FormDieuHuong : Form
    {
        public FormDieuHuong()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Bai1 formBai1 = new Bai1();
            formBai1.Show();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Bai2 formBai2 = new Bai2();
            formBai2.Show();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Bai3 formBai3 = new Bai3();
            formBai3.Show();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            Bai4 formBai4 = new Bai4();
            formBai4.Show();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            Bai5 formBai5 = new Bai5();
            formBai5.Show();
        }

        private void btnBai6_Click(object sender, EventArgs e)
        {
            Bai6 formBai6 = new Bai6();
            formBai6.Show();
        }

        private void btnBai7_Click(object sender, EventArgs e)
        {
            Bai7 formBai7 = new Bai7();
            formBai7.Show();
        }
    }
}
