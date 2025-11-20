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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void so2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void so2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cong_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                int so_1 = int.Parse(so1.Text);
                int so_2 = int.Parse(so2.Text);
                int tong = so_1 + so_2;
                ketqua.Text = Convert.ToString(tong);

            }
            catch
            {
                MessageBox.Show("Đây không phải chữ số");
            }
        }

        private void ketqua_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tru_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int so_1 = int.Parse(so1.Text);
                int so_2 = int.Parse(so2.Text);
                int tong = so_1 - so_2;
                ketqua.Text = Convert.ToString(tong);

            }
            catch
            {
                MessageBox.Show("Đây không phải chữ số");
            }
        }

        private void nhan_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int so_1 = int.Parse(so1.Text);
                int so_2 = int.Parse(so2.Text);
                int tong = so_1 * so_2;
                ketqua.Text = Convert.ToString(tong);
            }
            catch 
            { 
                MessageBox.Show("Đây không phải chữ số"); 
            }
        }

        private void chia_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int so_1 = int.Parse(so1.Text);
                int so_2 = int.Parse(so2.Text);
                int tong = so_1 / so_2;
                ketqua.Text = Convert.ToString(tong);

            }
            catch
            {
                MessageBox.Show("Đây không phải chữ số");
            }
        }
    }
}
