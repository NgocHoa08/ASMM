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
    public partial class Employee : Form
    {
        string str = @"Data Source=Truong_Ngoc_Hoa;Initial Catalog=ASMM;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sql;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dttb;
        public Employee()
        {
            InitializeComponent();
        }
        private void Loaddata()
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Employee",sql);
            adt = new SqlDataAdapter(cmd);
            dttb = new DataTable();
            adt.Fill(dttb);
            dataGridView1.DataSource = dttb;    
            sql.Close();
        }
        private void Nhanvien_Load(object sender, EventArgs e)
        {
            
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Employee", sql);
            adt = new SqlDataAdapter(cmd);
            dttb = new DataTable();
            adt.Fill(dttb);
            dataGridView1.DataSource = dttb;
            Loaddata();
            sql.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Employee where EmployeeID = @Employee_ID",sql);
            cmd.Parameters.AddWithValue("@Employee_ID", txtsr.Text);
            cmd.ExecuteNonQuery();
            adt = new SqlDataAdapter(cmd);
            dttb = new DataTable();
            adt.Fill(dttb);
            dataGridView1.DataSource = dttb;
            sql.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Employee", sql);
            adt = new SqlDataAdapter(cmd);
            dttb = new DataTable();
            adt.Fill(dttb);
            dataGridView1.DataSource = dttb;
            Loaddata();
            sql.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Delete From Employee where EmployeeID = @Employee_ID",sql);
            cmd.Parameters.AddWithValue("@Employee_ID", txtsr.Text);
            cmd.ExecuteNonQuery();
            Loaddata();
            sql.Close() ;   
        }
    }
}
