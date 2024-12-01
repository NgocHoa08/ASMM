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
    public partial class Funcs : Form
    {
        string str = @"Data Source=Truong_Ngoc_Hoa;Initial Catalog=ASMM;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sql;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dttb;
        public Funcs()
        {
            InitializeComponent();
        }
        private void Loaddata()
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Customer",sql);
            adt = new SqlDataAdapter(cmd);
            dttb = new DataTable();
            adt.Fill(dttb);
            sql.Close();
            MessageBox.Show("Success");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sql = new SqlConnection(str);
                sql.Open();
                string add = ("insert into Customer(CustomerID, CustomerName, Phone_Number, Address) values(@Customer_ID, @Customer_Name, @Phone_Number, @Address)");
                cmd = new SqlCommand(add, sql);
                cmd.Parameters.AddWithValue("@Customer_ID", txtid.Text);
                cmd.Parameters.AddWithValue("@Customer_Name", txtname.Text);
                cmd.Parameters.AddWithValue("@Phone_Number", txtphone.Text);
                cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
                cmd.ExecuteNonQuery();
                Loaddata();
                sql.Close();
                MessageBox.Show("Success");
            }
            catch {
                if (!int.TryParse(txtid.Text, out int productId))
                {
                    MessageBox.Show("This product ID already exists, please re-enter.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void Function_Load(object sender, EventArgs e)
        {

        }

        private void btedit_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string edit = ("Update Customer set CustomerID = @Customer_ID, CustomerName = @Customer_Name, Phone_Number = @Phone_Number, Address = @Address where CustomerID = @Employee_ID");
            cmd = new SqlCommand(edit, sql);
            cmd.Parameters.AddWithValue("@Customer_ID", txtid.Text);
            cmd.Parameters.AddWithValue("@Customer_Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Phone_Number", txtphone.Text);
            cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
            cmd.ExecuteNonQuery();
            Loaddata();
            sql.Close();
            MessageBox.Show("Success");

        }
    }
}
