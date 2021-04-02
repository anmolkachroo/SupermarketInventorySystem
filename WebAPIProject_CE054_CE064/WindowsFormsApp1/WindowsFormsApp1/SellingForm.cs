using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\OneDrive\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select ProdName,ProdQty from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV1.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void populatebills()
        {
            Con.Open();
            string query = "select * from BillTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BillsDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void button8_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProdId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ProdName_TextChanged(object sender, EventArgs e)
        {

        }


        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            populatebills();
            SellerNamelbl.Text = Form1.Sellername;
            
        }
        int flag = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProdDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ProdDGV1.Rows[e.RowIndex];               
                ProdName.Text = row.Cells[0].Value.ToString();
                ProdPrice.Text = row.Cells[1].Value.ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Billid.Text == "")
            {
                MessageBox.Show("Missing Bill id");
            }
            else
            { 
            try
            {
                Con.Open();
                string query = "insert into BillTbl values (" + Billid.Text + ",'" + SellerNamelbl.Text + "','" + Datelbl.Text + "','" + Amtlbl.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully");
                Con.Close();
                populatebills();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ORDERDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int Grdtotal = 0, n=0;

        private void BillsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1;

        }
        

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            
            e.Graphics.DrawString("FAMILYSUPERMARKET",new Font("Century Gothic",25,FontStyle.Bold),Brushes.Red,new Point(230));
            //e.Graphics.DrawString(, new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(130,150));

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        

        private void label6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(ProdName.Text == "" || ProdQty.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int total = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
                DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(ORDERDGV);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = ProdName.Text;
            newRow.Cells[2].Value = ProdPrice.Text;
            newRow.Cells[3].Value = ProdQty.Text;
            newRow.Cells[4].Value = Convert.ToInt32(ProdPrice.Text)*Convert.ToInt32(ProdQty.Text);
            ORDERDGV.Rows.Add(newRow);
                n++;
            Grdtotal = Grdtotal + total;
            Amtlbl.Text = ""+ Grdtotal;
            }
        }
    }
}
