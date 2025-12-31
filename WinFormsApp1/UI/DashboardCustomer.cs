using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Helpers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1.UI
{
    public partial class DashboardCustomer : Form
    {

        public DashboardCustomer()
        {
            InitializeComponent();
            btnMyprofile.Focus();
            LoadCustomerProfile();
            NotificationCount();
        }

        private void NotificationCount()
        {
            string query = "SELECT COUNT(*) FROM Notifications WHERE UserID = @UserID AND Seen = 0";

            using SqlConnection conn = new SqlConnection(Helper.connStr);
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", Properties.Settings.Default.UserID);

            conn.Open();
            int unseenCount = (int)cmd.ExecuteScalar();
            conn.Close();

            if (unseenCount > 0)
            {
                lblNotificationsCount.Visible = true;
                lblNotificationsCount.Text = unseenCount.ToString();
            }
            else
            {
                lblNotificationsCount.Visible = false;
            }
        }

        private void DashboardCustomer_Load(object sender, EventArgs e)
        {

        }

        private void LoadCustomerProfile()
        {
            string query = "SELECT FullName, Email, Phone, Address FROM Customers WHERE UserID = @UserID";
            using SqlConnection conn = new SqlConnection(Helper.connStr);
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", Properties.Settings.Default.UserID);

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtName.Text = reader["FullName"].ToString();
                txtEmail.Text = reader["Email"].ToString();
                txtPhone.Text = reader["Phone"].ToString();
                rtbAddress.Text = reader["Address"].ToString();
            }
        }

        private void LoadCustomerData()
        {
            // Logic to show customer jobs, job creation, etc.
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"UPDATE Customers SET Email = @Email, Phone = @Phone, Address = @Address 
                     WHERE UserID = @UserID";

                using SqlConnection conn = new SqlConnection(Helper.connStr);
                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Address", rtbAddress.Text);
                cmd.Parameters.AddWithValue("@UserID", Properties.Settings.Default.UserID); // from session

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Profile updated successfully!");

                //Checks for valid email and phone 
                if (!Regex.IsMatch("hemail@hhs.co", @"^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$"))
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }
                if (!Regex.IsMatch("07272728", @"^07[0-9]{8}$"))
                {
                    MessageBox.Show("Please enter a valid phone number (e.g., 0712345678).");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Confirm logout 
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide(); // Hide current dashboard

                // Show login form again
                Login loginForm = new Login();
                loginForm.Show();

                // Optionally close this form after showing login
                this.Close();
            }
        }

        private void btnMyprofile_Click(object sender, EventArgs e)
        {
            new DashboardCustomer().Show();
            this.Hide();
        }

        private void btnViewTransportJob_Click(object sender, EventArgs e)
        {
            new CustomerViewTransportJob().Show();
            this.Hide();
        }

        private void btnTransportJob_Click(object sender, EventArgs e)
        {
            new CustomerTransportJob().Show();
            this.Hide();
        }

        private void btnProductSelection_Click(object sender, EventArgs e)
        {
            new CustomerProductSelection().Show();
            this.Hide();
        }

        private void btnLoadDetails_Click(object sender, EventArgs e)
        {
            new CustomerLoad().Show();
            this.Hide();
        }

        private void btnJobStatus_Click(object sender, EventArgs e)
        {
            new CustomerJobStatus().Show();
            this.Hide();
        }

        private void Address_Click(object sender, EventArgs e)
        {

        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            Notifications frm = new Notifications();
            //Catching the onclose event
            frm.OnClose += () =>
            {
                lblNotificationsCount.Visible = false;
            };
            frm.ShowDialog();
        }
    }
}

