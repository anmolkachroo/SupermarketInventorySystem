namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UnameTb = new System.Windows.Forms.TextBox();
            this.PassTb = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.RoleCb = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 525);
            this.button1.TabIndex = 0;
            this.button1.Text = "WELCOME SUPERMARKET APPLICATION";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(611, 61);
            this.button2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "LOGIN";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // UnameTb
            // 
            this.UnameTb.Location = new System.Drawing.Point(698, 264);
            this.UnameTb.Name = "UnameTb";
            this.UnameTb.Size = new System.Drawing.Size(243, 38);
            this.UnameTb.TabIndex = 2;
            // 
            // PassTb
            // 
            this.PassTb.Location = new System.Drawing.Point(698, 350);
            this.PassTb.Name = "PassTb";
            this.PassTb.Size = new System.Drawing.Size(243, 38);
            this.PassTb.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(406, 264);
            this.button3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(231, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "USERNAME";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(406, 350);
            this.button4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 38);
            this.button4.TabIndex = 5;
            this.button4.Text = "PASSWORD";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // RoleCb
            // 
            this.RoleCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RoleCb.FormattingEnabled = true;
            this.RoleCb.Items.AddRange(new object[] {
            "Admin",
            "Seller"});
            this.RoleCb.Location = new System.Drawing.Point(658, 170);
            this.RoleCb.Name = "RoleCb";
            this.RoleCb.Size = new System.Drawing.Size(240, 39);
            this.RoleCb.TabIndex = 6;
            this.RoleCb.Text = "Select Role";
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(611, 418);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 38);
            this.button5.TabIndex = 7;
            this.button5.Text = "LOGIN";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button6.Location = new System.Drawing.Point(639, 474);
            this.button6.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 29);
            this.button6.TabIndex = 8;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button7.Location = new System.Drawing.Point(1000, 15);
            this.button7.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(24, 33);
            this.button7.TabIndex = 9;
            this.button7.Text = "x";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 528);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.RoleCb);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PassTb);
            this.Controls.Add(this.UnameTb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox UnameTb;
        private System.Windows.Forms.TextBox PassTb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox RoleCb;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

