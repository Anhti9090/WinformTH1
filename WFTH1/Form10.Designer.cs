namespace WFTH1
{
    partial class Form10
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textnhap = new System.Windows.Forms.TextBox();
            this.capnhat = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.ketthuc = new System.Windows.Forms.Button();
            this.bangA = new System.Windows.Forms.ListBox();
            this.bangB = new System.Windows.Forms.ListBox();
            this.A_B = new System.Windows.Forms.Button();
            this.A__B = new System.Windows.Forms.Button();
            this.B_A = new System.Windows.Forms.Button();
            this.B__A = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bangA);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 260);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bangB);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(380, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 260);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B";
            // 
            // textnhap
            // 
            this.textnhap.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnhap.Location = new System.Drawing.Point(157, 64);
            this.textnhap.Multiline = true;
            this.textnhap.Name = "textnhap";
            this.textnhap.Size = new System.Drawing.Size(244, 40);
            this.textnhap.TabIndex = 4;
            // 
            // capnhat
            // 
            this.capnhat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capnhat.Location = new System.Drawing.Point(452, 64);
            this.capnhat.Name = "capnhat";
            this.capnhat.Size = new System.Drawing.Size(109, 40);
            this.capnhat.TabIndex = 5;
            this.capnhat.Text = "Cập nhật";
            this.capnhat.UseVisualStyleBackColor = true;
            this.capnhat.Click += new System.EventHandler(this.capnhat_Click);
            // 
            // xoa
            // 
            this.xoa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Location = new System.Drawing.Point(131, 391);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(109, 40);
            this.xoa.TabIndex = 6;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // ketthuc
            // 
            this.ketthuc.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketthuc.Location = new System.Drawing.Point(380, 391);
            this.ketthuc.Name = "ketthuc";
            this.ketthuc.Size = new System.Drawing.Size(109, 40);
            this.ketthuc.TabIndex = 7;
            this.ketthuc.Text = "Kết thúc";
            this.ketthuc.UseVisualStyleBackColor = true;
            this.ketthuc.Click += new System.EventHandler(this.ketthuc_Click);
            // 
            // bangA
            // 
            this.bangA.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bangA.FormattingEnabled = true;
            this.bangA.ItemHeight = 19;
            this.bangA.Location = new System.Drawing.Point(7, 21);
            this.bangA.Name = "bangA";
            this.bangA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.bangA.Size = new System.Drawing.Size(187, 213);
            this.bangA.TabIndex = 0;
            // 
            // bangB
            // 
            this.bangB.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bangB.FormattingEnabled = true;
            this.bangB.ItemHeight = 19;
            this.bangB.Location = new System.Drawing.Point(7, 21);
            this.bangB.Name = "bangB";
            this.bangB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.bangB.Size = new System.Drawing.Size(187, 213);
            this.bangB.TabIndex = 1;
            // 
            // A_B
            // 
            this.A_B.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_B.Location = new System.Drawing.Point(256, 164);
            this.A_B.Name = "A_B";
            this.A_B.Size = new System.Drawing.Size(109, 40);
            this.A_B.TabIndex = 8;
            this.A_B.Text = ">";
            this.A_B.UseVisualStyleBackColor = true;
            this.A_B.Click += new System.EventHandler(this.A_B_Click);
            // 
            // A__B
            // 
            this.A__B.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A__B.Location = new System.Drawing.Point(256, 210);
            this.A__B.Name = "A__B";
            this.A__B.Size = new System.Drawing.Size(109, 40);
            this.A__B.TabIndex = 9;
            this.A__B.Text = ">>";
            this.A__B.UseVisualStyleBackColor = true;
            this.A__B.Click += new System.EventHandler(this.A__B_Click);
            // 
            // B_A
            // 
            this.B_A.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_A.Location = new System.Drawing.Point(256, 256);
            this.B_A.Name = "B_A";
            this.B_A.Size = new System.Drawing.Size(109, 40);
            this.B_A.TabIndex = 10;
            this.B_A.Text = "<";
            this.B_A.UseVisualStyleBackColor = true;
            this.B_A.Click += new System.EventHandler(this.B_A_Click);
            // 
            // B__A
            // 
            this.B__A.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B__A.Location = new System.Drawing.Point(256, 302);
            this.B__A.Name = "B__A";
            this.B__A.Size = new System.Drawing.Size(109, 40);
            this.B__A.TabIndex = 11;
            this.B__A.Text = "<<";
            this.B__A.UseVisualStyleBackColor = true;
            this.B__A.Click += new System.EventHandler(this.B__A_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.B__A);
            this.Controls.Add(this.B_A);
            this.Controls.Add(this.A__B);
            this.Controls.Add(this.A_B);
            this.Controls.Add(this.ketthuc);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.capnhat);
            this.Controls.Add(this.textnhap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form10";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textnhap;
        private System.Windows.Forms.ListBox bangA;
        private System.Windows.Forms.ListBox bangB;
        private System.Windows.Forms.Button capnhat;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button ketthuc;
        private System.Windows.Forms.Button A_B;
        private System.Windows.Forms.Button A__B;
        private System.Windows.Forms.Button B_A;
        private System.Windows.Forms.Button B__A;
    }
}