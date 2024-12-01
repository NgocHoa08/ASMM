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
    public partial class FuncEpl : Form
    {
        string str = @"Data Source=Truong_Ngoc_Hoa;Initial Catalog=ASMM;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sql;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dttb;
        public FuncEpl()
        {
            InitializeComponent();
        }
        private void Loaddata()
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Employee", sql);
            adt = new SqlDataAdapter(cmd);
            dttb = new DataTable();
            adt.Fill(dttb);
            sql.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string add = ("Insert into Employee(EmployeeID, EmployeeName, Phone_Number, Address) values(@Employee_ID, @Employee_Name, @Phone_Number, @Address)");
            cmd = new SqlCommand(add,sql);
            cmd.Parameters.AddWithValue("@Employee_ID",txtid.Text);
            cmd.Parameters.AddWithValue("@Employee_Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Phone_Number", txtphone.Text);
            cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
            cmd.ExecuteNonQuery();
            adt = new SqlDataAdapter(cmd);
            dttb = new DataTable();
            Loaddata();
            sql.Close ();
            MessageBox.Show("Success");
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string edit = ("Update Employee set EmployeeID = @Employee_ID, EmplloyeeName = @Emplloyee_Name, Phone_Number = @Phone_Number, Address = @Address where EmployeeID = @Employee_ID");
            cmd = new SqlCommand(edit, sql);
            cmd.Parameters.AddWithValue("@Employee_ID", txtid.Text);
            cmd.Parameters.AddWithValue("@Emplloyee_Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Phone_Number", txtphone.Text);
            cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
            cmd.ExecuteNonQuery();
            Loaddata();
            sql.Close();
            MessageBox.Show("Success");
        }

        private void FuncEpl_Load(object sender, EventArgs e)
        {

        }
    }
}
