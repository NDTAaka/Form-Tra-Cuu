using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Tra_Cuu
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> Danhsachsinhvien;
        public Form1()
        {
            InitializeComponent();
            Danhsachsinhvien = new Dictionary<string, string>
            {
                {"22810310412", "Nguyen Danh Thai Anh : 10" },
                {"22810310411", "Dang Duc Thien An: 3.5" },
                {"22810310410", "Nguyen Duy Hiep: 9.5" }

            };
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Masv = txtMasv.Text.Trim();
            if (Danhsachsinhvien.ContainsKey(Masv))
            {
                txtThongtin.Text = Danhsachsinhvien[Masv];
            }
            else
            {
                MessageBox.Show("Khong tim thay ma sinh vien!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
