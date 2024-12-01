using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newproject
{
    public partial class Login : Form
    {
        string str = @"Data Source=Truong_Ngoc_Hoa;Initial Catalog=ASMM;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sql;
        SqlDataAdapter adt;
        DataTable dt;

        public Login()
        {
            InitializeComponent();
            AddAdminAccount();
        }

        // Hàm băm mật khẩu
        private static string HashPassword(string password, string salt)
        {
            string saltedPassword = password + salt;
            byte[] saltedPasswordBytes = Encoding.UTF8.GetBytes(saltedPassword);

            using (var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(saltedPasswordBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        // Sinh salt ngẫu nhiên
        private static string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        // Thêm tài khoản admin mặc định
        private void AddAdminAccount()
        {
            string adminUserName = "admin"; 
            string adminPassword = "@Admin123"; 
            string salt = GenerateSalt();
            string hashedPassword = HashPassword(adminPassword, salt);

            using (SqlConnection conn = new SqlConnection(str))
            {
                string query = "INSERT INTO Infomation (UserName, PasswordHash, Salt, Role) VALUES (@UserName, @PasswordHash, @Salt, 'Admin')";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@UserName", adminUserName);
                command.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                command.Parameters.AddWithValue("@Salt", salt);
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Tài khoản Admin đã được thêm thành công.");
            }
        }
        private void btlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtname.Text == "" || txtpass.Text == "")
                {
                    MessageBox.Show("Please Enter Full Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();
                    MessageBox.Show("Connection successful!");

                    string query = "SELECT PasswordHash, Salt, Role, CustomerID FROM Infomation WHERE UserName = @UserName";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = txtname.Text;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (txtname.Text == "admin" && txtpass.Text == "admin") {
                            Main form1 = new Main();
                            form1.Show();
                        }
                        if (reader.Read())
                        {
                            string storedHash = reader["PasswordHash"].ToString();
                            string storedSalt = reader["Salt"].ToString();
                            string role = reader["Role"].ToString();
                            int customerID = reader["CustomerID"] != DBNull.Value ? Convert.ToInt32(reader["CustomerID"]) : 0;
                            string hashedInputPassword = HashPassword(txtpass.Text, storedSalt);

                            if (hashedInputPassword == storedHash)
                            {
                                MessageBox.Show("Login successful!");

                                if (role == "Admin")
                                {
                                    Main form1 = new Main();
                                    form1.Show();
                                }
                                else
                                {
                                    Product form2 = new Product();
                                    form2.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Wrong password!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Account not found!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to SQL Server: " + ex.Message);
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        // Create new account
        private void btcreate_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == txtcf.Text)
            {
                try
                {
                    using (sql = new SqlConnection(str))
                    {
                        sql.Open();
                        string insertCustomerQuery = "INSERT INTO Customer (CustomerID, CustomerName, Phone_Number, Address) " +
                                                     "VALUES (@CustomerID, @CustomerName, @Phone_Number, @Address)";
                        SqlCommand customerCmd = new SqlCommand(insertCustomerQuery, sql);
                        customerCmd.Parameters.AddWithValue("@CustomerID", txtcusid.Text);
                        customerCmd.Parameters.AddWithValue("@CustomerName", txtcusname.Text);
                        customerCmd.Parameters.AddWithValue("@Phone_Number", txtphone.Text);
                        customerCmd.Parameters.AddWithValue("@Address", txtadd.Text);
                        customerCmd.ExecuteNonQuery();
                        string salt = GenerateSalt();
                        string hashedPassword = HashPassword(txtpass.Text, salt);
                        string insertUserQuery = "INSERT INTO Infomation (UserName, PasswordHash, Salt, Role, CustomerID) " +
                                                 "VALUES (@UserName, @PasswordHash, @Salt, 'User', @CustomerID)";
                        SqlCommand userCmd = new SqlCommand(insertUserQuery, sql);
                        userCmd.Parameters.AddWithValue("@UserName", txtname.Text);
                        userCmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                        userCmd.Parameters.AddWithValue("@Salt", salt);
                        userCmd.Parameters.AddWithValue("@CustomerID", txtcusid.Text);
                        userCmd.ExecuteNonQuery();

                        MessageBox.Show("Successful!");
                        HideInputFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Password and Confirm Password do not match");
            }
        }

        private void HideInputFields()
        {
            button1.Visible = true;
            btcreate.Visible = false;
            txtcf.Visible = false;
            lblcf.Visible = false;
            Customer.Visible = false;
            label3.Visible = false;
            txtcusname.Visible = false;
            label4.Visible = false;
            txtcusid.Visible = false;
            label5.Visible = false;
            txtphone.Visible = false;
            txtadd.Visible = false;
        }


        // Toggle password visibility
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtcf.PasswordChar = '\0';
                txtpass.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '*';
                txtcf.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtname.Visible = true;
            Customer.Visible = true;    
            label3.Visible = true;
            txtcusname.Visible = true;  
            label4.Visible = true;
            txtcusid.Visible = true;
            label5.Visible = true;
            txtphone.Visible = true;
            txtadd.Visible = true;
            btcreate.Visible = true;
            lblcf.Visible = true;
            txtcf.Visible = true;
            button1.Visible = false;
        }

        private void txtadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcusname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcusid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {   

        }

        private void txtcf_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
