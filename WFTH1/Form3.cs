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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            int so = int.Parse(boxcapnhat.Text);
            for (int i = 1; i <= so; i++)
            {
                if ((so % i) == 0)
                    listBox1.Items.Add(i);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                int so = int.Parse(boxcapnhat.Text);
                if (comboBox1.Items.Contains(so))
                {
                    MessageBox.Show("Số đã tồn tại trong danh sách!");
                    return;
                }

                comboBox1.Items.Add(so);
            }
            catch
            {
                MessageBox.Show("Đây không phải chữ số: " + boxcapnhat.Text);
            }
        }

        private void tonguocso_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Hãy chọn số trong ComboBox!");
                return;
            }

            int so = int.Parse(comboBox1.SelectedItem.ToString());
            int tong = 0;

            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0)
                    tong += i;
            }
            MessageBox.Show("Tổng các ước số của " + so + " là: " + tong);
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uocsochan_Click(object sender, EventArgs e)
        {
            int dem = 0;

            foreach (int uoc in listBox1.Items)
                if (uoc % 2 == 0)
                    dem++;

            MessageBox.Show("Số lượng ước số chẵn: " + dem);
        }
        private bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }

        private void songuyento_Click(object sender, EventArgs e)
        {
            int dem = 0;

            foreach (int uoc in listBox1.Items)
                if (IsPrime(uoc))
                    dem++;

            MessageBox.Show("Số lượng ước số nguyên tố: " + dem);
        }
    }
}
