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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radiored_CheckedChanged(object sender, EventArgs e)
        {
            if (radiored.Checked == true) textketqua.ForeColor = Color.Red;
        }

        private void radiogreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radiogreen.Checked == true) textketqua.ForeColor = Color.Green;
        }

        private void radioblue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioblue.Checked == true) textketqua.ForeColor = Color.Blue;
        }

        private void radioblack_CheckedChanged(object sender, EventArgs e)
        {
            if (radioblack.Checked == true) textketqua.ForeColor = Color.Black;
        }
        private void checkdam_CheckedChanged(object sender, EventArgs e)
        {
            textketqua.Font = new Font(textketqua.Font.Name, textketqua.Font.Size, textketqua.Font.Style ^ FontStyle.Bold);
            textketqua.Text = textnhapten.Text;
        }

        private void checknghieng_CheckedChanged(object sender, EventArgs e)
        {
            textketqua.Font = new Font(textketqua.Font.Name, textketqua.Font.Size, textketqua.Font.Style ^ FontStyle.Italic);
            textketqua.Text = textnhapten.Text;
        }

        private void checkgachchan_CheckedChanged(object sender, EventArgs e)
        {
            textketqua.Font = new Font(textketqua.Font.Name, textketqua.Font.Size, textketqua.Font.Style ^ FontStyle.Underline);
            textketqua.Text = textnhapten.Text;
        }

        private void textketqua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
