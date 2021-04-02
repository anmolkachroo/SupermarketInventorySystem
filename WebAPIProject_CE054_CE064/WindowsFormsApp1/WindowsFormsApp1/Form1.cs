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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string Sellername = "";
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\OneDrive\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(UnameTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Enter the User Name and Password ");
            }
            else
            {
                if(RoleCb.SelectedItem.ToString() == "Admin")
                {
                    if (UnameTb.Text == "Admin" && PassTb.Text == "Admin") 
                    {
                        ProductForm prod = new ProductForm();
                        prod.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("If you are the Admin, Enter the Correct Id and password");
                    }
                }
                else if(RoleCb.SelectedItem.ToString()=="Seller")
                {
                    //MessageBox.Show("You are in the Seller Section");
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select count(8) from SellerTbl where SellerName ='"+UnameTb.Text+ "' and SellerPass='"+ PassTb.Text+"'",Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if(dt.Rows[0][0].ToString() == "1")
                    {
                        Sellername = UnameTb.Text;
                        SellingForm sell = new SellingForm();
                        sell.Show();
                        this.Hide();
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong UserName or Password");
                    }
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Select a Role");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PassTb.Text = "";
        }
    }
}
