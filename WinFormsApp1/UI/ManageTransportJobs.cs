using DocumentFormat.OpenXml.ExtendedProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using WinFormsApp1.Data.Repositories;
using WinFormsApp1.Helpers;
using WinFormsApp1.Utils;

namespace WinFormsApp1.UI
{
    public partial class ManageTransportJobs : Form
    {
        public ManageTransportJobs()
        {
            InitializeComponent();
            StyleTable();
            LoadPendingJobs();
        }

        private void StyleTable()
        {
            TableStyler.ApplyStyle(dgvPendingJobs);
        }

        private void LoadPendingJobs()
        {
            DataTable dt = new TransportJobRepository().GetPendingJobs();
            dgvPendingJobs.DataSource = dt;
        }

        private void ManageTransportJobs_Load(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (dgvPendingJobs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a job to accept.");
                return;
            }

            int jobId = Convert.ToInt32(dgvPendingJobs.SelectedRows[0].Cells["JobID"].Value);
            int userID = Convert.ToInt32(dgvPendingJobs.SelectedRows[0].Cells["UserID"].Value);
            int updatedBy = Properties.Settings.Default.UserID; // Replace with actual logged-in user
            string notes = "Job accepted by user.";

            using SqlConnection conn = new SqlConnection(Helper.connStr);
            conn.Open();

            //Start transaction for handle multiple processes
            SqlTransaction transaction = conn.BeginTransaction();

            try
            {
                //Update Transportjobs status
                string updateQuery = "UPDATE TransportJobs SET JobStatus = 'Accepted' WHERE JobID = @JobID";
                using SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction);
                updateCmd.Parameters.AddWithValue("@JobID", jobId);
                updateCmd.ExecuteNonQuery();

                string logQuery = @"
                    INSERT INTO JobStatusLog (JobID, Status, UpdatedBy, Timestamp, Notes)
                    VALUES (@JobID, @Status, @UpdatedBy, @Timestamp, @Notes)";
                using SqlCommand logCmd = new SqlCommand(logQuery, conn, transaction);
                logCmd.Parameters.AddWithValue("@JobID", jobId);
                logCmd.Parameters.AddWithValue("@Status", "Accepted");
                logCmd.Parameters.AddWithValue("@UpdatedBy", updatedBy);
                logCmd.Parameters.AddWithValue("@Timestamp", DateTime.Now);
                logCmd.Parameters.AddWithValue("@Notes", notes);
                logCmd.ExecuteNonQuery();

                //Insert new notification row when accepting a request
                string NotificationMessage = $"Your job has been accepted - Job ID ({jobId})";
                string notificationQuery = @"
                    INSERT INTO Notifications (Message, UserID, Seen, Date)
                    VALUES 
                    (@Message, @UserID, 0, @Timestamp)";
                using SqlCommand notificationCmd = new SqlCommand(notificationQuery, conn, transaction);
                notificationCmd.Parameters.AddWithValue("@UserID", userID);
                notificationCmd.Parameters.AddWithValue("@Timestamp", DateTime.Now);
                notificationCmd.Parameters.AddWithValue("@Message", NotificationMessage);
                notificationCmd.ExecuteNonQuery();

                transaction.Commit();

                MessageBox.Show("Job accepted.");
                LoadPendingJobs(); // Refresh list
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message, "Error Accepting Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (dgvPendingJobs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a job to accept.");
                return;
            }

            int jobId = Convert.ToInt32(dgvPendingJobs.SelectedRows[0].Cells["JobID"].Value);
            int userID = Convert.ToInt32(dgvPendingJobs.SelectedRows[0].Cells["UserID"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to decline this job?", "Confirm", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;

            int updatedBy = Properties.Settings.Default.UserID; // Replace with actual logged-in user
            string notes = "Job declined by user.";

            using SqlConnection conn = new SqlConnection(Helper.connStr);
            conn.Open();

            //Start transaction for handle multiple processes
            SqlTransaction transaction = conn.BeginTransaction();

            try
            {
                //Update Transportjobs status
                string updateQuery = "UPDATE TransportJobs SET JobStatus = 'Declined' WHERE JobID = @JobID";
                using SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction);
                updateCmd.Parameters.AddWithValue("@JobID", jobId);
                updateCmd.ExecuteNonQuery();

                string logQuery = @"
                    INSERT INTO JobStatusLog (JobID, Status, UpdatedBy, Timestamp, Notes)
                    VALUES (@JobID, @Status, @UpdatedBy, @Timestamp, @Notes)";
                using SqlCommand logCmd = new SqlCommand(logQuery, conn, transaction);
                logCmd.Parameters.AddWithValue("@JobID", jobId);
                logCmd.Parameters.AddWithValue("@Status", "Declined");
                logCmd.Parameters.AddWithValue("@UpdatedBy", updatedBy);
                logCmd.Parameters.AddWithValue("@Timestamp", DateTime.Now);
                logCmd.Parameters.AddWithValue("@Notes", notes);
                logCmd.ExecuteNonQuery();

                //Insert new notification row when decline a request
                string NotificationMessage = $"Your job has been declined - Job ID ({jobId})";
                string notificationQuery = @"
                    INSERT INTO Notifications (Message, UserID, Seen, Date)
                    VALUES 
                    (@Message, @UserID, 0, @Timestamp)";
                using SqlCommand notificationCmd = new SqlCommand(notificationQuery, conn, transaction);
                notificationCmd.Parameters.AddWithValue("@UserID", userID);
                notificationCmd.Parameters.AddWithValue("@Timestamp", DateTime.Now);
                notificationCmd.Parameters.AddWithValue("@Message", NotificationMessage);
                notificationCmd.ExecuteNonQuery();

                transaction.Commit();

                MessageBox.Show("Job declined.");
                LoadPendingJobs(); // Refresh list
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message, "Error Declining Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //color code for Pending job 
        private void dgvPendingJobs_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var status = dgvPendingJobs.Rows[e.RowIndex].Cells["JobStatus"].Value?.ToString();
            if (status == "Pending")
                dgvPendingJobs.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
            dgvPendingJobs.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            dgvPendingJobs.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White;
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

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            new DashboardAdmin().Show();
            this.Hide();
        }

        private void btnManageTransportJobs_Click(object sender, EventArgs e)
        {
            new ManageTransportJobs().Show();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //LoadTransportJobs();
        }

        private void dgvPendingJobs_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPendingJobs.ClearSelection();
        }
    }
}
