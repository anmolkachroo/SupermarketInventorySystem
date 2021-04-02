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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerForm seller = new SellerForm();
            seller.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\OneDrive\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void fillcombo()
        {
            //This method will bind the Combobox with the Database 
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoryTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            CatCb.ValueMember = "CatName";
            CatCb.DataSource = dt;
            comboBox2.ValueMember = "catName";
            comboBox2.DataSource = dt;
            Con.Close();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            fillcombo();
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into ProductTbl values (" + ProdId.Text + ",'" + ProdName.Text + "','" + ProdQty.Text + "','"+ProdPrice.Text+"','"+CatCb.SelectedValue.ToString()+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                Con.Close();
                populate();
                ProdId.Text = "";
                ProdName.Text = "";
                ProdQty.Text = "";
                ProdPrice.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId.Text == "" || ProdName.Text == "" || ProdQty.Text == "" || ProdPrice.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update ProductTbl set ProdName='" + ProdName.Text + "',ProdQty='" + ProdQty.Text + "',ProdPrice='" + ProdPrice.Text + "' where Prodid=" + ProdId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Updated");
                    Con.Close();
                    populate();
                    ProdId.Text = "";
                    ProdName.Text = "";
                    ProdQty.Text = "";
                    ProdPrice.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ProdDGV.Rows[e.RowIndex];
                ProdId.Text = row.Cells[0].Value.ToString();
                ProdName.Text = row.Cells[1].Value.ToString();
                ProdQty.Text = row.Cells[2].Value.ToString();
                ProdPrice.Text = row.Cells[3].Value.ToString();
                CatCb.SelectedValue = row.Cells[4].Value.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId.Text == "")
                {
                    MessageBox.Show("Select The Product To Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from ProductTbl where Prodid=" + ProdId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");
                    Con.Close();
                    populate();
                    ProdId.Text = "";
                    ProdName.Text = "";
                    ProdQty.Text = "";
                    ProdPrice.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select ProdName,ProdQty from ProductTbl where ProdCat = " + comboBox2.SelectedValue.ToString() + ";";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
}
