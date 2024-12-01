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
    public partial class Shirt : Form
    {
        string str = @"Data Source=Truong_Ngoc_Hoa;Initial Catalog=ASMM;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sql;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dttb;
        public Shirt()
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
            dataGridView1.DataSource = dttb;
            sql.Close();
        }
        private void Shirt_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Product", sql);
            cmd.Parameters.AddWithValue("@Shirt_ID",txtsr.Text);
            cmd.ExecuteNonQuery ();
            adt = new SqlDataAdapter(cmd);
            dataGridView1.DataSource = dttb;
            dttb = new DataTable();
            adt.Fill(dttb);
            sql.Close();
        }

        private void cbb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            DataTable dttb = new DataTable();
            if (cbb1.SelectedIndex == 0) {
                cmd = new SqlCommand("Select Shirt_ID, Shirt_Name, Sellling_Price, Quantity from Shirt where Sellling_Price > 50", sql);
            }
            if (cbb1.SelectedIndex == 1) {
                cmd = new SqlCommand("Select Shirt_ID, Shirt_Name, Sellling_Price, Quantity from Shirt Where Sellling_Price < 100", sql);
            }
            if(cbb1.SelectedIndex == 2)
            {
                cmd = new SqlCommand("Select Shirt_ID, Shirt_Name, Sellling_Price, Quantity from Shirt order by Sellling_Price asc", sql);
            }
            if (cbb1.SelectedIndex == 3)
            {
                cmd = new SqlCommand("Select Shirt_ID, Shirt_Name, Sellling_Price, Quantity from Shirt order by Sellling_Price desc ", sql);
            }
            adt = new SqlDataAdapter(cmd);
            dttb = new DataTable();
            adt.Fill(dttb);
            dataGridView1.DataSource = dttb;
            txtsr.Text = "";
            sql.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Product", sql);
            adt = new SqlDataAdapter(cmd);
            dttb = new DataTable();
            adt.Fill(dttb);
            dataGridView1.DataSource = dttb;
            Loaddata();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Delete from Product where ProductID = @ProductID", sql);
            cmd.Parameters.AddWithValue("ProductID", txtsr.Text);
            cmd.ExecuteNonQuery();
            adt.Fill(dttb);
            Loaddata();
            sql.Close();
        }
    }
}
