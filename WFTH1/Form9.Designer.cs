namespace WFTH1
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textnhap = new System.Windows.Forms.TextBox();
            this.buttonnhap = new System.Windows.Forms.Button();
            this.tongphantu = new System.Windows.Forms.Button();
            this.xoadaucuoi = new System.Windows.Forms.Button();
            this.xoadangchon = new System.Windows.Forms.Button();
            this.tanglen2 = new System.Windows.Forms.Button();
            this.thaybinhphuong = new System.Windows.Forms.Button();
            this.sochan = new System.Windows.Forms.Button();
            this.sole = new System.Windows.Forms.Button();
            this.ketthuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonnhap);
            this.groupBox1.Controls.Add(this.textnhap);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listbox";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sole);
            this.groupBox2.Controls.Add(this.sochan);
            this.groupBox2.Controls.Add(this.thaybinhphuong);
            this.groupBox2.Controls.Add(this.tanglen2);
            this.groupBox2.Controls.Add(this.xoadangchon);
            this.groupBox2.Controls.Add(this.xoadaucuoi);
            this.groupBox2.Controls.Add(this.tongphantu);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10F);
            this.groupBox2.Location = new System.Drawing.Point(240, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 345);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xử lý Listbox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "LISTBOX";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(7, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 213);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textnhap
            // 
            this.textnhap.Font = new System.Drawing.Font("Arial", 10F);
            this.textnhap.Location = new System.Drawing.Point(7, 22);
            this.textnhap.Multiline = true;
            this.textnhap.Name = "textnhap";
            this.textnhap.Size = new System.Drawing.Size(187, 30);
            this.textnhap.TabIndex = 1;
            // 
            // buttonnhap
            // 
            this.buttonnhap.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonnhap.Location = new System.Drawing.Point(7, 59);
            this.buttonnhap.Name = "buttonnhap";
            this.buttonnhap.Size = new System.Drawing.Size(187, 40);
            this.buttonnhap.TabIndex = 2;
            this.buttonnhap.Text = "Nhập";
            this.buttonnhap.UseVisualStyleBackColor = true;
            this.buttonnhap.Click += new System.EventHandler(this.buttonnhap_Click);
            // 
            // tongphantu
            // 
            this.tongphantu.Font = new System.Drawing.Font("Arial", 10F);
            this.tongphantu.Location = new System.Drawing.Point(6, 22);
            this.tongphantu.Name = "tongphantu";
            this.tongphantu.Size = new System.Drawing.Size(268, 40);
            this.tongphantu.TabIndex = 3;
            this.tongphantu.Text = "Tổng các phần tử trong List";
            this.tongphantu.UseVisualStyleBackColor = true;
            this.tongphantu.Click += new System.EventHandler(this.tongphantu_Click);
            // 
            // xoadaucuoi
            // 
            this.xoadaucuoi.Font = new System.Drawing.Font("Arial", 10F);
            this.xoadaucuoi.Location = new System.Drawing.Point(6, 68);
            this.xoadaucuoi.Name = "xoadaucuoi";
            this.xoadaucuoi.Size = new System.Drawing.Size(268, 40);
            this.xoadaucuoi.TabIndex = 4;
            this.xoadaucuoi.Text = "Xóa Phần tử đầu và cuối";
            this.xoadaucuoi.UseVisualStyleBackColor = true;
            this.xoadaucuoi.Click += new System.EventHandler(this.xoadaucuoi_Click);
            // 
            // xoadangchon
            // 
            this.xoadangchon.Font = new System.Drawing.Font("Arial", 10F);
            this.xoadangchon.Location = new System.Drawing.Point(6, 114);
            this.xoadangchon.Name = "xoadangchon";
            this.xoadangchon.Size = new System.Drawing.Size(268, 40);
            this.xoadangchon.TabIndex = 5;
            this.xoadangchon.Text = "Xóa phần tử đang chọn";
            this.xoadangchon.UseVisualStyleBackColor = true;
            this.xoadangchon.Click += new System.EventHandler(this.xoadangchon_Click);
            // 
            // tanglen2
            // 
            this.tanglen2.Font = new System.Drawing.Font("Arial", 10F);
            this.tanglen2.Location = new System.Drawing.Point(6, 160);
            this.tanglen2.Name = "tanglen2";
            this.tanglen2.Size = new System.Drawing.Size(268, 40);
            this.tanglen2.TabIndex = 6;
            this.tanglen2.Text = "Tăng mỗi phần tử lên 2";
            this.tanglen2.UseVisualStyleBackColor = true;
            this.tanglen2.Click += new System.EventHandler(this.tanglen2_Click);
            // 
            // thaybinhphuong
            // 
            this.thaybinhphuong.Font = new System.Drawing.Font("Arial", 10F);
            this.thaybinhphuong.Location = new System.Drawing.Point(6, 206);
            this.thaybinhphuong.Name = "thaybinhphuong";
            this.thaybinhphuong.Size = new System.Drawing.Size(268, 40);
            this.thaybinhphuong.TabIndex = 7;
            this.thaybinhphuong.Text = "Thay bằng bình phương";
            this.thaybinhphuong.UseVisualStyleBackColor = true;
            this.thaybinhphuong.Click += new System.EventHandler(this.thaybinhphuong_Click);
            // 
            // sochan
            // 
            this.sochan.Font = new System.Drawing.Font("Arial", 10F);
            this.sochan.Location = new System.Drawing.Point(6, 252);
            this.sochan.Name = "sochan";
            this.sochan.Size = new System.Drawing.Size(268, 40);
            this.sochan.TabIndex = 8;
            this.sochan.Text = "Chọn số chẵn";
            this.sochan.UseVisualStyleBackColor = true;
            this.sochan.Click += new System.EventHandler(this.sochan_Click);
            // 
            // sole
            // 
            this.sole.Font = new System.Drawing.Font("Arial", 10F);
            this.sole.Location = new System.Drawing.Point(6, 298);
            this.sole.Name = "sole";
            this.sole.Size = new System.Drawing.Size(268, 40);
            this.sole.TabIndex = 9;
            this.sole.Text = "Chọn số lẻ";
            this.sole.UseVisualStyleBackColor = true;
            this.sole.Click += new System.EventHandler(this.sole_Click);
            // 
            // ketthuc
            // 
            this.ketthuc.Font = new System.Drawing.Font("Arial", 10F);
            this.ketthuc.Location = new System.Drawing.Point(12, 401);
            this.ketthuc.Name = "ketthuc";
            this.ketthuc.Size = new System.Drawing.Size(508, 40);
            this.ketthuc.TabIndex = 10;
            this.ketthuc.Text = "KẾT THÚC";
            this.ketthuc.UseVisualStyleBackColor = true;
            this.ketthuc.Click += new System.EventHandler(this.ketthuc_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 453);
            this.Controls.Add(this.ketthuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 500);
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form9";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonnhap;
        private System.Windows.Forms.TextBox textnhap;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button sole;
        private System.Windows.Forms.Button sochan;
        private System.Windows.Forms.Button thaybinhphuong;
        private System.Windows.Forms.Button tanglen2;
        private System.Windows.Forms.Button xoadangchon;
        private System.Windows.Forms.Button xoadaucuoi;
        private System.Windows.Forms.Button tongphantu;
        private System.Windows.Forms.Button ketthuc;
    }
}