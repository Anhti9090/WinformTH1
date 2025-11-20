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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (timesnewroman.Checked)
                textBox1.Font = new Font(new FontFamily("Times New Roman"), 14);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (arial.Checked)
                textBox1.Font = new Font(new FontFamily("Arial"), 14);
        }

        private void tahoma_CheckedChanged(object sender, EventArgs e)
        {
            if (tahoma.Checked)
                textBox1.Font = new Font(new FontFamily("Tahoma"), 14);
        }

        private void couriernew_CheckedChanged(object sender, EventArgs e)
        {
            if (couriernew.Checked)
                textBox1.Font = new Font(new FontFamily("Courier New"), 14);
        }
    }
}
