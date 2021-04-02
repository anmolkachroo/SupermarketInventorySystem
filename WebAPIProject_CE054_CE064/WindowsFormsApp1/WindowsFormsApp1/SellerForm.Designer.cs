namespace WindowsFormsApp1
{
    partial class SellerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SellerDGV = new System.Windows.Forms.DataGridView();
            this.Spass = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Sphone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Sage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Sname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Sid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.SellerDGV);
            this.panel1.Controls.Add(this.Spass);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Sphone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Sage);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Sname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Sid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(184, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 801);
            this.panel1.TabIndex = 1;
            // 
            // SellerDGV
            // 
            this.SellerDGV.BackgroundColor = System.Drawing.Color.White;
            this.SellerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellerDGV.Location = new System.Drawing.Point(419, 108);
            this.SellerDGV.Name = "SellerDGV";
            this.SellerDGV.RowHeadersWidth = 51;
            this.SellerDGV.RowTemplate.Height = 24;
            this.SellerDGV.Size = new System.Drawing.Size(722, 642);
            this.SellerDGV.TabIndex = 16;
            this.SellerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellerDGV_CellContentClick);
            // 
            // Spass
            // 
            this.Spass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spass.Location = new System.Drawing.Point(184, 430);
            this.Spass.Name = "Spass";
            this.Spass.PasswordChar = '*';
            this.Spass.Size = new System.Drawing.Size(205, 30);
            this.Spass.TabIndex = 15;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.DarkOrange;
            this.button7.Location = new System.Drawing.Point(200, 507);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 35);
            this.button7.TabIndex = 13;
            this.button7.Text = "DELETE";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.DarkOrange;
            this.button6.Location = new System.Drawing.Point(115, 507);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 35);
            this.button6.TabIndex = 12;
            this.button6.Text = "EDIT";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkOrange;
            this.button4.Location = new System.Drawing.Point(23, 507);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 35);
            this.button4.TabIndex = 11;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "PASSWORD";
            // 
            // Sphone
            // 
            this.Sphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sphone.Location = new System.Drawing.Point(184, 352);
            this.Sphone.Name = "Sphone";
            this.Sphone.Size = new System.Drawing.Size(205, 30);
            this.Sphone.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "PHONE";
            // 
            // Sage
            // 
            this.Sage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sage.Location = new System.Drawing.Point(184, 275);
            this.Sage.Name = "Sage";
            this.Sage.Size = new System.Drawing.Size(205, 30);
            this.Sage.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "AGE";
            // 
            // Sname
            // 
            this.Sname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sname.Location = new System.Drawing.Point(184, 189);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(205, 30);
            this.Sname.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "NAME";
            // 
            // Sid
            // 
            this.Sid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sid.Location = new System.Drawing.Point(184, 108);
            this.Sid.Name = "Sid";
            this.Sid.Size = new System.Drawing.Size(205, 30);
            this.Sid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(414, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE SELLERS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DarkOrange;
            this.button5.Location = new System.Drawing.Point(1309, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 37);
            this.button5.TabIndex = 5;
            this.button5.Text = "x";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(12, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Products";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(1, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Categories";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkOrange;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(49, 762);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Logout";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 912);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Sphone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Sage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Sname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Sid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Spass;
        private System.Windows.Forms.DataGridView SellerDGV;
        private System.Windows.Forms.Label label7;
    }
}