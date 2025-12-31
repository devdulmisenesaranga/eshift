using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class CustomerViewTransportJob : Form
    {
        public CustomerViewTransportJob()
        {
            InitializeComponent();
            StyleTable();
            LoadCustomerJobs();
            NotificationCount();
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

        private void btnRefreshJobs_Click(object sender, EventArgs e)
        {
            LoadCustomerJobs(); // Assumes you're storing logged-in user info
        }

        private void StyleTable()
        {
            //Applying custom default styles to data table
            TableStyler.ApplyStyle(dgvMyJobs);
        }

        private void LoadCustomerJobs()
        {
            DataTable dt = new TransportJobRepository().GetTransportJobStatusByCustomerID(Properties.Settings.Default.CustomerID, "All");
            dgvMyJobs.DataSource = dt;
        }

        private void dgvMyJobs_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvMyJobs.Rows)
                {
                    string status = row.Cells["JobStatus"].Value.ToString();
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
            catch (Exception ex)
            {

            }

            dgvMyJobs.ClearSelection();
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
