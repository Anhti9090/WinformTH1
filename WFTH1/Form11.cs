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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mssv = this.mssv.Text;
            string hoten = this.hoten.Text;
            string nienkhoa = this.nienkhoa.Text;
            string lop = this.lop.Text;
            string hocky = "";
            if (ky1.Checked)
                hocky += "1";
            else if (ky2.Checked)
                hocky += "2";
            else if (ky3.Checked)
                hocky += "3";
            else if (ky4.Checked)
                hocky += "4";
            else
            {
                MessageBox.Show("Vui lòng chọn học kỳ!", "Lỗi thao tác",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string mh = "";
            for (int i = 0; i < checkedListMH.CheckedItems.Count; i++)
            {
                mh += "\n" + checkedListMH.CheckedItems[i].ToString();
            }
            string thongtin = "MSSV: " + mssv + "\nHọ tên: " + hoten + "\nNiên khóa: " + nienkhoa + "\nLớp: " + lop + "\nĐã đăng ký Học kỳ: " + hocky + "\nMôn học đăng ký: " + mh;
            MessageBox.Show(thongtin, "Thông tin sinh viên");
        }

        private void huy_Click(object sender, EventArgs e)
        {
            mssv.Clear();
            hoten.Clear();
            nienkhoa.SelectedItem = null;
            lop.SelectedItem = null;
            ky1.Checked = false;
            ky2.Checked = false;
            ky3.Checked = false;
            ky4.Checked = false;
            for (int i = 0; i < checkedListMH.Items.Count; i++)
            {
                checkedListMH.SetItemChecked(i, false);
            }
            mssv.Focus();

        }
    }
}
