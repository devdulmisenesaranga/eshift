using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Helpers;


namespace WinFormsApp1.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            //cmbRole.Items.Add("Admin");
            //cmbRole.Items.Add("Customer");
            cmbRole.SelectedIndex = 0; // Optional: set default selection
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            // string hashedPassword = GetHashedPassword(password);

            //string query = @"SELECT UserID, PasswordHash FROM Users 
            //         WHERE Username = @Username AND Role = @Role AND IsActive = 1";

            string query = @"
                SELECT U.UserID, U.PasswordHash, C.CustomerID
                FROM Users U
                LEFT JOIN Customers C ON U.UserID = C.UserID
                WHERE U.Username = @Username AND U.Role = @Role AND U.IsActive = 1";

            using SqlConnection conn = new SqlConnection(Helper.connStr);
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Role", role);

            using SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                int userId = Convert.ToInt32(dt.Rows[0]["UserID"]);
                int customerId = dt.Rows[0]["CustomerID"] != DBNull.Value
                ? Convert.ToInt32(dt.Rows[0]["CustomerID"])
                : -1;
                string storedHash = dt.Rows[0]["PasswordHash"].ToString();

                if (VerifyPassword(password, storedHash))
                {
                    MessageBox.Show($"Welcome User {userId}");

                    CurrentUser.UserID = userId;
                    CurrentUser.Role = role;

                    Properties.Settings.Default.UserID = userId;
                    Properties.Settings.Default.CustomerID = customerId;
                    Properties.Settings.Default.Save();

                    if (role == "Admin")
                    {
                        new DashboardAdmin().Show();
                    }
                    else
                    {
                        new DashboardCustomer().Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid password");
                }
            }
            else
            {
                MessageBox.Show("User not found");
            }

        }

        public bool VerifyPassword(string enteredPassword, string storedHash)
        {
            // Extract bytes
            byte[] hashBytes = Convert.FromBase64String(storedHash);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // Compute the hash of the entered password
            var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);

            // Compare results
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                    return false;
            }

            return true;
        }

        private int GetCustomerId(int userId)
        {
            using SqlConnection conn = new SqlConnection(Helper.connStr);
            string query = "SELECT CustomerID FROM Customers WHERE UserID = @UserID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", userId);
            conn.Open();
            object result = cmd.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : 0;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private string GetHashedPassword(string password)
        {
            using var sha = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha.ComputeHash(bytes);
            return BitConverter.ToString(hash).Replace("-", "");
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            new CustomerProfile().Show();
            this.Hide();
        }

        public static class CurrentUser
        {
            public static int UserID { get; set; }
            public static string Role { get; set; }
        }
    }
}
