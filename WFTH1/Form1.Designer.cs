namespace WFTH1
{
    partial class Form1
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
            this.ghinho = new System.Windows.Forms.CheckBox();
            this.dangnhap = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dung = new System.Windows.Forms.Button();
            this.labeltendangnhap = new System.Windows.Forms.Label();
            this.boxdangnhap = new System.Windows.Forms.TextBox();
            this.boxmatkhau = new System.Windows.Forms.TextBox();
            this.labelmatkhau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ghinho
            // 
            this.ghinho.AutoSize = true;
            this.ghinho.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghinho.Location = new System.Drawing.Point(63, 141);
            this.ghinho.Name = "ghinho";
            this.ghinho.Size = new System.Drawing.Size(104, 29);
            this.ghinho.TabIndex = 0;
            this.ghinho.Text = "Ghi nhớ";
            this.ghinho.UseVisualStyleBackColor = true;
            this.ghinho.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dangnhap
            // 
            this.dangnhap.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap.Location = new System.Drawing.Point(63, 188);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(141, 45);
            this.dangnhap.TabIndex = 1;
            this.dangnhap.Text = "Đăng nhập";
            this.dangnhap.UseVisualStyleBackColor = true;
            this.dangnhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(210, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dung
            // 
            this.dung.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dung.Location = new System.Drawing.Point(326, 188);
            this.dung.Name = "dung";
            this.dung.Size = new System.Drawing.Size(110, 45);
            this.dung.TabIndex = 3;
            this.dung.Text = "Dừng";
            this.dung.UseVisualStyleBackColor = true;
            this.dung.Click += new System.EventHandler(this.button3_Click);
            // 
            // labeltendangnhap
            // 
            this.labeltendangnhap.AutoSize = true;
            this.labeltendangnhap.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltendangnhap.Location = new System.Drawing.Point(53, 41);
            this.labeltendangnhap.Name = "labeltendangnhap";
            this.labeltendangnhap.Size = new System.Drawing.Size(140, 25);
            this.labeltendangnhap.TabIndex = 4;
            this.labeltendangnhap.Text = "Tên đăng nhập";
            this.labeltendangnhap.Click += new System.EventHandler(this.label1_Click);
            // 
            // boxdangnhap
            // 
            this.boxdangnhap.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxdangnhap.Location = new System.Drawing.Point(210, 29);
            this.boxdangnhap.Multiline = true;
            this.boxdangnhap.Name = "boxdangnhap";
            this.boxdangnhap.Size = new System.Drawing.Size(226, 38);
            this.boxdangnhap.TabIndex = 6;
            this.boxdangnhap.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // boxmatkhau
            // 
            this.boxmatkhau.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxmatkhau.Location = new System.Drawing.Point(210, 89);
            this.boxmatkhau.Multiline = true;
            this.boxmatkhau.Name = "boxmatkhau";
            this.boxmatkhau.Size = new System.Drawing.Size(226, 38);
            this.boxmatkhau.TabIndex = 8;
            // 
            // labelmatkhau
            // 
            this.labelmatkhau.AutoSize = true;
            this.labelmatkhau.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmatkhau.Location = new System.Drawing.Point(58, 101);
            this.labelmatkhau.Name = "labelmatkhau";
            this.labelmatkhau.Size = new System.Drawing.Size(95, 25);
            this.labelmatkhau.TabIndex = 7;
            this.labelmatkhau.Text = "Mật khẩu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 273);
            this.Controls.Add(this.boxmatkhau);
            this.Controls.Add(this.labelmatkhau);
            this.Controls.Add(this.boxdangnhap);
            this.Controls.Add(this.labeltendangnhap);
            this.Controls.Add(this.dung);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dangnhap);
            this.Controls.Add(this.ghinho);
            this.MaximumSize = new System.Drawing.Size(540, 320);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Đăng Nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ghinho;
        private System.Windows.Forms.Button dangnhap;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button dung;
        private System.Windows.Forms.Label labeltendangnhap;
        private System.Windows.Forms.TextBox boxdangnhap;
        private System.Windows.Forms.TextBox boxmatkhau;
        private System.Windows.Forms.Label labelmatkhau;
    }
}

