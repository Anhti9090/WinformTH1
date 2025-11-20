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
    public partial class Form12 : Form
    {
        string chuoitam = "";
        char toantu = '\0';
        double[] toanhang = new double[2];
        double ketqua = 0.0;
        int buoc = 1;

        public Form12()
        {
            InitializeComponent();
        }

        private void Number_Button(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b == null)
                return;

            if (b.Text == "0" && chuoitam.Length == 0)
            {
                chuoitam = "0";
                textManHinh.Text = chuoitam;
                return;
            }

            chuoitam += b.Text;
            textManHinh.Text = chuoitam;
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            button0.Click += Number_Button;
            button1.Click += Number_Button;
            button2.Click += Number_Button;
            button3.Click += Number_Button;
            button4.Click += Number_Button;
            button5.Click += Number_Button;
            button6.Click += Number_Button;
            button7.Click += Number_Button;
            button8.Click += Number_Button;
            button9.Click += Number_Button;
            buttonCong.Click += Operations;
            buttonTru.Click += Operations;
            buttonNhan.Click += Operations;
            buttonChia.Click += Operations;
        }

        private void buttonCongTru_Click(object sender, EventArgs e)
        {
            if (chuoitam.Length == 0)
                return;

            if (chuoitam.Contains('-'))
                chuoitam = chuoitam.Replace("-", "");
            else
                chuoitam = "-" + chuoitam;

            textManHinh.Text = chuoitam;
        }

        private void buttonCham_Click(object sender, EventArgs e)
        {
            if (chuoitam.Length == 0)
                chuoitam = "0";

            if (!chuoitam.Contains('.'))
            {
                chuoitam = chuoitam + ".";
                textManHinh.Text = chuoitam;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buoc = 1;
            toanhang[0] = toanhang[1] = 0.0;
            toantu = '\0';
            ketqua = 0.0;
            chuoitam = "";
            textManHinh.Text = "0";
        }

        private void buttonBang_Click(object sender, EventArgs e)
        {
            if (toantu == '\0')
                return;

            if (chuoitam.Length != 0)
                toanhang[1] = Double.Parse(chuoitam);
            else
                toanhang[1] = 0;

            switch (toantu)
            {
                case '+':
                    ketqua = toanhang[0] + toanhang[1];
                    break;
                case '-':
                    ketqua = toanhang[0] - toanhang[1];
                    break;
                case '*':
                case '×':
                    ketqua = toanhang[0] * toanhang[1];
                    break;
                case '/':
                case '÷':
                    if (toanhang[1] != 0)
                        ketqua = toanhang[0] / toanhang[1];
                    else
                    {
                        MessageBox.Show("Không thể chia cho 0!", "Lỗi");
                        buttonC_Click(null, null);
                        return;
                    }
                    break;
            }

            textManHinh.Text = ketqua.ToString();
            toanhang[0] = ketqua;
            buoc = 1;
            chuoitam = "";
            toantu = '\0';
        }

        private void Operations(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b == null)
                return;

            if (buoc == 2 && chuoitam.Length > 0)
            {
                buttonBang_Click(null, null);
            }

            toantu = b.Text[0];

            if (chuoitam.Length == 0)
                toanhang[0] = ketqua;
            else
                toanhang[0] = Double.Parse(chuoitam);

            textManHinh.Text = toanhang[0].ToString();
            buoc = 2;
            chuoitam = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void buttonCong_Click(object sender, EventArgs e)
        {
        }
    }
}