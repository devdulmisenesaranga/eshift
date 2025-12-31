namespace WinFormsApp1.UI
{
    partial class CustomerLoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerLoad));
            panel5 = new Panel();
            Logo = new PictureBox();
            eShift = new Label();
            panel4 = new Panel();
            DashboardIcon = new PictureBox();
            HomeDashboard = new Label();
            Dashboard = new Label();
            panel1 = new Panel();
            CustomerDashboard = new Label();
            panel2 = new Panel();
            LoadDetailsList = new Label();
            dgvLoads = new DataGridView();
            btnViewLoads = new Button();
            cmbJob = new ComboBox();
            panel8 = new Panel();
            SelectJobID = new Label();
            btnTransportJobRequest = new Button();
            btnLoadDetails = new Button();
            btnJobStatus = new Button();
            btnLogout = new Button();
            btnMyprofile = new Button();
            panel3 = new Panel();
            btnViewTransportJob = new Button();
            btnProductSelection = new Button();
            lblNotificationsCount = new Label();
            btnNotification = new Button();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DashboardIcon).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoads).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(Logo);
            panel5.Controls.Add(eShift);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(279, 72);
            panel5.TabIndex = 10;
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(54, 10);
            Logo.Name = "Logo";
            Logo.Size = new Size(60, 53);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 5;
            Logo.TabStop = false;
            // 
            // eShift
            // 
            eShift.AutoSize = true;
            eShift.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            eShift.ForeColor = Color.Red;
            eShift.Location = new Point(120, 23);
            eShift.Name = "eShift";
            eShift.Size = new Size(75, 28);
            eShift.TabIndex = 4;
            eShift.Text = "e-Shift";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(DashboardIcon);
            panel4.Controls.Add(HomeDashboard);
            panel4.Controls.Add(Dashboard);
            panel4.Location = new Point(278, 71);
            panel4.Name = "panel4";
            panel4.Size = new Size(862, 53);
            panel4.TabIndex = 9;
            // 
            // DashboardIcon
            // 
            DashboardIcon.BackColor = Color.Transparent;
            DashboardIcon.Image = (Image)resources.GetObject("DashboardIcon.Image");
            DashboardIcon.Location = new Point(21, 16);
            DashboardIcon.Name = "DashboardIcon";
            DashboardIcon.Size = new Size(27, 22);
            DashboardIcon.SizeMode = PictureBoxSizeMode.Zoom;
            DashboardIcon.TabIndex = 4;
            DashboardIcon.TabStop = false;
            // 
            // HomeDashboard
            // 
            HomeDashboard.AutoSize = true;
            HomeDashboard.ForeColor = Color.Blue;
            HomeDashboard.Location = new Point(708, 16);
            HomeDashboard.Name = "HomeDashboard";
            HomeDashboard.Size = new Size(137, 20);
            HomeDashboard.TabIndex = 1;
            HomeDashboard.Text = "Home / Dashboard";
            // 
            // Dashboard
            // 
            Dashboard.AutoSize = true;
            Dashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Dashboard.ForeColor = Color.Fuchsia;
            Dashboard.Location = new Point(58, 16);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(113, 20);
            Dashboard.TabIndex = 0;
            Dashboard.Text = "LOAD DETAILS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(lblNotificationsCount);
            panel1.Controls.Add(btnNotification);
            panel1.Controls.Add(CustomerDashboard);
            panel1.Location = new Point(277, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 72);
            panel1.TabIndex = 7;
            // 
            // CustomerDashboard
            // 
            CustomerDashboard.AutoSize = true;
            CustomerDashboard.BackColor = Color.Transparent;
            CustomerDashboard.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            CustomerDashboard.ForeColor = Color.White;
            CustomerDashboard.Location = new Point(276, 13);
            CustomerDashboard.Name = "CustomerDashboard";
            CustomerDashboard.Size = new Size(293, 38);
            CustomerDashboard.TabIndex = 2;
            CustomerDashboard.Text = "Customer Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(LoadDetailsList);
            panel2.Controls.Add(dgvLoads);
            panel2.Controls.Add(btnViewLoads);
            panel2.Controls.Add(cmbJob);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(SelectJobID);
            panel2.Location = new Point(278, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(862, 417);
            panel2.TabIndex = 12;
            // 
            // LoadDetailsList
            // 
            LoadDetailsList.AutoSize = true;
            LoadDetailsList.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            LoadDetailsList.ForeColor = Color.DarkBlue;
            LoadDetailsList.Location = new Point(324, 101);
            LoadDetailsList.Name = "LoadDetailsList";
            LoadDetailsList.Size = new Size(231, 38);
            LoadDetailsList.TabIndex = 49;
            LoadDetailsList.Text = "Load Details List";
            // 
            // dgvLoads
            // 
            dgvLoads.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoads.BackgroundColor = Color.White;
            dgvLoads.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoads.Location = new Point(53, 152);
            dgvLoads.Name = "dgvLoads";
            dgvLoads.RowHeadersWidth = 51;
            dgvLoads.Size = new Size(763, 244);
            dgvLoads.TabIndex = 48;
            // 
            // btnViewLoads
            // 
            btnViewLoads.BackColor = Color.DarkBlue;
            btnViewLoads.FlatStyle = FlatStyle.Popup;
            btnViewLoads.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewLoads.ForeColor = Color.White;
            btnViewLoads.Location = new Point(659, 36);
            btnViewLoads.Name = "btnViewLoads";
            btnViewLoads.Size = new Size(133, 38);
            btnViewLoads.TabIndex = 47;
            btnViewLoads.Text = "LOAD";
            btnViewLoads.UseVisualStyleBackColor = false;
            btnViewLoads.Click += btnViewLoads_Click;
            // 
            // cmbJob
            // 
            cmbJob.FormattingEnabled = true;
            cmbJob.Location = new Point(193, 30);
            cmbJob.Name = "cmbJob";
            cmbJob.Size = new Size(202, 28);
            cmbJob.TabIndex = 38;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkBlue;
            panel8.Location = new Point(193, 57);
            panel8.Name = "panel8";
            panel8.Size = new Size(202, 4);
            panel8.TabIndex = 37;
            // 
            // SelectJobID
            // 
            SelectJobID.AutoSize = true;
            SelectJobID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            SelectJobID.ForeColor = Color.DarkBlue;
            SelectJobID.Location = new Point(42, 36);
            SelectJobID.Name = "SelectJobID";
            SelectJobID.Size = new Size(122, 25);
            SelectJobID.TabIndex = 27;
            SelectJobID.Text = "Select Job ID";
            // 
            // btnTransportJobRequest
            // 
            btnTransportJobRequest.FlatStyle = FlatStyle.Popup;
            btnTransportJobRequest.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTransportJobRequest.ForeColor = Color.White;
            btnTransportJobRequest.Location = new Point(2, 119);
            btnTransportJobRequest.Name = "btnTransportJobRequest";
            btnTransportJobRequest.Size = new Size(273, 59);
            btnTransportJobRequest.TabIndex = 6;
            btnTransportJobRequest.TabStop = false;
            btnTransportJobRequest.Text = "TRANSPORT JOB REQUEST";
            btnTransportJobRequest.UseVisualStyleBackColor = true;
            btnTransportJobRequest.Click += btnTransportJobRequest_Click;
            // 
            // btnLoadDetails
            // 
            btnLoadDetails.FlatStyle = FlatStyle.Popup;
            btnLoadDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLoadDetails.ForeColor = Color.Fuchsia;
            btnLoadDetails.Location = new Point(3, 235);
            btnLoadDetails.Name = "btnLoadDetails";
            btnLoadDetails.Size = new Size(273, 59);
            btnLoadDetails.TabIndex = 5;
            btnLoadDetails.Text = "LOAD DETAILS";
            btnLoadDetails.UseVisualStyleBackColor = true;
            btnLoadDetails.Click += btnLoadDetails_Click;
            // 
            // btnJobStatus
            // 
            btnJobStatus.FlatStyle = FlatStyle.Popup;
            btnJobStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnJobStatus.ForeColor = Color.White;
            btnJobStatus.Location = new Point(3, 290);
            btnJobStatus.Name = "btnJobStatus";
            btnJobStatus.Size = new Size(273, 59);
            btnJobStatus.TabIndex = 7;
            btnJobStatus.Text = "JOB STATUS";
            btnJobStatus.UseVisualStyleBackColor = true;
            btnJobStatus.Click += btnJobStatus_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.Cyan;
            btnLogout.Location = new Point(3, 409);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(273, 59);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnMyprofile
            // 
            btnMyprofile.FlatStyle = FlatStyle.Popup;
            btnMyprofile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMyprofile.ForeColor = Color.White;
            btnMyprofile.Location = new Point(3, 3);
            btnMyprofile.Name = "btnMyprofile";
            btnMyprofile.Size = new Size(273, 59);
            btnMyprofile.TabIndex = 11;
            btnMyprofile.Text = "MY PROFILE";
            btnMyprofile.UseVisualStyleBackColor = true;
            btnMyprofile.Click += btnMyprofile_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkBlue;
            panel3.Controls.Add(btnViewTransportJob);
            panel3.Controls.Add(btnProductSelection);
            panel3.Controls.Add(btnMyprofile);
            panel3.Controls.Add(btnLogout);
            panel3.Controls.Add(btnJobStatus);
            panel3.Controls.Add(btnLoadDetails);
            panel3.Controls.Add(btnTransportJobRequest);
            panel3.Location = new Point(-1, 72);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 470);
            panel3.TabIndex = 11;
            // 
            // btnViewTransportJob
            // 
            btnViewTransportJob.FlatStyle = FlatStyle.Popup;
            btnViewTransportJob.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewTransportJob.ForeColor = Color.White;
            btnViewTransportJob.Location = new Point(1, 61);
            btnViewTransportJob.Name = "btnViewTransportJob";
            btnViewTransportJob.Size = new Size(273, 59);
            btnViewTransportJob.TabIndex = 14;
            btnViewTransportJob.Text = "VIEW TRANSPORTJOB";
            btnViewTransportJob.UseVisualStyleBackColor = true;
            btnViewTransportJob.Click += btnViewTransportJob_Click;
            // 
            // btnProductSelection
            // 
            btnProductSelection.FlatStyle = FlatStyle.Popup;
            btnProductSelection.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnProductSelection.ForeColor = Color.White;
            btnProductSelection.Location = new Point(0, 177);
            btnProductSelection.Name = "btnProductSelection";
            btnProductSelection.Size = new Size(273, 59);
            btnProductSelection.TabIndex = 13;
            btnProductSelection.Text = "PRODUCT SELECTION";
            btnProductSelection.UseVisualStyleBackColor = true;
            btnProductSelection.Click += btnProductSelection_Click;
            // 
            // lblNotificationsCount
            // 
            lblNotificationsCount.AutoSize = true;
            lblNotificationsCount.BackColor = Color.Red;
            lblNotificationsCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNotificationsCount.ForeColor = Color.White;
            lblNotificationsCount.Location = new Point(788, 16);
            lblNotificationsCount.Name = "lblNotificationsCount";
            lblNotificationsCount.Size = new Size(18, 20);
            lblNotificationsCount.TabIndex = 6;
            lblNotificationsCount.Text = "0";
            // 
            // btnNotification
            // 
            btnNotification.BackgroundImage = (Image)resources.GetObject("btnNotification.BackgroundImage");
            btnNotification.BackgroundImageLayout = ImageLayout.Zoom;
            btnNotification.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotification.Location = new Point(765, 16);
            btnNotification.Name = "btnNotification";
            btnNotification.Size = new Size(42, 38);
            btnNotification.TabIndex = 5;
            btnNotification.UseVisualStyleBackColor = true;
            btnNotification.Click += btnNotification_Click;
            // 
            // CustomerLoad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 539);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "CustomerLoad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerLoad";
            Load += CustomerLoad_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DashboardIcon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoads).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private PictureBox Logo;
        private Label eShift;
        private Panel panel4;
        private PictureBox DashboardIcon;
        private Label HomeDashboard;
        private Label Dashboard;
        private Panel panel1;
        private Label CustomerDashboard;
        private Panel panel2;
        private Label SelectJobID;
        private ComboBox cmbJob;
        private Panel panel8;
        private DataGridView dgvLoads;
        private Button btnViewLoads;
        private Label LoadDetailsList;
        private Button btnTransportJobRequest;
        private Button btnLoadDetails;
        private Button btnJobStatus;
        private Button btnLogout;
        private Button btnMyprofile;
        private Panel panel3;
        private Button btnProductSelection;
        private Button btnViewTransportJob;
        private Label lblNotificationsCount;
        private Button btnNotification;
    }
}