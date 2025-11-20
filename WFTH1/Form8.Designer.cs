namespace WFTH1
{
    partial class Form8
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textA = new System.Windows.Forms.TextBox();
            this.giai = new System.Windows.Forms.Button();
            this.textB = new System.Windows.Forms.TextBox();
            this.textNPT = new System.Windows.Forms.TextBox();
            this.xoa = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH BẬC NHẤT AX + B =  0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nghiệm phương trình";
            // 
            // textA
            // 
            this.textA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textA.Location = new System.Drawing.Point(261, 51);
            this.textA.Multiline = true;
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(331, 30);
            this.textA.TabIndex = 4;
            // 
            // giai
            // 
            this.giai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giai.Location = new System.Drawing.Point(150, 215);
            this.giai.Name = "giai";
            this.giai.Size = new System.Drawing.Size(100, 40);
            this.giai.TabIndex = 5;
            this.giai.Text = "Giải";
            this.giai.UseVisualStyleBackColor = true;
            this.giai.Click += new System.EventHandler(this.giai_Click);
            // 
            // textB
            // 
            this.textB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB.Location = new System.Drawing.Point(261, 101);
            this.textB.Multiline = true;
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(331, 30);
            this.textB.TabIndex = 6;
            // 
            // textNPT
            // 
            this.textNPT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNPT.Location = new System.Drawing.Point(261, 151);
            this.textNPT.Multiline = true;
            this.textNPT.Name = "textNPT";
            this.textNPT.Size = new System.Drawing.Size(330, 30);
            this.textNPT.TabIndex = 7;
            // 
            // xoa
            // 
            this.xoa.Enabled = false;
            this.xoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Location = new System.Drawing.Point(325, 215);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(100, 40);
            this.xoa.TabIndex = 8;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // thoat
            // 
            this.thoat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Location = new System.Drawing.Point(492, 215);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(100, 40);
            this.thoat.TabIndex = 9;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 303);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.textNPT);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.giai);
            this.Controls.Add(this.textA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form8_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.Button giai;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.TextBox textNPT;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}