namespace WinFormsApp1.UI
{
    partial class CustomerJobStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerJobStatus));
            panel3 = new Panel();
            btnTransportJobRequest = new Button();
            btnViewTransportJob = new Button();
            btnProductSelection = new Button();
            btnMyprofile = new Button();
            btnLogout = new Button();
            btnJobStatus = new Button();
            btnLoadDetails = new Button();
            panel5 = new Panel();
            Logo = new PictureBox();
            eShift = new Label();
            panel4 = new Panel();
            DashboardIcon = new PictureBox();
            HomeDashboard = new Label();
            Dashboard = new Label();
            panel1 = new Panel();
            lblNotificationsCount = new Label();
            btnNotification = new Button();
            CustomerDashboard = new Label();
            panel2 = new Panel();
            panel9 = new Panel();
            cmbJobStatus = new ComboBox();
            JobStatus = new Label();
            btnFilterStatus = new Button();
            YourTransportJobs = new Label();
            dgvMyJobs = new DataGridView();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DashboardIcon).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyJobs).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkBlue;
            panel3.Controls.Add(btnTransportJobRequest);
            panel3.Controls.Add(btnViewTransportJob);
            panel3.Controls.Add(btnProductSelection);
            panel3.Controls.Add(btnMyprofile);
            panel3.Controls.Add(btnLogout);
            panel3.Controls.Add(btnJobStatus);
            panel3.Controls.Add(btnLoadDetails);
            panel3.Location = new Point(0, 72);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 470);
            panel3.TabIndex = 13;
            // 
            // btnTransportJobRequest
            // 
            btnTransportJobRequest.FlatStyle = FlatStyle.Popup;
            btnTransportJobRequest.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTransportJobRequest.ForeColor = Color.White;
            btnTransportJobRequest.Location = new Point(0, 119);
            btnTransportJobRequest.Name = "btnTransportJobRequest";
            btnTransportJobRequest.Size = new Size(273, 59);
            btnTransportJobRequest.TabIndex = 16;
            btnTransportJobRequest.Text = "TRANSPORT JOB REQUEST";
            btnTransportJobRequest.UseVisualStyleBackColor = true;
            btnTransportJobRequest.Click += btnTransportJobRequest_Click;
            // 
            // btnViewTransportJob
            // 
            btnViewTransportJob.FlatStyle = FlatStyle.Popup;
            btnViewTransportJob.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewTransportJob.ForeColor = Color.White;
            btnViewTransportJob.Location = new Point(2, 61);
            btnViewTransportJob.Name = "btnViewTransportJob";
            btnViewTransportJob.Size = new Size(273, 59);
            btnViewTransportJob.TabIndex = 15;
            btnViewTransportJob.Text = "VIEW TRANSPORTJOB";
            btnViewTransportJob.UseVisualStyleBackColor = true;
            btnViewTransportJob.Click += btnViewTransportJob_Click;
            // 
            // btnProductSelection
            // 
            btnProductSelection.FlatStyle = FlatStyle.Popup;
            btnProductSelection.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnProductSelection.ForeColor = Color.White;
            btnProductSelection.Location = new Point(2, 177);
            btnProductSelection.Name = "btnProductSelection";
            btnProductSelection.Size = new Size(273, 59);
            btnProductSelection.TabIndex = 14;
            btnProductSelection.Text = "PRODUCT SELECTION";
            btnProductSelection.UseVisualStyleBackColor = true;
            btnProductSelection.Click += btnProductSelection_Click;
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
            // btnJobStatus
            // 
            btnJobStatus.FlatStyle = FlatStyle.Popup;
            btnJobStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnJobStatus.ForeColor = Color.Fuchsia;
            btnJobStatus.Location = new Point(3, 293);
            btnJobStatus.Name = "btnJobStatus";
            btnJobStatus.Size = new Size(273, 59);
            btnJobStatus.TabIndex = 6;
            btnJobStatus.Text = "JOB STATUS";
            btnJobStatus.UseVisualStyleBackColor = true;
            btnJobStatus.Click += btnJobStatus_Click;
            // 
            // btnLoadDetails
            // 
            btnLoadDetails.FlatStyle = FlatStyle.Popup;
            btnLoadDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLoadDetails.ForeColor = Color.White;
            btnLoadDetails.Location = new Point(4, 235);
            btnLoadDetails.Name = "btnLoadDetails";
            btnLoadDetails.Size = new Size(273, 59);
            btnLoadDetails.TabIndex = 6;
            btnLoadDetails.Text = "LOAD DETAILS";
            btnLoadDetails.UseVisualStyleBackColor = true;
            btnLoadDetails.Click += btnLoadDetails_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(Logo);
            panel5.Controls.Add(eShift);
            panel5.Location = new Point(0, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(279, 72);
            panel5.TabIndex = 12;
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
            panel4.Location = new Point(278, 72);
            panel4.Name = "panel4";
            panel4.Size = new Size(763, 53);
            panel4.TabIndex = 11;
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
            HomeDashboard.Location = new Point(607, 16);
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
            Dashboard.Size = new Size(95, 20);
            Dashboard.TabIndex = 0;
            Dashboard.Text = "JOB STATUS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(lblNotificationsCount);
            panel1.Controls.Add(btnNotification);
            panel1.Controls.Add(CustomerDashboard);
            panel1.Location = new Point(278, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 72);
            panel1.TabIndex = 10;
            // 
            // lblNotificationsCount
            // 
            lblNotificationsCount.AutoSize = true;
            lblNotificationsCount.BackColor = Color.Red;
            lblNotificationsCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNotificationsCount.ForeColor = Color.White;
            lblNotificationsCount.Location = new Point(697, 17);
            lblNotificationsCount.Name = "lblNotificationsCount";
            lblNotificationsCount.Size = new Size(18, 20);
            lblNotificationsCount.TabIndex = 4;
            lblNotificationsCount.Text = "0";
            lblNotificationsCount.Click += lblNotificationsCount_Click;
            // 
            // btnNotification
            // 
            btnNotification.BackgroundImage = (Image)resources.GetObject("btnNotification.BackgroundImage");
            btnNotification.BackgroundImageLayout = ImageLayout.Zoom;
            btnNotification.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotification.Location = new Point(674, 17);
            btnNotification.Name = "btnNotification";
            btnNotification.Size = new Size(42, 38);
            btnNotification.TabIndex = 3;
            btnNotification.UseVisualStyleBackColor = true;
            btnNotification.Click += btnNotification_Click_1;
            // 
            // CustomerDashboard
            // 
            CustomerDashboard.AutoSize = true;
            CustomerDashboard.BackColor = Color.Transparent;
            CustomerDashboard.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            CustomerDashboard.ForeColor = Color.White;
            CustomerDashboard.Location = new Point(229, 13);
            CustomerDashboard.Name = "CustomerDashboard";
            CustomerDashboard.Size = new Size(293, 38);
            CustomerDashboard.TabIndex = 2;
            CustomerDashboard.Text = "Customer Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(cmbJobStatus);
            panel2.Controls.Add(JobStatus);
            panel2.Controls.Add(btnFilterStatus);
            panel2.Controls.Add(YourTransportJobs);
            panel2.Controls.Add(dgvMyJobs);
            panel2.Location = new Point(279, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(762, 418);
            panel2.TabIndex = 14;
            // 
            // panel9
            // 
            panel9.BackColor = Color.DarkBlue;
            panel9.Location = new Point(194, 370);
            panel9.Name = "panel9";
            panel9.Size = new Size(153, 4);
            panel9.TabIndex = 38;
            // 
            // cmbJobStatus
            // 
            cmbJobStatus.FormattingEnabled = true;
            cmbJobStatus.Items.AddRange(new object[] { "Pending", "Accepted", "Completed", "Declined" });
            cmbJobStatus.Location = new Point(195, 343);
            cmbJobStatus.Name = "cmbJobStatus";
            cmbJobStatus.Size = new Size(153, 28);
            cmbJobStatus.TabIndex = 40;
            // 
            // JobStatus
            // 
            JobStatus.AutoSize = true;
            JobStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            JobStatus.ForeColor = Color.FromArgb(0, 0, 192);
            JobStatus.Location = new Point(46, 343);
            JobStatus.Name = "JobStatus";
            JobStatus.Size = new Size(94, 23);
            JobStatus.TabIndex = 39;
            JobStatus.Text = "Job Status";
            // 
            // btnFilterStatus
            // 
            btnFilterStatus.BackColor = Color.DarkBlue;
            btnFilterStatus.FlatStyle = FlatStyle.Popup;
            btnFilterStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFilterStatus.ForeColor = Color.White;
            btnFilterStatus.Location = new Point(511, 348);
            btnFilterStatus.Name = "btnFilterStatus";
            btnFilterStatus.Size = new Size(175, 45);
            btnFilterStatus.TabIndex = 37;
            btnFilterStatus.Text = "FILTER STATUS";
            btnFilterStatus.UseVisualStyleBackColor = false;
            btnFilterStatus.Click += btnFilterStatus_Click;
            // 
            // YourTransportJobs
            // 
            YourTransportJobs.AutoSize = true;
            YourTransportJobs.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            YourTransportJobs.ForeColor = Color.DarkBlue;
            YourTransportJobs.Location = new Point(194, 26);
            YourTransportJobs.Name = "YourTransportJobs";
            YourTransportJobs.Size = new Size(357, 38);
            YourTransportJobs.TabIndex = 36;
            YourTransportJobs.Text = "Your Transport Job/Status";
            // 
            // dgvMyJobs
            // 
            dgvMyJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMyJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyJobs.Location = new Point(25, 84);
            dgvMyJobs.Name = "dgvMyJobs";
            dgvMyJobs.RowHeadersWidth = 51;
            dgvMyJobs.Size = new Size(710, 227);
            dgvMyJobs.TabIndex = 35;
            dgvMyJobs.DataBindingComplete += dgvMyJobs_DataBindingComplete;
            dgvMyJobs.RowPrePaint += dgvMyJobs_RowPrePaint;
            // 
            // CustomerJobStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 541);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "CustomerJobStatus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerJobStatus";
            panel3.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)dgvMyJobs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button btnMyprofile;
        private Button btnLogout;
        private Button btnJobStatus;
        private Button btnLoadDetails;
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
        private Label YourTransportJobs;
        private DataGridView dgvMyJobs;
        private Button btnFilterStatus;
        private Panel panel9;
        private ComboBox cmbJobStatus;
        private Label JobStatus;
        private Button btnProductSelection;
        private Button btnViewTransportJob;
        private Button btnTransportJobRequest;
        private Button btnNotification;
        private Label lblNotificationsCount;
    }
}