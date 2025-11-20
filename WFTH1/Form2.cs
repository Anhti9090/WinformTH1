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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string hoten = this.boxhovaten.Text.Trim();
            if (this.radiochuthuong.Checked == true)
                boxketqua.Text = hoten.ToLower();
            if (this.radiochuinhoa.Checked == true)
                boxketqua.Text = hoten.ToUpper();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            this.boxhovaten.Clear();
            this.boxketqua.Clear();
            this.radiochuthuong.Checked = true;
            this.boxhovaten.Focus();
        }
    }
}
