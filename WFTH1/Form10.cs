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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            this.AcceptButton = capnhat;
        }

        private void capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (textnhap.Text.Trim().Length == 0)
                    MessageBox.Show("Vui lòng nhập tên!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    bangA.Items.Add(textnhap.Text);
                    textnhap.Clear();
                    textnhap.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập tên!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ketthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void A_B_Click(object sender, EventArgs e)
        {
            while (bangA.SelectedItems.Count > 0)
            {
                bangB.Items.Add(bangA.SelectedItems[0]);
                bangA.Items.Remove(bangA.SelectedItems[0]);
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            while (bangA.SelectedItems.Count > 0)
                bangA.Items.Remove(bangA.SelectedItems[0]);

            while (bangB.SelectedItems.Count > 0)
                bangB.Items.Remove(bangB.SelectedItems[0]);
        }

        private void A__B_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bangA.Items.Count; i++)
                bangB.Items.Add(bangA.Items[i]);
            bangA.Items.Clear();
        }

        private void B_A_Click(object sender, EventArgs e)
        {
            while (bangB.SelectedItems.Count > 0)
            {
                bangA.Items.Add(bangB.SelectedItems[0]);
                bangB.Items.Remove(bangB.SelectedItems[0]);
            }
        }

        private void B__A_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bangB.Items.Count; i++)
                bangA.Items.Add(bangB.Items[i]);
            bangB.Items.Clear();
        }
    }
}
