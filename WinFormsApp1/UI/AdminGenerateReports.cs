using iTextSharp.text;
using iTextSharp.text.pdf;
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
    public partial class AdminGenerateReports : Form
    {
        public AdminGenerateReports()
        {
            InitializeComponent();
            StyleTable();
            LoadJobLogs();
        }

        private void StyleTable()
        {
            //Applying custom default styles to data table
            TableStyler.ApplyStyle(dgvLogs);
        }

        private void LoadJobLogs()
        {
            DataTable dt = new JobStatusLogRepository().GetJobStatusLogDetails();
            dgvLogs.DataSource = dt;
        }

        private void btnLoadLogs_Click(object sender, EventArgs e)
        {
            LoadJobLogs();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dgvLogs.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            //Export data as Excel
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Excel Workbook|*.xlsx",
                FileName = "JobStatusReport.xlsx"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var wb = new ClosedXML.Excel.XLWorkbook())
                    {
                        DataTable dt = (DataTable)dgvLogs.DataSource;
                        wb.Worksheets.Add(dt, "JobLogs");
                        wb.SaveAs(sfd.FileName);
                    }
                    MessageBox.Show("Excel report exported successfully.");
                }
            }
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            if (dgvLogs.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            //Export data as PDF
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF File|*.pdf",
                FileName = "JobStatusReport.pdf"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Document doc = new Document(PageSize.A4, 10, 10, 10, 10);
                PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                doc.Open();

                PdfPTable table = new PdfPTable(dgvLogs.Columns.Count);

                foreach (DataGridViewColumn col in dgvLogs.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(col.HeaderText));
                    headerCell.BackgroundColor = new BaseColor(204, 229, 255);
                    table.AddCell(headerCell);
                }

                foreach (DataGridViewRow row in dgvLogs.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(cell.Value?.ToString());
                    }
                }

                doc.Add(table);
                doc.Close();
                MessageBox.Show("PDF report generated.");
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
