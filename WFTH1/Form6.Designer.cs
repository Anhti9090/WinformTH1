namespace WFTH1
{
    partial class Form6
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timesnewroman = new System.Windows.Forms.RadioButton();
            this.arial = new System.Windows.Forms.RadioButton();
            this.tahoma = new System.Windows.Forms.RadioButton();
            this.couriernew = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập văn bản:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(51, 92);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 256);
            this.textBox1.TabIndex = 1;
            // 
            // timesnewroman
            // 
            this.timesnewroman.AutoSize = true;
            this.timesnewroman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesnewroman.Location = new System.Drawing.Point(300, 115);
            this.timesnewroman.Name = "timesnewroman";
            this.timesnewroman.Size = new System.Drawing.Size(198, 29);
            this.timesnewroman.TabIndex = 2;
            this.timesnewroman.TabStop = true;
            this.timesnewroman.Text = "Times New Roman";
            this.timesnewroman.UseVisualStyleBackColor = true;
            this.timesnewroman.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // arial
            // 
            this.arial.AutoSize = true;
            this.arial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arial.Location = new System.Drawing.Point(300, 165);
            this.arial.Name = "arial";
            this.arial.Size = new System.Drawing.Size(72, 29);
            this.arial.TabIndex = 3;
            this.arial.TabStop = true;
            this.arial.Text = "Arial";
            this.arial.UseVisualStyleBackColor = true;
            this.arial.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // tahoma
            // 
            this.tahoma.AutoSize = true;
            this.tahoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tahoma.Location = new System.Drawing.Point(300, 215);
            this.tahoma.Name = "tahoma";
            this.tahoma.Size = new System.Drawing.Size(106, 29);
            this.tahoma.TabIndex = 4;
            this.tahoma.TabStop = true;
            this.tahoma.Text = "Tahoma";
            this.tahoma.UseVisualStyleBackColor = true;
            this.tahoma.CheckedChanged += new System.EventHandler(this.tahoma_CheckedChanged);
            // 
            // couriernew
            // 
            this.couriernew.AutoSize = true;
            this.couriernew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.couriernew.Location = new System.Drawing.Point(300, 265);
            this.couriernew.Name = "couriernew";
            this.couriernew.Size = new System.Drawing.Size(141, 29);
            this.couriernew.TabIndex = 5;
            this.couriernew.TabStop = true;
            this.couriernew.Text = "Courier New";
            this.couriernew.UseVisualStyleBackColor = true;
            this.couriernew.CheckedChanged += new System.EventHandler(this.couriernew_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(164, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.couriernew);
            this.Controls.Add(this.tahoma);
            this.Controls.Add(this.arial);
            this.Controls.Add(this.timesnewroman);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "frmFont";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton timesnewroman;
        private System.Windows.Forms.RadioButton arial;
        private System.Windows.Forms.RadioButton tahoma;
        private System.Windows.Forms.RadioButton couriernew;
        private System.Windows.Forms.Button button1;
    }
}