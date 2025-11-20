using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFTH1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();

            this.CancelButton = thoat;
        }
        private void giai_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textA.Text);
                double b = double.Parse(textB.Text);
                double kq = 0;
                if (a == 0 && a == 0)
                {
                    MessageBox.Show("Phương trình vô số nghiệm!", "Kết quả");
                } else
                {
                    kq = -b / a;
                    textNPT.Text = Convert.ToString(kq);
                    xoa.Enabled = true;
                }

            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            textA.Clear();
            textB.Clear();
            textNPT.Clear();
            textA.Focus();
            xoa.Enabled = false;
        }
    }
}
