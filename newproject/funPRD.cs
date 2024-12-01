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

namespace newproject
{
    public partial class funPRD : Form
    {
        string str = @"Data Source=Truong_Ngoc_Hoa;Initial Catalog=ASMM;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sql;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dttb;
        public funPRD()
        {
            InitializeComponent();
        }
        private void Loaddata()
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Product", sql);
            adt = new SqlDataAdapter(cmd);
            dttb = new DataTable();
            adt.Fill(dttb);
            sql.Close();
        }
        private void funtrousers_Load(object sender, EventArgs e) 
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtid.Text, out int productId))
                {
                    MessageBox.Show("Product ID must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sql = new SqlConnection(str);
                sql.Open();
                string checkQuery = "SELECT COUNT(*) FROM Product WHERE ProductID = @ProductID";
                SqlCommand cmdCheck = new SqlCommand(checkQuery, sql);
                cmdCheck.Parameters.AddWithValue("@ProductID", txtid.Text);

                int count = (int)cmdCheck.ExecuteScalar(); 
                if (count > 0)
                {
                    MessageBox.Show("This product ID already exists, please choose a different ID.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sql.Close();
                    return;
                }
                string insertQuery = "INSERT INTO Product(ProductID, ProductName, Input_Price, Selling_Price, Quantity) " +
                    "VALUES(@ProductID, @ProductName, @Input_Price, @Selling_Price, @Quantity)";
                SqlCommand cmd = new SqlCommand(insertQuery, sql);
                cmd.Parameters.AddWithValue("@ProductID", txtid.Text);
                cmd.Parameters.AddWithValue("@ProductName", txtname.Text);
                cmd.Parameters.AddWithValue("@Input_Price", txtentry.Text);
                cmd.Parameters.AddWithValue("@Selling_Price", txtsell.Text);
                cmd.Parameters.AddWithValue("@Quantity", txtqtt.Text);
                cmd.ExecuteNonQuery();
                Loaddata();
                MessageBox.Show("Product added successfully.");
                sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            adt = new SqlDataAdapter(cmd);
            string edit = ("update Product set ProductID = @ProductID, ProductName = @ProductName, Input_Price = @Input_Price," +
                " Selling_Price = @Selling_Price, Quantity = @Quantity where ProductID = @ProductID");
            cmd = new SqlCommand(edit, sql);
            cmd.Parameters.AddWithValue("@ProductID", txtid.Text);
            cmd.Parameters.AddWithValue("@ProductName", txtname.Text);
            cmd.Parameters.AddWithValue("@Input_Price", txtentry.Text);
            cmd.Parameters.AddWithValue("@Selling_Price", txtsell.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtqtt.Text);
            cmd.ExecuteNonQuery();
            Loaddata();
            MessageBox.Show("More Success");
            sql.Close();
        }
    }
}
