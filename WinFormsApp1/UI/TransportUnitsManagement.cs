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
    public partial class TransportUnitsManagement : Form
    {
        public TransportUnitsManagement()
        {
            InitializeComponent();
            StyleTable();
            LoadTransportUnits();
        }

        int selectedTransportUnitID = -1;

        private void StyleTable()
        {
            //Set custom default style to table
            TableStyler.ApplyStyle(dgvTransportUnits, true);
        }

        private void LoadTransportUnits()
        {
            DataTable dt = new TransportUnitRepository().GetAllTransportUnits();
            dgvTransportUnits.DataSource = dt;
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            string lorry = txtLorryPlate.Text.Trim();
            string driver = txtDriverName.Text.Trim();
            string assistant = txtAssistantName.Text.Trim();
            string container = cmbContainerType.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(lorry) || string.IsNullOrEmpty(driver))
            {
                MessageBox.Show("Lorry plate and driver name are required.");
                return;
            }

            string query = @"INSERT INTO TransportUnits (LorryPlate, DriverName, AssistantName, ContainerType)
                     VALUES (@Lorry, @Driver, @Assistant, @Container)";
            using SqlConnection conn = new SqlConnection(Helper.connStr);
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Lorry", lorry);
            cmd.Parameters.AddWithValue("@Driver", driver);
            cmd.Parameters.AddWithValue("@Assistant", assistant);
            cmd.Parameters.AddWithValue("@Container", container);
            conn.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Transport unit added.");
            LoadTransportUnits();
        }

        private void dgvTransportUnits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTransportUnits.Rows[e.RowIndex];
                txtLorryPlate.Text = row.Cells["LorryPlate"].Value?.ToString();
                txtDriverName.Text = row.Cells["DriverName"].Value?.ToString();
                txtAssistantName.Text = row.Cells["AssistantName"].Value?.ToString();
                cmbContainerType.SelectedItem = row.Cells["ContainerType"].Value?.ToString();
                selectedTransportUnitID = (int)row.Cells["TransportUnitID"].Value;
            }
        }

        private void btnUpdateUnit_Click(object sender, EventArgs e)
        {
            if (selectedTransportUnitID == -1)
            {
                MessageBox.Show("Please select a unit to update.");
                return;
            }

            string lorry = txtLorryPlate.Text.Trim();
            string driver = txtDriverName.Text.Trim();
            string assistant = txtAssistantName.Text.Trim();
            string container = cmbContainerType.SelectedItem?.ToString();

            string query = @"UPDATE TransportUnits 
                     SET LorryPlate = @Lorry, DriverName = @Driver, AssistantName = @Assistant, ContainerType = @Container
                     WHERE TransportUnitID = @UnitID";

            using SqlConnection conn = new SqlConnection(Helper.connStr);
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Lorry", lorry);
            cmd.Parameters.AddWithValue("@Driver", driver);
            cmd.Parameters.AddWithValue("@Assistant", assistant);
            cmd.Parameters.AddWithValue("@Container", container);
            cmd.Parameters.AddWithValue("@UnitID", selectedTransportUnitID);
            conn.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Transport unit updated.");
            LoadTransportUnits();
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
    }
}

