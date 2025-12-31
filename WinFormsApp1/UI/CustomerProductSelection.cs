using DocumentFormat.OpenXml.Office.Word;
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
    public partial class CustomerProductSelection : Form
    {

        Helper dbHelper = new Helper();
        public CustomerProductSelection()
        {
            InitializeComponent();
            StyleTable();
            LoadProducts();
            LoadCustomerJobs();
            //LoadJobLoads();
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

        private void StyleTable()
        {
            //Applying custom default styles to data table
            TableStyler.ApplyStyle(dgvLoads);
        }

        private void LoadProducts()
        {
            using SqlConnection conn = new SqlConnection(Helper.connStr);
            using SqlDataAdapter adapter = new SqlDataAdapter("GetAllProducts", conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductID";
            cmbProduct.DataSource = dt;
        }

        private void LoadCustomerJobs()
        {
            using SqlConnection conn = new SqlConnection(Helper.connStr);
            using SqlDataAdapter adapter = new SqlDataAdapter("GetJobsByCustomer", conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@CustomerID", Properties.Settings.Default.CustomerID);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cmbJob.DisplayMember = "JobID";
            cmbJob.ValueMember = "JobID";
            cmbJob.DataSource = dt;
        }

        private void LoadJobLoads(int jobId)
        {
            DataTable dt = new JobLoadRepository().GetLoadDetailsByJobID(jobId);
            dgvLoads.DataSource = dt;
        }

        private void btnAddLoad_Click(object sender, EventArgs e)
        {
            if (cmbJob.SelectedValue == null || cmbProduct.SelectedValue == null)
            {
                MessageBox.Show("Select job and product.");
                return;
            }

            int jobId = Convert.ToInt32(cmbJob.SelectedValue);
            int productId = Convert.ToInt32(cmbProduct.SelectedValue);
            decimal weight = nudWeight.Value;
            decimal volume = nudVolume.Value;

            using SqlConnection conn = new SqlConnection(Helper.connStr);
            using SqlCommand cmd = new SqlCommand("AddLoadToJob", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@JobID", jobId);
            cmd.Parameters.AddWithValue("@ProductID", productId);
            cmd.Parameters.AddWithValue("@Weight", weight);
            cmd.Parameters.AddWithValue("@Volume", volume);

            conn.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Product load added to job.");
            LoadJobLoads(Convert.ToInt32(cmbJob.SelectedValue));
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

        private void btnTransportJobRequest_Click(object sender, EventArgs e)
        {
            new CustomerTransportJob().Show();
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

        private void cmbJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadJobLoads(Convert.ToInt32(cmbJob.SelectedValue));
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

        private void dgvLoads_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection(Helper.connStr);
            using SqlCommand cmd = new SqlCommand("SearchLoadsByJobIDAndWeight", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@JobID", Convert.ToInt32(cmbJob.SelectedValue));
            cmd.Parameters.AddWithValue("@MinWeight", nudMinWeight.Value);

            if (nudMaxWeight.Value != 0)
                cmd.Parameters.AddWithValue("@MaxWeight", nudMaxWeight.Value);
            else
                cmd.Parameters.AddWithValue("@MaxWeight", DBNull.Value);

            using SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvLoads.DataSource = dt;
        }
    }
}
