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
    public partial class Static : Form
    {
        string str = @"Data Source=Truong_Ngoc_Hoa;Initial Catalog=ASMM;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sql;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dttb;
        public Static()
        {
            InitializeComponent();
        }
        private void Loaddata()
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select ProductID, ProductName, Profit, GETDATE() from Product ", sql);
            adt = new SqlDataAdapter(cmd);
            dttb = new DataTable();
            adt.Fill(dttb);
            dataGridView1.DataSource = dttb;
            sql.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select ProductID, ProductName, Profit, GETDATE() from Static", sql);
            adt = new SqlDataAdapter(cmd);
            dttb = new DataTable();
            adt.Fill(dttb);
            dataGridView1.DataSource = dttb;
            sql.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //sql = new SqlConnection(str);
            //sql.Open();
            //cmd = new SqlCommand("SELECT ProductID, ProductName, Profit, GETDATE() as Time, SUM(Profit) AS Total_Profit FROM Product GROUP BY ProductID", sql);
            //adt = new SqlDataAdapter(cmd);
            //dttb = new DataTable();
            //adt.Fill(dttb);
            //dataGridView1.DataSource = dttb;
            //sql.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select SUM(Profit) AS Total_Profit, Getdate() as Time FROM Product GROUP BY Profit", sql);
            adt = new SqlDataAdapter(cmd);
            dttb = new DataTable();
            adt.Fill(dttb);
            dataGridView1.DataSource = dttb;
            sql.Close();
        }

        private void Static_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select ProductID, ProductName, Profit, GETDATE() as Time from Product", sql);
            adt = new SqlDataAdapter(cmd);
            dttb = new DataTable();
            adt.Fill(dttb);
            dataGridView1.DataSource = dttb;
            sql.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
