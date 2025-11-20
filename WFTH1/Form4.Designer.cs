namespace WFTH1
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chia = new System.Windows.Forms.RadioButton();
            this.tru = new System.Windows.Forms.RadioButton();
            this.cong = new System.Windows.Forms.RadioButton();
            this.nhan = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.so1 = new System.Windows.Forms.TextBox();
            this.so2 = new System.Windows.Forms.TextBox();
            this.ketqua = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số 2:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chia);
            this.groupBox1.Controls.Add(this.tru);
            this.groupBox1.Controls.Add(this.cong);
            this.groupBox1.Controls.Add(this.nhan);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép tính";
            // 
            // chia
            // 
            this.chia.AutoSize = true;
            this.chia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chia.Location = new System.Drawing.Point(370, 34);
            this.chia.Name = "chia";
            this.chia.Size = new System.Drawing.Size(70, 27);
            this.chia.TabIndex = 3;
            this.chia.Text = "Chia";
            this.chia.UseVisualStyleBackColor = true;
            this.chia.CheckedChanged += new System.EventHandler(this.chia_CheckedChanged);
            // 
            // tru
            // 
            this.tru.AutoSize = true;
            this.tru.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tru.Location = new System.Drawing.Point(130, 34);
            this.tru.Name = "tru";
            this.tru.Size = new System.Drawing.Size(63, 27);
            this.tru.TabIndex = 1;
            this.tru.Text = "Trừ";
            this.tru.UseVisualStyleBackColor = true;
            this.tru.CheckedChanged += new System.EventHandler(this.tru_CheckedChanged);
            // 
            // cong
            // 
            this.cong.AutoSize = true;
            this.cong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cong.Location = new System.Drawing.Point(10, 34);
            this.cong.Name = "cong";
            this.cong.Size = new System.Drawing.Size(75, 27);
            this.cong.TabIndex = 0;
            this.cong.Text = "Cộng";
            this.cong.UseVisualStyleBackColor = true;
            this.cong.CheckedChanged += new System.EventHandler(this.cong_CheckedChanged_1);
            // 
            // nhan
            // 
            this.nhan.AutoSize = true;
            this.nhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhan.Location = new System.Drawing.Point(250, 34);
            this.nhan.Name = "nhan";
            this.nhan.Size = new System.Drawing.Size(75, 27);
            this.nhan.TabIndex = 2;
            this.nhan.Text = "Nhân";
            this.nhan.UseVisualStyleBackColor = true;
            this.nhan.CheckedChanged += new System.EventHandler(this.nhan_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kết quả:";
            // 
            // so1
            // 
            this.so1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.so1.Location = new System.Drawing.Point(113, 25);
            this.so1.Multiline = true;
            this.so1.Name = "so1";
            this.so1.Size = new System.Drawing.Size(437, 30);
            this.so1.TabIndex = 4;
            this.so1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // so2
            // 
            this.so2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.so2.Location = new System.Drawing.Point(113, 71);
            this.so2.Multiline = true;
            this.so2.Name = "so2";
            this.so2.Size = new System.Drawing.Size(437, 30);
            this.so2.TabIndex = 5;
            this.so2.TextChanged += new System.EventHandler(this.so2_TextChanged_1);
            // 
            // ketqua
            // 
            this.ketqua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketqua.Location = new System.Drawing.Point(136, 231);
            this.ketqua.Multiline = true;
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(414, 30);
            this.ketqua.TabIndex = 6;
            this.ketqua.TextChanged += new System.EventHandler(this.ketqua_TextChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 303);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.so2);
            this.Controls.Add(this.so1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton tru;
        private System.Windows.Forms.RadioButton nhan;
        private System.Windows.Forms.RadioButton chia;
        private System.Windows.Forms.TextBox so1;
        private System.Windows.Forms.TextBox so2;
        private System.Windows.Forms.TextBox ketqua;
    }
}