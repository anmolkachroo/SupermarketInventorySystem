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
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\OneDrive\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from SellerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellerDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        

        private void SellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = SellerDGV.Rows[e.RowIndex];
                Sid.Text = row.Cells[0].Value.ToString();
                Sname.Text = row.Cells[1].Value.ToString();
                Sage.Text = row.Cells[2].Value.ToString();
                Sphone.Text = row.Cells[3].Value.ToString();
                Spass.Text = row.Cells[4].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into SellerTbl values (" + Sid.Text + ",'" + Sname.Text + "','" + Sage.Text + "','" + Sphone.Text + "','" + Spass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfully");
                Con.Close();
                populate();
                Sid.Text = "";
                Sname.Text = "";
                Sage.Text = "";
                Sphone.Text = "";
                Spass.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sid.Text == "" || Sname.Text == "" || Sage.Text == "" || Sphone.Text == "" || Spass.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update SellerTbl set SellerName='" + Sname.Text + "',SellerAge='" + Sage.Text + "',SellerPhone='" + Sphone.Text + "',SellerPass='" + Spass.Text + "' where Sellerid=" + Sid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Successfully Updated");
                    Con.Close();
                    populate();
                    Sid.Text = "";
                    Sname.Text = "";
                    Sage.Text = "";
                    Sphone.Text = "";
                    Spass.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sid.Text == "")
                {
                    MessageBox.Show("Select The Seller To Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from SellerTbl where Sellerid=" + Sid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully");
                    Con.Close();
                    populate();
                    Sid.Text = "";
                    Sname.Text = "";
                    Sage.Text = "";
                    Sphone.Text = "";
                    Spass.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
}
