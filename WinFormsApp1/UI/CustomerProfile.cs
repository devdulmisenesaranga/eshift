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
using WinFormsApp1.Helpers;
using static WinFormsApp1.UI.Login;

namespace WinFormsApp1.UI
{
    public partial class CustomerProfile : Form
    {
        public CustomerProfile()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirm = txtConfirmPassword.Text;
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = rtbAddress.Text;

            // Simple validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirm) || string.IsNullOrEmpty(fullName) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            if (!IsEmailValid(email) || !IsPwValid(password) || !IsPhoneValid(phone)) return;

            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string hashedPassword = HashPassword(password);

            using SqlConnection conn = new SqlConnection(Helper.connStr);
            conn.Open();

            SqlTransaction transaction = conn.BeginTransaction();

            try
            {
                // Insert into Users table
                string insertUser = @"INSERT INTO Users (Username, PasswordHash, Role)
                              VALUES (@Username, @PasswordHash, 'Customer');
                              SELECT SCOPE_IDENTITY();";

                SqlCommand cmdUser = new SqlCommand(insertUser, conn, transaction);
                cmdUser.Parameters.AddWithValue("@Username", username);
                cmdUser.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                int userId = Convert.ToInt32(cmdUser.ExecuteScalar());

                // Insert into Customers table
                string insertCustomer = @"INSERT INTO Customers (UserID, FullName, Email, Phone, Address)
                                  VALUES (@UserID, @FullName, @Email, @Phone, @Address)
                                  SELECT SCOPE_IDENTITY();";

                SqlCommand cmdCust = new SqlCommand(insertCustomer, conn, transaction);
                cmdCust.Parameters.AddWithValue("@UserID", userId);
                cmdCust.Parameters.AddWithValue("@FullName", fullName);
                cmdCust.Parameters.AddWithValue("@Email", email);
                cmdCust.Parameters.AddWithValue("@Phone", phone);
                cmdCust.Parameters.AddWithValue("@Address", address);
                int customerId = Convert.ToInt32(cmdCust.ExecuteScalar());

                transaction.Commit();

                Properties.Settings.Default.UserID = userId;
                Properties.Settings.Default.CustomerID = customerId;

                // Save session info
                CurrentUser.UserID = userId;
                CurrentUser.Role = "Customer";

                MessageBox.Show("Registration successful!");
                new DashboardCustomer().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Validations
        //Email validation
        private bool IsEmailValid(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(email, pattern))
            {
                MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        //Password validation
        private bool IsPwValid(string password)
        {
            if (password.Length < 8 || !password.Any(char.IsLetter) || !password.Any(char.IsDigit))
            {
                MessageBox.Show("Password must be at least 6 characters and contain both letters and numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        //Phone number validation
        private bool IsPhoneValid(string phone)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must be exactly 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static string HashPassword(string password)
        {
            // Create salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);

            // Combine salt and hash
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            // Convert to base64
            string savedPasswordHash = Convert.ToBase64String(hashBytes);

            return savedPasswordHash;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool show = chkShowPassword.Checked;
            txtPassword.UseSystemPasswordChar = !show;
            txtConfirmPassword.UseSystemPasswordChar = !show;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide(); 
        }
        private void CustomerProfile_Load(object sender, EventArgs e)
        {

        }
    }
}


