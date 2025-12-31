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
    public partial class ProductsManagement : Form
    {
        public ProductsManagement()
        {
            InitializeComponent();
            StyleTable();
            LoadProducts();
        }

        int selectedProductID = -1;

        private void StyleTable()
        {
            //Set custom default style to table
            TableStyler.ApplyStyle(dgvProducts, true);
        }

        private void Clear()
        {
            selectedProductID = -1;
            txtProductName.Clear();
            rtbDescription.Clear();
            chkFragile.Checked = false;
        }

        private void LoadProducts()
        {
            Clear();
            DataTable dt = new ProductRepository().GetAllProducts();
            dgvProducts.DataSource = dt;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string name = txtProductName.Text.Trim();
            string description = rtbDescription.Text.Trim();
            bool fragile = chkFragile.Checked;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Product name is required.");
                return;
            }

            string query = "INSERT INTO Products (ProductName, Description, Fragile) VALUES (@Name, @Desc, @Fragile)";
            using SqlConnection conn = new SqlConnection(Helper.connStr);
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Desc", description);
            cmd.Parameters.AddWithValue("@Fragile", fragile);

            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Product added.");

            LoadProducts(); // Refresh grid
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                rtbDescription.Text = row.Cells["Description"].Value.ToString();
                chkFragile.Checked = Convert.ToBoolean(row.Cells["Fragile"].Value);
                selectedProductID = (int)row.Cells["ProductID"].Value;
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a product to update.");
                return;
            }

            string name = txtProductName.Text.Trim();
            string description = rtbDescription.Text.Trim();
            bool fragile = chkFragile.Checked;

            string query = @"
        UPDATE Products
        SET ProductName = @Name, Description = @Desc, Fragile = @Fragile
        WHERE ProductID = @ProductID";

            using SqlConnection conn = new SqlConnection(Helper.connStr);
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Desc", description);
            cmd.Parameters.AddWithValue("@Fragile", fragile);
            cmd.Parameters.AddWithValue("@ProductID", selectedProductID);

            conn.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Product updated.");
            LoadProducts();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProductID == -1)
                {
                    MessageBox.Show("Select a product to delete.");
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes) return;

                string query = "DELETE FROM Products WHERE ProductID = @ProductID";

                using SqlConnection conn = new SqlConnection(Helper.connStr);
                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductID", selectedProductID);

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product deleted.");
                LoadProducts();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
