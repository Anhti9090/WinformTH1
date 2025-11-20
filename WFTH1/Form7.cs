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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();

            this.AcceptButton = btnShow;
            this.CancelButton = btnExit;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textYourname.Clear();
            textYear.Clear();
            textYourname.Focus();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - Convert.ToInt32(textYear.Text);
            string s = "My name is: " + textYourname.Text + "\n" + age.ToString();
            MessageBox.Show(s);
        }

        private void textYourname_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(textYourname, "Bạn phải nhập tên");
            else
                this.errorProvider1.Clear();
        }

        private void textYear_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
                this.errorProvider1.SetError(textYear, "Bạn phải nhập năm sinh");
            else
                this.errorProvider1.Clear();
        }
        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
