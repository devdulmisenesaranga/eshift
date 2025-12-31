namespace WinFormsApp1.UI
{
    partial class ManageAdmins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAdmins));
            panel5 = new Panel();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            btnManageAdmins = new Button();
            btnTransportUnitsManagement = new Button();
            btnLogout = new Button();
            btnGenerateReports = new Button();
            btnProductManagement = new Button();
            btnAssignTransportUnits = new Button();
            btnManageTransportJobs = new Button();
            btnCustomerDetails = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnDeleteAdmin = new Button();
            btnUpdateAdmin = new Button();
            btnAddAdmin = new Button();
            chkIsActive = new CheckBox();
            panel7 = new Panel();
            panel8 = new Panel();
            txtAdminPassword = new TextBox();
            txtAdminUsername = new TextBox();
            AdminPassword = new Label();
            Email = new Label();
            ListOfAdminUsers = new Label();
            dgvAdmins = new DataGridView();
            btnSearch = new Button();
            panel10 = new Panel();
            txtSearch = new TextBox();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(1, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(278, 72);
            panel5.TabIndex = 23;
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
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(279, 72);
            panel4.Name = "panel4";
            panel4.Size = new Size(1007, 60);
            panel4.TabIndex = 22;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(828, 17);
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
            label2.Size = new Size(158, 23);
            label2.TabIndex = 0;
            label2.Text = "MANAGE ADMINS";
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
            panel3.Location = new Point(1, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 597);
            panel3.TabIndex = 21;
            // 
            // btnManageAdmins
            // 
            btnManageAdmins.FlatStyle = FlatStyle.Popup;
            btnManageAdmins.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnManageAdmins.ForeColor = Color.Fuchsia;
            btnManageAdmins.Location = new Point(3, 346);
            btnManageAdmins.Name = "btnManageAdmins";
            btnManageAdmins.Size = new Size(273, 59);
            btnManageAdmins.TabIndex = 4;
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
            btnLogout.Location = new Point(5, 531);
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
            btnCustomerDetails.ForeColor = Color.White;
            btnCustomerDetails.Location = new Point(3, 1);
            btnCustomerDetails.Name = "btnCustomerDetails";
            btnCustomerDetails.Size = new Size(272, 59);
            btnCustomerDetails.TabIndex = 13;
            btnCustomerDetails.Text = "CUSTOMER DETAILS";
            btnCustomerDetails.UseVisualStyleBackColor = true;
            btnCustomerDetails.Click += btnCustomerDetails_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label1);
            panel1.Location = new Point(279, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1004, 132);
            panel1.TabIndex = 20;
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(btnDeleteAdmin);
            panel2.Controls.Add(btnUpdateAdmin);
            panel2.Controls.Add(btnAddAdmin);
            panel2.Controls.Add(chkIsActive);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(txtAdminPassword);
            panel2.Controls.Add(txtAdminUsername);
            panel2.Controls.Add(AdminPassword);
            panel2.Controls.Add(Email);
            panel2.Controls.Add(ListOfAdminUsers);
            panel2.Controls.Add(dgvAdmins);
            panel2.Location = new Point(279, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 538);
            panel2.TabIndex = 24;
            // 
            // btnDeleteAdmin
            // 
            btnDeleteAdmin.BackColor = Color.DarkBlue;
            btnDeleteAdmin.FlatStyle = FlatStyle.Popup;
            btnDeleteAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteAdmin.ForeColor = Color.White;
            btnDeleteAdmin.Location = new Point(834, 459);
            btnDeleteAdmin.Name = "btnDeleteAdmin";
            btnDeleteAdmin.Size = new Size(124, 38);
            btnDeleteAdmin.TabIndex = 74;
            btnDeleteAdmin.Text = "DELETE";
            btnDeleteAdmin.UseVisualStyleBackColor = false;
            btnDeleteAdmin.Click += btnDeleteAdmin_Click;
            // 
            // btnUpdateAdmin
            // 
            btnUpdateAdmin.BackColor = Color.DarkBlue;
            btnUpdateAdmin.FlatStyle = FlatStyle.Popup;
            btnUpdateAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateAdmin.ForeColor = Color.White;
            btnUpdateAdmin.Location = new Point(679, 459);
            btnUpdateAdmin.Name = "btnUpdateAdmin";
            btnUpdateAdmin.Size = new Size(127, 38);
            btnUpdateAdmin.TabIndex = 73;
            btnUpdateAdmin.Text = "UPDATE";
            btnUpdateAdmin.UseVisualStyleBackColor = false;
            btnUpdateAdmin.Click += btnUpdateAdmin_Click;
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.BackColor = Color.DarkBlue;
            btnAddAdmin.FlatStyle = FlatStyle.Popup;
            btnAddAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddAdmin.ForeColor = Color.White;
            btnAddAdmin.Location = new Point(523, 459);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Size = new Size(127, 38);
            btnAddAdmin.TabIndex = 72;
            btnAddAdmin.Text = "ADD";
            btnAddAdmin.UseVisualStyleBackColor = false;
            btnAddAdmin.Click += btnAddAdmin_Click;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkIsActive.ForeColor = Color.DarkBlue;
            chkIsActive.Location = new Point(271, 454);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(75, 24);
            chkIsActive.TabIndex = 71;
            chkIsActive.Text = "Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkBlue;
            panel7.Location = new Point(271, 430);
            panel7.Name = "panel7";
            panel7.Size = new Size(184, 4);
            panel7.TabIndex = 60;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkBlue;
            panel8.Location = new Point(271, 374);
            panel8.Name = "panel8";
            panel8.Size = new Size(185, 4);
            panel8.TabIndex = 59;
            // 
            // txtAdminPassword
            // 
            txtAdminPassword.BorderStyle = BorderStyle.FixedSingle;
            txtAdminPassword.Location = new Point(271, 403);
            txtAdminPassword.Name = "txtAdminPassword";
            txtAdminPassword.Size = new Size(184, 27);
            txtAdminPassword.TabIndex = 58;
            // 
            // txtAdminUsername
            // 
            txtAdminUsername.BorderStyle = BorderStyle.FixedSingle;
            txtAdminUsername.Location = new Point(271, 347);
            txtAdminUsername.Name = "txtAdminUsername";
            txtAdminUsername.Size = new Size(184, 27);
            txtAdminUsername.TabIndex = 57;
            // 
            // AdminPassword
            // 
            AdminPassword.AutoSize = true;
            AdminPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            AdminPassword.ForeColor = Color.DarkBlue;
            AdminPassword.Location = new Point(103, 401);
            AdminPassword.Name = "AdminPassword";
            AdminPassword.Size = new Size(153, 25);
            AdminPassword.TabIndex = 56;
            AdminPassword.Text = "Admin Password";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            Email.ForeColor = Color.DarkBlue;
            Email.Location = new Point(103, 347);
            Email.Name = "Email";
            Email.Size = new Size(158, 25);
            Email.TabIndex = 55;
            Email.Text = "Admin Username";
            // 
            // ListOfAdminUsers
            // 
            ListOfAdminUsers.AutoSize = true;
            ListOfAdminUsers.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            ListOfAdminUsers.ForeColor = Color.DarkBlue;
            ListOfAdminUsers.Location = new Point(377, 21);
            ListOfAdminUsers.Name = "ListOfAdminUsers";
            ListOfAdminUsers.Size = new Size(276, 38);
            ListOfAdminUsers.TabIndex = 54;
            ListOfAdminUsers.Text = "List Of Admin Users";
            // 
            // dgvAdmins
            // 
            dgvAdmins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdmins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdmins.Location = new Point(42, 106);
            dgvAdmins.Name = "dgvAdmins";
            dgvAdmins.RowHeadersWidth = 51;
            dgvAdmins.Size = new Size(919, 197);
            dgvAdmins.TabIndex = 53;
            dgvAdmins.CellClick += dgvAdmins_CellClick;
            dgvAdmins.DataBindingComplete += dgvAdmins_DataBindingComplete;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkBlue;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(823, 70);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(138, 31);
            btnSearch.TabIndex = 77;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.DarkBlue;
            panel10.Location = new Point(44, 97);
            panel10.Name = "panel10";
            panel10.Size = new Size(774, 4);
            panel10.TabIndex = 76;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(44, 70);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(773, 27);
            txtSearch.TabIndex = 75;
            // 
            // ManageAdmins
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 668);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "ManageAdmins";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageAdmins";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Label label4;
        private PictureBox pictureBox3;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Button btnManageAdmins;
        private Button btnTransportUnitsManagement;
        private Button btnLogout;
        private Button btnGenerateReports;
        private Button btnProductManagement;
        private Button btnAssignTransportUnits;
        private Button btnManageTransportJobs;
        private Button btnCustomerDetails;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView dgvAdmins;
        private Label ListOfAdminUsers;
        private Panel panel7;
        private Panel panel8;
        private TextBox txtAdminPassword;
        private TextBox txtAdminUsername;
        private Label AdminPassword;
        private Label Email;
        private CheckBox chkIsActive;
        private Button btnDeleteAdmin;
        private Button btnUpdateAdmin;
        private Button btnAddAdmin;
        private Button btnSearch;
        private Panel panel10;
        private TextBox txtSearch;
    }
}