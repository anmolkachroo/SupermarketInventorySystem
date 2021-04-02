namespace WindowsFormsApp1
{
    partial class SellingForm
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
            this.BillsDGV = new System.Windows.Forms.DataGridView();
            this.ORDERDGV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.Amtlbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SellerNamelbl = new System.Windows.Forms.Label();
            this.ProdDGV1 = new System.Windows.Forms.DataGridView();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Datelbl = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ProdQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Billid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ORDERDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.BillsDGV);
            this.panel1.Controls.Add(this.ORDERDGV);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Amtlbl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SellerNamelbl);
            this.panel1.Controls.Add(this.ProdDGV1);
            this.panel1.Controls.Add(this.ProdPrice);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.ProdQty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ProdName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Billid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(101, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 777);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BillsDGV
            // 
            this.BillsDGV.BackgroundColor = System.Drawing.Color.White;
            this.BillsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillsDGV.Location = new System.Drawing.Point(436, 441);
            this.BillsDGV.Name = "BillsDGV";
            this.BillsDGV.RowHeadersWidth = 51;
            this.BillsDGV.RowTemplate.Height = 24;
            this.BillsDGV.Size = new System.Drawing.Size(801, 223);
            this.BillsDGV.TabIndex = 30;
            this.BillsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillsDGV_CellContentClick);
            // 
            // ORDERDGV
            // 
            this.ORDERDGV.BackgroundColor = System.Drawing.Color.White;
            this.ORDERDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ORDERDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PName,
            this.Price,
            this.Quantity,
            this.Total});
            this.ORDERDGV.Location = new System.Drawing.Point(436, 78);
            this.ORDERDGV.Name = "ORDERDGV";
            this.ORDERDGV.RowHeadersWidth = 51;
            this.ORDERDGV.RowTemplate.Height = 24;
            this.ORDERDGV.Size = new System.Drawing.Size(849, 241);
            this.ORDERDGV.TabIndex = 29;
            this.ORDERDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ORDERDGV_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ProdiD";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // PName
            // 
            this.PName.HeaderText = "ProdName";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            this.PName.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Qunatity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(668, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "SELLS LIST";
            // 
            // Amtlbl
            // 
            this.Amtlbl.AutoSize = true;
            this.Amtlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amtlbl.ForeColor = System.Drawing.Color.White;
            this.Amtlbl.Location = new System.Drawing.Point(760, 322);
            this.Amtlbl.Name = "Amtlbl";
            this.Amtlbl.Size = new System.Drawing.Size(44, 29);
            this.Amtlbl.TabIndex = 26;
            this.Amtlbl.Text = "Rs";
            this.Amtlbl.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(654, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "Amount";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(97, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 35);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SellerNamelbl
            // 
            this.SellerNamelbl.AutoSize = true;
            this.SellerNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SellerNamelbl.ForeColor = System.Drawing.Color.White;
            this.SellerNamelbl.Location = new System.Drawing.Point(75, 15);
            this.SellerNamelbl.Name = "SellerNamelbl";
            this.SellerNamelbl.Size = new System.Drawing.Size(62, 25);
            this.SellerNamelbl.TabIndex = 23;
            this.SellerNamelbl.Text = "Seller";
            // 
            // ProdDGV1
            // 
            this.ProdDGV1.BackgroundColor = System.Drawing.Color.White;
            this.ProdDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdDGV1.Location = new System.Drawing.Point(40, 357);
            this.ProdDGV1.Name = "ProdDGV1";
            this.ProdDGV1.RowHeadersWidth = 51;
            this.ProdDGV1.RowTemplate.Height = 24;
            this.ProdDGV1.Size = new System.Drawing.Size(373, 387);
            this.ProdDGV1.TabIndex = 22;
            this.ProdDGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV1_CellContentClick);
            // 
            // ProdPrice
            // 
            this.ProdPrice.Enabled = false;
            this.ProdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPrice.Location = new System.Drawing.Point(184, 154);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(205, 30);
            this.ProdPrice.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(18, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Price";
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Datelbl.ForeColor = System.Drawing.Color.White;
            this.Datelbl.Location = new System.Drawing.Point(953, 26);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(53, 25);
            this.Datelbl.TabIndex = 18;
            this.Datelbl.Text = "Date";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.DarkOrange;
            this.button8.Location = new System.Drawing.Point(146, 316);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(112, 35);
            this.button8.TabIndex = 16;
            this.button8.Text = "Refresh";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkOrange;
            this.button4.Location = new System.Drawing.Point(668, 687);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 35);
            this.button4.TabIndex = 11;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ProdQty
            // 
            this.ProdQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQty.Location = new System.Drawing.Point(184, 203);
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Size = new System.Drawing.Size(205, 30);
            this.ProdQty.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "QUANTITY";
            // 
            // ProdName
            // 
            this.ProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdName.Location = new System.Drawing.Point(184, 107);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(205, 30);
            this.ProdName.TabIndex = 4;
            this.ProdName.TextChanged += new System.EventHandler(this.ProdName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prod Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Billid
            // 
            this.Billid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Billid.Location = new System.Drawing.Point(184, 61);
            this.Billid.Name = "Billid";
            this.Billid.Size = new System.Drawing.Size(205, 30);
            this.Billid.TabIndex = 2;
            this.Billid.TextChanged += new System.EventHandler(this.ProdId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "BILL ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(418, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELLING";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DarkOrange;
            this.button5.Location = new System.Drawing.Point(1369, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 37);
            this.button5.TabIndex = 5;
            this.button5.Text = "x";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkOrange;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 753);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Logout";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 888);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ORDERDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox ProdQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Billid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.TextBox ProdPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView ProdDGV1;
        private System.Windows.Forms.Label SellerNamelbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Amtlbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView ORDERDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridView BillsDGV;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
    }
}