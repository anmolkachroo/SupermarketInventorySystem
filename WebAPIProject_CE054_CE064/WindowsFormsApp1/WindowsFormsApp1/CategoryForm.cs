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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\OneDrive\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into CategoryTbl values ("+CatIdTb.Text+",'"+CatNameTb.Text+"','"+CatDescTb.Text+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                Con.Close();
                populate();
                CatIdTb.Text = "";
                CatNameTb.Text = "";
                CatDescTb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatIdTb.Text == "" || CatNameTb.Text == "" || CatDescTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update CategoryTbl set CatName='" + CatNameTb.Text + "',CatDesc='" + CatDescTb.Text + "' where Catid=" + CatIdTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Updated");
                    Con.Close();
                    populate();
                    CatIdTb.Text = "";
                    CatNameTb.Text = "";
                    CatDescTb.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if(CatIdTb.Text == "")
                {
                    MessageBox.Show("Select The Category To Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from CategoryTbl where Catid=" + CatIdTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    Con.Close();
                    populate();
                    CatIdTb.Text = "";
                    CatNameTb.Text = "";
                    CatDescTb.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from CategoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CatDGV.Rows[e.RowIndex];
                CatIdTb.Text = row.Cells[0].Value.ToString();
                CatNameTb.Text = row.Cells[1].Value.ToString();
                CatDescTb.Text = row.Cells[2].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerForm seller = new SellerForm();
            seller.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
}
