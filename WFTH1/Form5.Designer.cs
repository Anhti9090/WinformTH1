namespace WFTH1
{
    partial class Form5
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
            this.checkdam = new System.Windows.Forms.CheckBox();
            this.checknghieng = new System.Windows.Forms.CheckBox();
            this.checkgachchan = new System.Windows.Forms.CheckBox();
            this.radiored = new System.Windows.Forms.RadioButton();
            this.radiogreen = new System.Windows.Forms.RadioButton();
            this.radioblue = new System.Windows.Forms.RadioButton();
            this.radioblack = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textnhapten = new System.Windows.Forms.TextBox();
            this.thoat = new System.Windows.Forms.Button();
            this.textketqua = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioblack);
            this.groupBox1.Controls.Add(this.radioblue);
            this.groupBox1.Controls.Add(this.radiogreen);
            this.groupBox1.Controls.Add(this.radiored);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkgachchan);
            this.groupBox2.Controls.Add(this.checknghieng);
            this.groupBox2.Controls.Add(this.checkdam);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(221, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 239);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font";
            // 
            // checkdam
            // 
            this.checkdam.AutoSize = true;
            this.checkdam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkdam.ForeColor = System.Drawing.Color.Blue;
            this.checkdam.Location = new System.Drawing.Point(7, 31);
            this.checkdam.Name = "checkdam";
            this.checkdam.Size = new System.Drawing.Size(71, 27);
            this.checkdam.TabIndex = 0;
            this.checkdam.Text = "Đậm";
            this.checkdam.UseVisualStyleBackColor = true;
            this.checkdam.CheckedChanged += new System.EventHandler(this.checkdam_CheckedChanged);
            // 
            // checknghieng
            // 
            this.checknghieng.AutoSize = true;
            this.checknghieng.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checknghieng.ForeColor = System.Drawing.Color.Blue;
            this.checknghieng.Location = new System.Drawing.Point(6, 67);
            this.checknghieng.Name = "checknghieng";
            this.checknghieng.Size = new System.Drawing.Size(103, 27);
            this.checknghieng.TabIndex = 1;
            this.checknghieng.Text = "Nghiêng";
            this.checknghieng.UseVisualStyleBackColor = true;
            this.checknghieng.CheckedChanged += new System.EventHandler(this.checknghieng_CheckedChanged);
            // 
            // checkgachchan
            // 
            this.checkgachchan.AutoSize = true;
            this.checkgachchan.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkgachchan.ForeColor = System.Drawing.Color.Blue;
            this.checkgachchan.Location = new System.Drawing.Point(6, 107);
            this.checkgachchan.Name = "checkgachchan";
            this.checkgachchan.Size = new System.Drawing.Size(121, 27);
            this.checkgachchan.TabIndex = 2;
            this.checkgachchan.Text = "Gạch chân";
            this.checkgachchan.UseVisualStyleBackColor = true;
            this.checkgachchan.CheckedChanged += new System.EventHandler(this.checkgachchan_CheckedChanged);
            // 
            // radiored
            // 
            this.radiored.AutoSize = true;
            this.radiored.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiored.ForeColor = System.Drawing.Color.Red;
            this.radiored.Location = new System.Drawing.Point(7, 30);
            this.radiored.Name = "radiored";
            this.radiored.Size = new System.Drawing.Size(65, 27);
            this.radiored.TabIndex = 0;
            this.radiored.TabStop = true;
            this.radiored.Text = "Red";
            this.radiored.UseVisualStyleBackColor = true;
            this.radiored.CheckedChanged += new System.EventHandler(this.radiored_CheckedChanged);
            // 
            // radiogreen
            // 
            this.radiogreen.AutoSize = true;
            this.radiogreen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiogreen.ForeColor = System.Drawing.Color.Green;
            this.radiogreen.Location = new System.Drawing.Point(7, 67);
            this.radiogreen.Name = "radiogreen";
            this.radiogreen.Size = new System.Drawing.Size(85, 27);
            this.radiogreen.TabIndex = 1;
            this.radiogreen.TabStop = true;
            this.radiogreen.Text = "Green";
            this.radiogreen.UseVisualStyleBackColor = true;
            this.radiogreen.CheckedChanged += new System.EventHandler(this.radiogreen_CheckedChanged);
            // 
            // radioblue
            // 
            this.radioblue.AutoSize = true;
            this.radioblue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioblue.ForeColor = System.Drawing.Color.Blue;
            this.radioblue.Location = new System.Drawing.Point(7, 107);
            this.radioblue.Name = "radioblue";
            this.radioblue.Size = new System.Drawing.Size(69, 27);
            this.radioblue.TabIndex = 2;
            this.radioblue.TabStop = true;
            this.radioblue.Text = "Blue";
            this.radioblue.UseVisualStyleBackColor = true;
            this.radioblue.CheckedChanged += new System.EventHandler(this.radioblue_CheckedChanged);
            // 
            // radioblack
            // 
            this.radioblack.AutoSize = true;
            this.radioblack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioblack.Location = new System.Drawing.Point(7, 145);
            this.radioblack.Name = "radioblack";
            this.radioblack.Size = new System.Drawing.Size(79, 27);
            this.radioblack.TabIndex = 3;
            this.radioblack.TabStop = true;
            this.radioblack.Text = "Black";
            this.radioblack.UseVisualStyleBackColor = true;
            this.radioblack.CheckedChanged += new System.EventHandler(this.radioblack_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lập trình bởi:";
            // 
            // textnhapten
            // 
            this.textnhapten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnhapten.Location = new System.Drawing.Point(108, 20);
            this.textnhapten.Multiline = true;
            this.textnhapten.Name = "textnhapten";
            this.textnhapten.Size = new System.Drawing.Size(150, 30);
            this.textnhapten.TabIndex = 4;
            // 
            // thoat
            // 
            this.thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Location = new System.Drawing.Point(292, 399);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(97, 39);
            this.thoat.TabIndex = 5;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // textketqua
            // 
            this.textketqua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textketqua.Location = new System.Drawing.Point(149, 347);
            this.textketqua.Multiline = true;
            this.textketqua.Name = "textketqua";
            this.textketqua.Size = new System.Drawing.Size(150, 30);
            this.textketqua.TabIndex = 6;
            this.textketqua.TextChanged += new System.EventHandler(this.textketqua_TextChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.textketqua);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.textnhapten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Text = "Định dạng ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkdam;
        private System.Windows.Forms.RadioButton radioblack;
        private System.Windows.Forms.RadioButton radioblue;
        private System.Windows.Forms.RadioButton radiogreen;
        private System.Windows.Forms.RadioButton radiored;
        private System.Windows.Forms.CheckBox checkgachchan;
        private System.Windows.Forms.CheckBox checknghieng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textnhapten;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.TextBox textketqua;
    }
}