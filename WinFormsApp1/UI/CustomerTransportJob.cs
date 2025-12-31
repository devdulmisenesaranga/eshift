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
using WinFormsApp1.Data.Models;
using WinFormsApp1.Data.Repositories;
using WinFormsApp1.Helpers;

namespace WinFormsApp1.UI
{
    public partial class CustomerTransportJob : Form
    {
        public CustomerTransportJob()
        {
            InitializeComponent();
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

        private void CustomerTransportJob_Load(object sender, EventArgs e)
        {
        }


        private void btnCreateJob_Click(object sender, EventArgs e)
        {
            TransportJobModel job = new TransportJobModel
            {
                CustomerID = Properties.Settings.Default.CustomerID,
                StartLocation = txtStart.Text.Trim(),
                Destination = txtDestination.Text.Trim(),
                JobStatus = cmbJobStatus.SelectedItem?.ToString(),
                RequestDate = DateTime.Now,
                ScheduledDate = dtpSchedule.Value
            };
            new TransportJobRepository().CreateJob(job);
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

        private void HomeDashboard_Click(object sender, EventArgs e)
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


