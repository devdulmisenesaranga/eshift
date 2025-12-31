namespace WinFormsApp1.UI
{
    partial class DashboardAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdmin));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            btnManageAdmins = new Button();
            btnTransportUnitsManagement = new Button();
            btnLogout = new Button();
            btnGenerateReports = new Button();
            btnProductManagement = new Button();
            btnAssignTransportUnits = new Button();
            btnManageTransportJobs = new Button();
            btnCustomerDetails = new Button();
            panel4 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            rtbAddress = new RichTextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            Email = new Label();
            FullName = new Label();
            dgvCustomers = new DataGridView();
            panel10 = new Panel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label1);
            panel1.Location = new Point(278, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1004, 132);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(369, 15);
            label1.Name = "label1";
            label1.Size = new Size(255, 38);
            label1.TabIndex = 2;
            label1.Text = "Admin Dashboard";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkBlue;
            panel3.Controls.Add(btnManageAdmins);
            panel3.Controls.Add(btnTransportUnitsManagement);
            panel3.Controls.Add(btnLogout);
            panel3.Controls.Add(btnGenerateReports);
            panel3.Controls.Add(btnProductManagement);
            panel3.Controls.Add(btnAssignTransportUnits);
            panel3.Controls.Add(btnManageTransportJobs);
            panel3.Controls.Add(btnCustomerDetails);
            panel3.Location = new Point(0, 72);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 597);
            panel3.TabIndex = 1;
            // 
            // btnManageAdmins
            // 
            btnManageAdmins.FlatStyle = FlatStyle.Popup;
            btnManageAdmins.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnManageAdmins.ForeColor = Color.White;
            btnManageAdmins.Location = new Point(3, 346);
            btnManageAdmins.Name = "btnManageAdmins";
            btnManageAdmins.Size = new Size(273, 59);
            btnManageAdmins.TabIndex = 13;
            btnManageAdmins.Text = "MANAGE ADMINS";
            btnManageAdmins.UseVisualStyleBackColor = true;
            btnManageAdmins.Click += btnManageAdmins_Click;
            // 
            // btnTransportUnitsManagement
            // 
            btnTransportUnitsManagement.FlatStyle = FlatStyle.Popup;
            btnTransportUnitsManagement.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTransportUnitsManagement.ForeColor = Color.White;
            btnTransportUnitsManagement.Location = new Point(3, 230);
            btnTransportUnitsManagement.Name = "btnTransportUnitsManagement";
            btnTransportUnitsManagement.Size = new Size(273, 59);
            btnTransportUnitsManagement.TabIndex = 12;
            btnTransportUnitsManagement.Text = "TRANSPORTUNITS MANAGEMENT";
            btnTransportUnitsManagement.UseVisualStyleBackColor = true;
            btnTransportUnitsManagement.Click += btnTransportUnitsManagement_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.Cyan;
            btnLogout.Location = new Point(5, 523);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(273, 66);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnGenerateReports
            // 
            btnGenerateReports.FlatStyle = FlatStyle.Popup;
            btnGenerateReports.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGenerateReports.ForeColor = Color.White;
            btnGenerateReports.Location = new Point(2, 288);
            btnGenerateReports.Name = "btnGenerateReports";
            btnGenerateReports.Size = new Size(273, 59);
            btnGenerateReports.TabIndex = 8;
            btnGenerateReports.Text = "GENERATE REPORTS";
            btnGenerateReports.UseVisualStyleBackColor = true;
            btnGenerateReports.Click += btnGenerateReports_Click;
            // 
            // btnProductManagement
            // 
            btnProductManagement.FlatStyle = FlatStyle.Popup;
            btnProductManagement.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnProductManagement.ForeColor = Color.White;
            btnProductManagement.Location = new Point(3, 172);
            btnProductManagement.Name = "btnProductManagement";
            btnProductManagement.Size = new Size(273, 59);
            btnProductManagement.TabIndex = 7;
            btnProductManagement.Text = "PRODUCTS MANAGEMENT";
            btnProductManagement.UseVisualStyleBackColor = true;
            btnProductManagement.Click += btnProductManagement_Click;
            // 
            // btnAssignTransportUnits
            // 
            btnAssignTransportUnits.FlatStyle = FlatStyle.Popup;
            btnAssignTransportUnits.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAssignTransportUnits.ForeColor = Color.White;
            btnAssignTransportUnits.Location = new Point(3, 117);
            btnAssignTransportUnits.Name = "btnAssignTransportUnits";
            btnAssignTransportUnits.Size = new Size(273, 59);
            btnAssignTransportUnits.TabIndex = 6;
            btnAssignTransportUnits.Text = "ASSIGN TRANSPORT UNITS";
            btnAssignTransportUnits.UseVisualStyleBackColor = true;
            btnAssignTransportUnits.Click += btnAssignTransportUnits_Click;
            // 
            // btnManageTransportJobs
            // 
            btnManageTransportJobs.FlatStyle = FlatStyle.Popup;
            btnManageTransportJobs.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnManageTransportJobs.ForeColor = Color.White;
            btnManageTransportJobs.Location = new Point(2, 59);
            btnManageTransportJobs.Name = "btnManageTransportJobs";
            btnManageTransportJobs.Size = new Size(273, 59);
            btnManageTransportJobs.TabIndex = 5;
            btnManageTransportJobs.Text = "MANAGE TRANSPORT JOBS";
            btnManageTransportJobs.UseVisualStyleBackColor = true;
            btnManageTransportJobs.Click += btnManageTransportJobs_Click;
            // 
            // btnCustomerDetails
            // 
            btnCustomerDetails.FlatStyle = FlatStyle.Popup;
            btnCustomerDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCustomerDetails.ForeColor = Color.Fuchsia;
            btnCustomerDetails.Location = new Point(3, 1);
            btnCustomerDetails.Name = "btnCustomerDetails";
            btnCustomerDetails.Size = new Size(272, 59);
            btnCustomerDetails.TabIndex = 4;
            btnCustomerDetails.Text = "CUSTOMER DETAILS";
            btnCustomerDetails.UseVisualStyleBackColor = true;
            btnCustomerDetails.Click += btnCustomerDetails_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(278, 72);
            panel4.Name = "panel4";
            panel4.Size = new Size(1007, 60);
            panel4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(729, 16);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 1;
            label3.Text = "Home / Dashboard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(58, 16);
            label2.Name = "label2";
            label2.Size = new Size(173, 23);
            label2.TabIndex = 0;
            label2.Text = "CUSTOMER DETAILS";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(278, 72);
            panel5.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(122, 23);
            label4.Name = "label4";
            label4.Size = new Size(75, 28);
            label4.TabIndex = 4;
            label4.Text = "e-Shift";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(60, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 53);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(rtbAddress);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtFullName);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(Email);
            panel2.Controls.Add(FullName);
            panel2.Controls.Add(dgvCustomers);
            panel2.Location = new Point(278, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(1007, 541);
            panel2.TabIndex = 8;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkBlue;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(861, 118);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 31);
            btnUpdate.TabIndex = 66;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkBlue;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(861, 72);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 31);
            btnDelete.TabIndex = 65;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkBlue;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(861, 25);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(98, 31);
            btnEdit.TabIndex = 64;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkBlue;
            panel6.Location = new Point(554, 144);
            panel6.Name = "panel6";
            panel6.Size = new Size(252, 4);
            panel6.TabIndex = 63;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkBlue;
            panel7.Location = new Point(554, 56);
            panel7.Name = "panel7";
            panel7.Size = new Size(248, 4);
            panel7.TabIndex = 62;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkBlue;
            panel8.Location = new Point(146, 116);
            panel8.Name = "panel8";
            panel8.Size = new Size(249, 4);
            panel8.TabIndex = 61;
            // 
            // panel9
            // 
            panel9.BackColor = Color.DarkBlue;
            panel9.Location = new Point(146, 63);
            panel9.Name = "panel9";
            panel9.Size = new Size(248, 4);
            panel9.TabIndex = 60;
            // 
            // rtbAddress
            // 
            rtbAddress.BorderStyle = BorderStyle.FixedSingle;
            rtbAddress.Location = new Point(554, 85);
            rtbAddress.Name = "rtbAddress";
            rtbAddress.Size = new Size(252, 63);
            rtbAddress.TabIndex = 59;
            rtbAddress.Text = "";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Location = new Point(554, 29);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(248, 27);
            txtPhone.TabIndex = 58;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(146, 89);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 27);
            txtEmail.TabIndex = 57;
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Location = new Point(146, 37);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(248, 27);
            txtFullName.TabIndex = 56;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(445, 85);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 55;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(444, 31);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 54;
            label6.Text = "Phone";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            Email.ForeColor = Color.DarkBlue;
            Email.Location = new Point(36, 88);
            Email.Name = "Email";
            Email.Size = new Size(58, 25);
            Email.TabIndex = 53;
            Email.Text = "Email";
            // 
            // FullName
            // 
            FullName.AutoSize = true;
            FullName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            FullName.ForeColor = Color.DarkBlue;
            FullName.Location = new Point(36, 35);
            FullName.Name = "FullName";
            FullName.Size = new Size(97, 25);
            FullName.TabIndex = 52;
            FullName.Text = "Full Name";
            // 
            // dgvCustomers
            // 
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(17, 229);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.Size = new Size(965, 283);
            dgvCustomers.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.BackColor = Color.DarkBlue;
            panel10.Location = new Point(17, 215);
            panel10.Name = "panel10";
            panel10.Size = new Size(818, 4);
            panel10.TabIndex = 63;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(17, 188);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(817, 27);
            txtSearch.TabIndex = 62;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkBlue;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(842, 188);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(140, 31);
            btnSearch.TabIndex = 67;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 662);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "DashboardAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardAdmin";
            Load += DashboardAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Button btnCustomerDetails;
        private Button btnManageTransportJobs;
        private Button btnAssignTransportUnits;
        private Label label2;
        private Button btnGenerateReports;
        private Button btnProductManagement;
        private Label label3;
        private Panel panel5;
        private Label label4;
        private PictureBox pictureBox3;
        private Button btnLogout;
        private Button btnTransportUnitsManagement;
        private Button btnManageAdmins;
        private Panel panel2;
        private DataGridView dgvCustomers;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private RichTextBox rtbAddress;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtFullName;
        private Label label5;
        private Label label6;
        private Label Email;
        private Label FullName;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSearch;
        private Panel panel10;
        private TextBox txtSearch;
    }
}