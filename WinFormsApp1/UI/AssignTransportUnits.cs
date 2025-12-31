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
    public partial class AssignTransportUnits : Form
    {
        public AssignTransportUnits()
        {
            InitializeComponent();
            StyleTable();
            LoadJobs();
        }

        private int selectedLoadID = -1;

        private void StyleTable()
        {
            TableStyler.ApplyStyle(dgvLoads, true);
        }

        private void LoadJobs()
        {
            using SqlConnection conn = new SqlConnection(Helper.connStr);
            using SqlCommand cmd = new SqlCommand("GetAcceptedJobIDs", conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmbJobs.Items.Add(reader["JobID"].ToString());
            }
        }

        private void cmbJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int jobId = int.Parse(cmbJobs.SelectedItem.ToString());
            DataTable dt = new JobLoadRepository().GetLoadsByJobID(jobId);
            dgvLoads.DataSource = dt;
        }

        private void AssignTransportUnits_Load(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection(Helper.connStr);
            using SqlCommand cmd = new SqlCommand("GetTransportUnits", conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmbTransportUnit.Items.Add(new ComboBoxItem
                {
                    Text = reader["LorryPlate"].ToString(),
                    Value = reader["TransportUnitID"].ToString()
                });
            }
        }

        // Helper class for combo items
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public override string ToString() => Text;
        }

        private void btnAssignUnit_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedLoadID == -1 || cmbTransportUnit.SelectedItem == null)
                {
                    MessageBox.Show("Please select a load and a transport unit.");
                    return;

                }

                int unitId = Convert.ToInt32(((ComboBoxItem)cmbTransportUnit.SelectedItem).Value);

                using SqlConnection conn = new SqlConnection(Helper.connStr);
                using SqlCommand cmd = new SqlCommand("UpdateLoadTransportUnit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UnitID", unitId);
                cmd.Parameters.AddWithValue("@LoadID", selectedLoadID);
                conn.Open();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Transport unit assigned successfully.");
                cmbJobs_SelectedIndexChanged(null, null);

                selectedLoadID = -1;
                dgvLoads.ClearSelection();
            }catch(Exception ex)
            {
                MessageBox.Show("Assignment failed.");
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

        private void dgvLoads_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLoads.Rows[e.RowIndex];
                selectedLoadID = (int)row.Cells["LoadID"].Value;
            }
        }
    }
}
