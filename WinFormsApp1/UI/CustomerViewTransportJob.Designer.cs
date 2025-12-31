namespace WinFormsApp1.UI
{
    partial class CustomerViewTransportJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerViewTransportJob));
            panel5 = new Panel();
            Logo = new PictureBox();
            eShift = new Label();
            panel4 = new Panel();
            DashboardIcon = new PictureBox();
            HomeDashboard = new Label();
            TransportJobDetails = new Label();
            panel3 = new Panel();
            btnViewTransportJob = new Button();
            btnProductSelection = new Button();
            btnMyprofile = new Button();
            btnLogout = new Button();
            btnJobStatus = new Button();
            btnLoadDetails = new Button();
            btnTransportJob = new Button();
            panel1 = new Panel();
            CustomerDashboard = new Label();
            panel2 = new Panel();
            btnRefreshJobs = new Button();
            YourTransportJobList = new Label();
            dgvMyJobs = new DataGridView();
            lblNotificationsCount = new Label();
            btnNotification = new Button();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DashboardIcon).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyJobs).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(Logo);
            panel5.Controls.Add(eShift);
            panel5.Location = new Point(-1, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(279, 72);
            panel5.TabIndex = 14;
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
            panel4.Controls.Add(TransportJobDetails);
            panel4.Location = new Point(277, 72);
            panel4.Name = "panel4";
            panel4.Size = new Size(896, 53);
            panel4.TabIndex = 13;
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
            HomeDashboard.Location = new Point(734, 16);
            HomeDashboard.Name = "HomeDashboard";
            HomeDashboard.Size = new Size(137, 20);
            HomeDashboard.TabIndex = 1;
            HomeDashboard.Text = "Home / Dashboard";
            // 
            // TransportJobDetails
            // 
            TransportJobDetails.AutoSize = true;
            TransportJobDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TransportJobDetails.ForeColor = Color.Fuchsia;
            TransportJobDetails.Location = new Point(58, 16);
            TransportJobDetails.Name = "TransportJobDetails";
            TransportJobDetails.Size = new Size(171, 20);
            TransportJobDetails.TabIndex = 0;
            TransportJobDetails.Text = "VIEW TRANSPORTJOB ";
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
            panel3.Controls.Add(btnTransportJob);
            panel3.Location = new Point(-1, 72);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 488);
            panel3.TabIndex = 12;
            // 
            // btnViewTransportJob
            // 
            btnViewTransportJob.FlatStyle = FlatStyle.Popup;
            btnViewTransportJob.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewTransportJob.ForeColor = Color.Fuchsia;
            btnViewTransportJob.Location = new Point(3, 61);
            btnViewTransportJob.Name = "btnViewTransportJob";
            btnViewTransportJob.Size = new Size(273, 59);
            btnViewTransportJob.TabIndex = 5;
            btnViewTransportJob.Text = "VIEW TRANSPORTJOB";
            btnViewTransportJob.UseVisualStyleBackColor = true;
            btnViewTransportJob.Click += btnViewTransportJob_Click;
            // 
            // btnProductSelection
            // 
            btnProductSelection.FlatStyle = FlatStyle.Popup;
            btnProductSelection.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnProductSelection.ForeColor = Color.White;
            btnProductSelection.Location = new Point(3, 177);
            btnProductSelection.Name = "btnProductSelection";
            btnProductSelection.Size = new Size(273, 59);
            btnProductSelection.TabIndex = 12;
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
            btnLogout.Location = new Point(3, 425);
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
            btnJobStatus.ForeColor = Color.White;
            btnJobStatus.Location = new Point(3, 293);
            btnJobStatus.Name = "btnJobStatus";
            btnJobStatus.Size = new Size(273, 59);
            btnJobStatus.TabIndex = 7;
            btnJobStatus.Text = "JOB STATUS";
            btnJobStatus.UseVisualStyleBackColor = true;
            btnJobStatus.Click += btnJobStatus_Click;
            // 
            // btnLoadDetails
            // 
            btnLoadDetails.FlatStyle = FlatStyle.Popup;
            btnLoadDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLoadDetails.ForeColor = Color.White;
            btnLoadDetails.Location = new Point(3, 235);
            btnLoadDetails.Name = "btnLoadDetails";
            btnLoadDetails.Size = new Size(273, 59);
            btnLoadDetails.TabIndex = 6;
            btnLoadDetails.Text = "LOAD DETAILS";
            btnLoadDetails.UseVisualStyleBackColor = true;
            btnLoadDetails.Click += btnLoadDetails_Click;
            // 
            // btnTransportJob
            // 
            btnTransportJob.FlatStyle = FlatStyle.Popup;
            btnTransportJob.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTransportJob.ForeColor = Color.White;
            btnTransportJob.Location = new Point(2, 119);
            btnTransportJob.Name = "btnTransportJob";
            btnTransportJob.Size = new Size(273, 59);
            btnTransportJob.TabIndex = 13;
            btnTransportJob.Text = "TRANSPORT JOB REQUEST";
            btnTransportJob.UseVisualStyleBackColor = true;
            btnTransportJob.Click += btnTransportJob_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(lblNotificationsCount);
            panel1.Controls.Add(btnNotification);
            panel1.Controls.Add(CustomerDashboard);
            panel1.Location = new Point(277, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 72);
            panel1.TabIndex = 11;
            // 
            // CustomerDashboard
            // 
            CustomerDashboard.AutoSize = true;
            CustomerDashboard.BackColor = Color.Transparent;
            CustomerDashboard.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            CustomerDashboard.ForeColor = Color.White;
            CustomerDashboard.Location = new Point(291, 13);
            CustomerDashboard.Name = "CustomerDashboard";
            CustomerDashboard.Size = new Size(293, 38);
            CustomerDashboard.TabIndex = 2;
            CustomerDashboard.Text = "Customer Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnRefreshJobs);
            panel2.Controls.Add(YourTransportJobList);
            panel2.Controls.Add(dgvMyJobs);
            panel2.Location = new Point(277, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(896, 436);
            panel2.TabIndex = 15;
            // 
            // btnRefreshJobs
            // 
            btnRefreshJobs.BackColor = Color.CornflowerBlue;
            btnRefreshJobs.FlatStyle = FlatStyle.Popup;
            btnRefreshJobs.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefreshJobs.ForeColor = Color.White;
            btnRefreshJobs.Location = new Point(668, 39);
            btnRefreshJobs.Name = "btnRefreshJobs";
            btnRefreshJobs.Size = new Size(122, 44);
            btnRefreshJobs.TabIndex = 29;
            btnRefreshJobs.Text = "REFRESH";
            btnRefreshJobs.UseVisualStyleBackColor = false;
            btnRefreshJobs.Click += btnRefreshJobs_Click;
            // 
            // YourTransportJobList
            // 
            YourTransportJobList.AutoSize = true;
            YourTransportJobList.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            YourTransportJobList.ForeColor = Color.DarkBlue;
            YourTransportJobList.Location = new Point(266, 37);
            YourTransportJobList.Name = "YourTransportJobList";
            YourTransportJobList.Size = new Size(317, 38);
            YourTransportJobList.TabIndex = 28;
            YourTransportJobList.Text = "Your Transport Job List";
            // 
            // dgvMyJobs
            // 
            dgvMyJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMyJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyJobs.Location = new Point(63, 107);
            dgvMyJobs.Name = "dgvMyJobs";
            dgvMyJobs.ReadOnly = true;
            dgvMyJobs.RowHeadersWidth = 51;
            dgvMyJobs.Size = new Size(770, 295);
            dgvMyJobs.TabIndex = 27;
            dgvMyJobs.DataBindingComplete += dgvMyJobs_DataBindingComplete;
            // 
            // lblNotificationsCount
            // 
            lblNotificationsCount.AutoSize = true;
            lblNotificationsCount.BackColor = Color.Red;
            lblNotificationsCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNotificationsCount.ForeColor = Color.White;
            lblNotificationsCount.Location = new Point(830, 18);
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
            btnNotification.Location = new Point(807, 18);
            btnNotification.Name = "btnNotification";
            btnNotification.Size = new Size(42, 38);
            btnNotification.TabIndex = 5;
            btnNotification.UseVisualStyleBackColor = true;
            btnNotification.Click += btnNotification_Click;
            // 
            // CustomerViewTransportJob
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 559);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "CustomerViewTransportJob";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerViewTransportJob";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DashboardIcon).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyJobs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private PictureBox Logo;
        private Label eShift;
        private Panel panel4;
        private PictureBox DashboardIcon;
        private Label HomeDashboard;
        private Label TransportJobDetails;
        private Panel panel3;
        private Button btnViewTransportJob;
        private Button btnProductSelection;
        private Button btnMyprofile;
        private Button btnLogout;
        private Button btnJobStatus;
        private Button btnLoadDetails;
        private Button btnTransportJob;
        private Panel panel1;
        private Label CustomerDashboard;
        private Panel panel2;
        private Button btnRefreshJobs;
        private Label YourTransportJobList;
        private DataGridView dgvMyJobs;
        private Label lblNotificationsCount;
        private Button btnNotification;
    }
}