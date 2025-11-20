namespace WFTH1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.boxhovaten = new System.Windows.Forms.TextBox();
            this.radiochuthuong = new System.Windows.Forms.RadioButton();
            this.chonkieuchu = new System.Windows.Forms.GroupBox();
            this.radiochuinhoa = new System.Windows.Forms.RadioButton();
            this.xoa = new System.Windows.Forms.Button();
            this.boxketqua = new System.Windows.Forms.TextBox();
            this.ketqua = new System.Windows.Forms.Button();
            this.chonkieuchu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ và tên:";
            // 
            // boxhovaten
            // 
            this.boxhovaten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxhovaten.Location = new System.Drawing.Point(211, 18);
            this.boxhovaten.Multiline = true;
            this.boxhovaten.Name = "boxhovaten";
            this.boxhovaten.Size = new System.Drawing.Size(270, 36);
            this.boxhovaten.TabIndex = 1;
            // 
            // radiochuthuong
            // 
            this.radiochuthuong.AutoSize = true;
            this.radiochuthuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiochuthuong.Location = new System.Drawing.Point(21, 32);
            this.radiochuthuong.Name = "radiochuthuong";
            this.radiochuthuong.Size = new System.Drawing.Size(119, 26);
            this.radiochuthuong.TabIndex = 2;
            this.radiochuthuong.TabStop = true;
            this.radiochuthuong.Text = "chữ thường";
            this.radiochuthuong.UseVisualStyleBackColor = true;
            // 
            // chonkieuchu
            // 
            this.chonkieuchu.Controls.Add(this.radiochuinhoa);
            this.chonkieuchu.Controls.Add(this.radiochuthuong);
            this.chonkieuchu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chonkieuchu.Location = new System.Drawing.Point(32, 92);
            this.chonkieuchu.Name = "chonkieuchu";
            this.chonkieuchu.Size = new System.Drawing.Size(368, 128);
            this.chonkieuchu.TabIndex = 3;
            this.chonkieuchu.TabStop = false;
            this.chonkieuchu.Text = "Chọn kiểu chữ";
            // 
            // radiochuinhoa
            // 
            this.radiochuinhoa.AutoSize = true;
            this.radiochuinhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiochuinhoa.Location = new System.Drawing.Point(21, 79);
            this.radiochuinhoa.Name = "radiochuinhoa";
            this.radiochuinhoa.Size = new System.Drawing.Size(146, 26);
            this.radiochuinhoa.TabIndex = 3;
            this.radiochuinhoa.TabStop = true;
            this.radiochuinhoa.Text = "CHỮ IN HOA";
            this.radiochuinhoa.UseVisualStyleBackColor = true;
            // 
            // xoa
            // 
            this.xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Location = new System.Drawing.Point(406, 107);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 113);
            this.xoa.TabIndex = 4;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // boxketqua
            // 
            this.boxketqua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxketqua.Location = new System.Drawing.Point(211, 241);
            this.boxketqua.Multiline = true;
            this.boxketqua.Name = "boxketqua";
            this.boxketqua.Size = new System.Drawing.Size(270, 36);
            this.boxketqua.TabIndex = 5;
            // 
            // ketqua
            // 
            this.ketqua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketqua.Location = new System.Drawing.Point(32, 241);
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(133, 36);
            this.ketqua.TabIndex = 6;
            this.ketqua.Text = "Kết quả";
            this.ketqua.UseVisualStyleBackColor = true;
            this.ketqua.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(532, 303);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.boxketqua);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.chonkieuchu);
            this.Controls.Add(this.boxhovaten);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi kiểu chữ";
            this.chonkieuchu.ResumeLayout(false);
            this.chonkieuchu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxhovaten;
        private System.Windows.Forms.RadioButton radiochuthuong;
        private System.Windows.Forms.GroupBox chonkieuchu;
        private System.Windows.Forms.RadioButton radiochuinhoa;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.TextBox boxketqua;
        private System.Windows.Forms.Button ketqua;
    }
}