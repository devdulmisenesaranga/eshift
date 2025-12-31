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
using WinFormsApp1.Data.Repositories;
using WinFormsApp1.Helpers;
using WinFormsApp1.Utils;

namespace WinFormsApp1.UI
{
    public partial class CustomerJobStatus : Form
    {
        public CustomerJobStatus()
        {
            InitializeComponent();
            SetJobStatusCMB();
            LoadTransportJobs(); // Initial load
            StyleTable();
            NotificationCount();
        }

        private void SetJobStatusCMB()
        {
            cmbJobStatus.Items.Clear();
            cmbJobStatus.Items.Add("All"); // Optional default
            cmbJobStatus.Items.Add("Pending");
            cmbJobStatus.Items.Add("Accepted");
            cmbJobStatus.Items.Add("Completed");
            cmbJobStatus.Items.Add("Declined");
            cmbJobStatus.SelectedIndex = 0; // Default: All
        }

        private void NotificationCount()
        {
            int unseenCount = new NotificationRepository().GetNotificationCountByUserID(Properties.Settings.Default.UserID);

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

        private void StyleTable()
        {
            //Applying custom default styles to data table
            TableStyler.ApplyStyle(dgvMyJobs);
        }

        private void LoadTransportJobs(string statusFilter = "All")
        {
            DataTable dt = new TransportJobRepository().GetTransportJobStatusByCustomerID(Properties.Settings.Default.CustomerID, statusFilter);
            dgvMyJobs.DataSource = dt;
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

        //color code for dgvMyJobs
        private void dgvMyJobs_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvMyJobs.Rows[e.RowIndex];
            var statusCell = row.Cells["JobStatus"]; // Replace with actual column name if different

            if (statusCell?.Value != null)
            {
                string status = statusCell.Value.ToString();

                switch (status)
                {
                    case "Pending":
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow;
                        row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightYellow;
                        row.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
                        break;
                    case "Accepted":
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                        row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGreen;
                        row.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
                        break;
                    case "Declined":
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                        row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightCoral;
                        row.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
                        break;
                    case "Completed":
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                        row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
                        row.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
                        break;

                }
            }
        }

        private void btnFilterStatus_Click(object sender, EventArgs e)
        {
            string selectedStatus = cmbJobStatus.SelectedItem.ToString();
            LoadTransportJobs(selectedStatus);
        }

        private void btnMyprofile_Click(object sender, EventArgs e)
        {
            new DashboardCustomer().Show();
            this.Hide();
        }

        private void btnTransportJob_Click(object sender, EventArgs e)
        {
            new CustomerViewTransportJob().Show();
            this.Hide();
        }

        private void btnTransportJobRequest_Click(object sender, EventArgs e)
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

        private void btnViewTransportJob_Click(object sender, EventArgs e)
        {
            new CustomerViewTransportJob().Show();
            this.Hide();
        }

        private void dgvMyJobs_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvMyJobs.ClearSelection();
        }

        private void btnNotification_Click_1(object sender, EventArgs e)
        {
            Notifications frm = new Notifications();
            //Catching the onclose event
            frm.OnClose += () =>
            {
                lblNotificationsCount.Visible = false;
            };
            frm.ShowDialog();
        }

        private void lblNotificationsCount_Click(object sender, EventArgs e)
        {

        }
    }
}
