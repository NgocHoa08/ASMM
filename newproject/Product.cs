using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newproject
{
    public partial class Product : Form
    {
        string str = @"Data Source=Truong_Ngoc_Hoa;Initial Catalog=ASMM;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sql;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dttb;
        public Product()
        {
            InitializeComponent();
        }
        private void Loaddata()
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select ProductID, ProductName, Selling_Price, Quantity from Product", sql);
            adt = new SqlDataAdapter(cmd);
            dttb = new DataTable();
            dataGridView1.DataSource = dttb;
            adt.Fill(dttb);
            sql.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            if (cbb1.SelectedIndex == 0)
            {
                cmd = new SqlCommand("Select ProductID, ProductName, Selling_Price, Quantity from Product WHERE Selling_Price > 50", sql);
            }
            else if (cbb1.SelectedIndex == 1)
            {
                cmd = new SqlCommand("Select ProductID, ProductName, Selling_Price, Quantity from Product WHERE Selling_Price < 100", sql);
            }
            else if (cbb1.SelectedIndex == 2)
            {
                cmd = new SqlCommand("Select ProductID, ProductName, Selling_Price, Quantity from Product order by Selling_Price asc", sql);
            }
            else if (cbb1.SelectedIndex == 3)
            {
                cmd = new SqlCommand("Select ProductID, ProductName, Selling_Price, Quantity from Product order by Selling_Price desc", sql);
            }
            adt = new SqlDataAdapter(cmd);
            dttb = new DataTable();
            adt.Fill(dttb);
            dataGridView1.DataSource = dttb;
            txtsr.Text = "";
            sql.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select ProductID, ProductName, Selling_Price, Quantity from Product", sql);
            adt = new SqlDataAdapter(cmd);
            dttb = new DataTable();
            dataGridView1.DataSource = dttb;
            adt.Fill(dttb);
            sql.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("UPDATE Product SET Quantity = Quantity - 1 WHERE ProductID = @Product_ID", sql);
            cmd.Parameters.AddWithValue("@Product_ID", txtsr.Text);
            cmd.ExecuteNonQuery();
            Loaddata();
            sql.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtsr.Text, out int productId))
            {
                MessageBox.Show("Please enter a valid product ID (numbers only).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select ProductID, ProductName, Selling_Price, Quantity from Product where ProductID = @Product_ID", sql);
            cmd.Parameters.AddWithValue("@Product_ID", txtsr.Text);
            cmd.ExecuteNonQuery();
            adt = new SqlDataAdapter(cmd);
            dttb = new DataTable();
            adt.Fill(dttb);
            dataGridView1.DataSource = dttb;
            sql.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void txtsr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
