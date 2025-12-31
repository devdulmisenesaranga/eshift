using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Microsoft.VisualBasic.ApplicationServices;
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
using WinFormsApp1.Data.Models;
using WinFormsApp1.Data.Repositories;
using WinFormsApp1.Helpers;
using WinFormsApp1.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1.UI
{
    public partial class ManageAdmins : Form
    {
        public ManageAdmins()
        {
            InitializeComponent();
            StyleTable();
            LoadAdmins();
        }

        private void StyleTable()
        {
            //Custom default styles for table
            TableStyler.ApplyStyle(dgvAdmins, true);
        }

        private void Clear()
        {
            txtAdminUsername.Clear();
            txtAdminPassword.Clear();
        }

        private void LoadAdmins()
        {
            Clear();
            DataTable dt = new UserRepository().GetAdmins();
            dgvAdmins.DataSource = dt;
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            string username = txtAdminUsername.Text.Trim();
            string password = txtAdminPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password required.");
                return;
            }

            string passwordHash = HashPassword(password);

            UserModel user = new UserModel
            {
                Username = username,
                PasswordHash = passwordHash
            };

            bool success = new UserRepository().CreateAdmin(user);
            if (success) MessageBoxHelper.ShowInfo("Admin added.");
            LoadAdmins();
        }

        private string HashPassword(string password)
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

        private void dgvAdmins_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAdmins.Rows[e.RowIndex];
                txtAdminUsername.Text = row.Cells["Username"].Value?.ToString();
                chkIsActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);
                txtAdminPassword.Clear();
            }
        }

        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            if (dgvAdmins.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an admin to update.");
                return;
            }

            int userId = Convert.ToInt32(dgvAdmins.SelectedRows[0].Cells["UserID"].Value);
            bool isActive = chkIsActive.Checked;
            string newPassword = txtAdminPassword.Text;

            UserModel user = new UserModel
            {
                UserID = userId,
                IsActive = isActive,
                PasswordHash = HashPassword(newPassword)
            };

            bool success = new UserRepository().UpdateAdmin(user, string.IsNullOrEmpty(newPassword));
            if (success) MessageBoxHelper.ShowInfo("Admin updated.");
            LoadAdmins();
        }

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            if (dgvAdmins.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an admin to delete.");
                return;
            }

            int userId = Convert.ToInt32(dgvAdmins.SelectedRows[0].Cells["UserID"].Value);
            string username = dgvAdmins.SelectedRows[0].Cells["Username"].Value.ToString();

            // OPTIONAL: Prevent deleting currently logged-in admin
            if (userId == Properties.Settings.Default.UserID)
            {
                MessageBox.Show("You cannot delete the currently logged-in admin.");
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete admin '{username}'?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool success = new UserRepository().DeleteAdmin(userId);
                if (success) MessageBoxHelper.ShowInfo("Admin Deleted.");
                LoadAdmins(); // Reload admin list
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Confirm logout (optional)
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

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            new DashboardAdmin().Show();
            this.Hide();
        }

        private void btnManageTransportJobs_Click(object sender, EventArgs e)
        {
            new TransportUnitsManagement().Show();
            this.Hide();
        }

        private void btnAssignTransportUnits_Click(object sender, EventArgs e)
        {
            new AssignTransportUnits().Show();
            this.Hide();
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            new ProductsManagement().Show();
            this.Hide();
        }

        private void btnTransportUnitsManagement_Click(object sender, EventArgs e)
        {
            new TransportUnitsManagement().Show();
            this.Hide();
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            new AdminGenerateReports().Show();
            this.Hide();
        }

        private void btnManageAdmins_Click(object sender, EventArgs e)
        {
            new ManageAdmins().Show();
            this.Hide();
        }

        private void dgvAdmins_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvAdmins.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            using SqlConnection conn = new SqlConnection(Helper.connStr);
            using SqlCommand cmd = new SqlCommand("SearchAdmins", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SearchText", searchText);

            using SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvAdmins.DataSource = dt;
        }
    }

}
