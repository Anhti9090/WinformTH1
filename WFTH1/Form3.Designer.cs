namespace WFTH1
{
    partial class Form3
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
            this.capnhat = new System.Windows.Forms.Button();
            this.boxcapnhat = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tonguocso = new System.Windows.Forms.Button();
            this.uocsochan = new System.Windows.Forms.Button();
            this.songuyento = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.capnhat);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.boxcapnhat);
            this.groupBox1.Location = new System.Drawing.Point(40, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // capnhat
            // 
            this.capnhat.Location = new System.Drawing.Point(171, 25);
            this.capnhat.Name = "capnhat";
            this.capnhat.Size = new System.Drawing.Size(95, 32);
            this.capnhat.TabIndex = 0;
            this.capnhat.Text = "Cập nhật";
            this.capnhat.UseVisualStyleBackColor = true;
            this.capnhat.Click += new System.EventHandler(this.capnhat_Click);
            // 
            // boxcapnhat
            // 
            this.boxcapnhat.Location = new System.Drawing.Point(25, 25);
            this.boxcapnhat.Multiline = true;
            this.boxcapnhat.Name = "boxcapnhat";
            this.boxcapnhat.Size = new System.Drawing.Size(133, 32);
            this.boxcapnhat.TabIndex = 1;
            this.boxcapnhat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(346, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(20, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(161, 84);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // tonguocso
            // 
            this.tonguocso.Location = new System.Drawing.Point(346, 168);
            this.tonguocso.Name = "tonguocso";
            this.tonguocso.Size = new System.Drawing.Size(200, 37);
            this.tonguocso.TabIndex = 2;
            this.tonguocso.Text = "Tổng các ước số";
            this.tonguocso.UseVisualStyleBackColor = true;
            this.tonguocso.Click += new System.EventHandler(this.tonguocso_Click);
            // 
            // uocsochan
            // 
            this.uocsochan.Location = new System.Drawing.Point(346, 224);
            this.uocsochan.Name = "uocsochan";
            this.uocsochan.Size = new System.Drawing.Size(200, 37);
            this.uocsochan.TabIndex = 3;
            this.uocsochan.Text = "Số lượng các ước số chẵn";
            this.uocsochan.UseVisualStyleBackColor = true;
            this.uocsochan.Click += new System.EventHandler(this.uocsochan_Click);
            // 
            // songuyento
            // 
            this.songuyento.Location = new System.Drawing.Point(346, 276);
            this.songuyento.Name = "songuyento";
            this.songuyento.Size = new System.Drawing.Size(200, 37);
            this.songuyento.TabIndex = 4;
            this.songuyento.Text = "Số lượng các ước số nguyên tố";
            this.songuyento.UseVisualStyleBackColor = true;
            this.songuyento.Click += new System.EventHandler(this.songuyento_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(214, 276);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(92, 37);
            this.thoat.TabIndex = 5;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 328);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.songuyento);
            this.Controls.Add(this.uocsochan);
            this.Controls.Add(this.tonguocso);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox boxcapnhat;
        private System.Windows.Forms.Button capnhat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button tonguocso;
        private System.Windows.Forms.Button uocsochan;
        private System.Windows.Forms.Button songuyento;
        private System.Windows.Forms.Button thoat;
    }
}