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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            this.AcceptButton = buttonnhap;
        }

        private void buttonnhap_Click(object sender, EventArgs e)
        {
            try{
                int text = int.Parse(textnhap.Text);
                listBox1.Items.Add(text);
                textnhap.Clear();
                textnhap.Focus();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ketthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tongphantu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.Items.Count.ToString());
        }

        private void xoadaucuoi_Click(object sender, EventArgs e)
        {
            if ( listBox1.Items.Count > 0)
            {
                listBox1.Items.RemoveAt(0);
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            }
            return;
        }

        private void xoadangchon_Click(object sender, EventArgs e)
        {
            try
            {
                int text = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(text);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn phần tử cần xóa!", "Lỗi thao tác",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tanglen2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int value = (int)listBox1.Items[i];
                value += 2;
                listBox1.Items[i] = value;
            }
            return;
        }

        private void thaybinhphuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int value = (int)listBox1.Items[i];
                value = value * value;
                listBox1.Items[i] = value;
            }
            return;
        }

        private void sochan_Click(object sender, EventArgs e)
        {
            string number = "";
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int value = (int)listBox1.Items[i];
                if (value % 2 == 0)
                {
                    number += value + "\n";
                }
            }
            MessageBox.Show(number);
            return;
        }

        private void sole_Click(object sender, EventArgs e)
        {
            string number = "";
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int value = (int)listBox1.Items[i];
                if (value % 2 != 0)
                {
                    number += value + "\n";
                }
            }
            MessageBox.Show(number);
            return;
        }
    }
}
