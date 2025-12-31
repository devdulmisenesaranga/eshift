namespace WinFormsApp1.UI
{
    partial class CustomerTransportJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerTransportJob));
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
            StartLocation = new Label();
            Destination = new Label();
            ScheduledDate = new Label();
            btnCreateJob = new Button();
            panel2 = new Panel();
            chkUseSchedule = new CheckBox();
            panel9 = new Panel();
            cmbJobStatus = new ComboBox();
            JobStatus = new Label();
            panel8 = new Panel();
            dtpSchedule = new DateTimePicker();
            panel7 = new Panel();
            txtDestination = new TextBox();
            panel6 = new Panel();
            txtStart = new TextBox();
            lblNotificationsCount = new Label();
            btnNotification = new Button();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DashboardIcon).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(Logo);
            panel5.Controls.Add(eShift);
            panel5.Location = new Point(0, -1);
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
            panel4.Controls.Add(TransportJobDetails);
            panel4.Location = new Point(278, 70);
            panel4.Name = "panel4";
            panel4.Size = new Size(896, 53);
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
            HomeDashboard.Location = new Point(734, 16);
            HomeDashboard.Name = "HomeDashboard";
            HomeDashboard.Size = new Size(137, 20);
            HomeDashboard.TabIndex = 1;
            HomeDashboard.Text = "Home / Dashboard";
            HomeDashboard.Click += HomeDashboard_Click;
            // 
            // TransportJobDetails
            // 
            TransportJobDetails.AutoSize = true;
            TransportJobDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TransportJobDetails.ForeColor = Color.Fuchsia;
            TransportJobDetails.Location = new Point(58, 16);
            TransportJobDetails.Name = "TransportJobDetails";
            TransportJobDetails.Size = new Size(199, 20);
            TransportJobDetails.TabIndex = 0;
            TransportJobDetails.Text = "TRANSPORT JOB REQUEST";
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
            panel3.Location = new Point(0, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 488);
            panel3.TabIndex = 8;
            // 
            // btnViewTransportJob
            // 
            btnViewTransportJob.FlatStyle = FlatStyle.Popup;
            btnViewTransportJob.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewTransportJob.ForeColor = Color.White;
            btnViewTransportJob.Location = new Point(3, 61);
            btnViewTransportJob.Name = "btnViewTransportJob";
            btnViewTransportJob.Size = new Size(273, 59);
            btnViewTransportJob.TabIndex = 13;
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
            btnTransportJob.ForeColor = Color.Fuchsia;
            btnTransportJob.Location = new Point(2, 119);
            btnTransportJob.Name = "btnTransportJob";
            btnTransportJob.Size = new Size(273, 59);
            btnTransportJob.TabIndex = 5;
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
            panel1.Location = new Point(278, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 72);
            panel1.TabIndex = 7;
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
            // StartLocation
            // 
            StartLocation.AutoSize = true;
            StartLocation.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            StartLocation.ForeColor = Color.FromArgb(0, 0, 192);
            StartLocation.Location = new Point(131, 40);
            StartLocation.Name = "StartLocation";
            StartLocation.Size = new Size(132, 25);
            StartLocation.TabIndex = 11;
            StartLocation.Text = "Start Location";
            // 
            // Destination
            // 
            Destination.AutoSize = true;
            Destination.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            Destination.ForeColor = Color.FromArgb(0, 0, 192);
            Destination.Location = new Point(131, 103);
            Destination.Name = "Destination";
            Destination.Size = new Size(110, 25);
            Destination.TabIndex = 12;
            Destination.Text = "Destination";
            // 
            // ScheduledDate
            // 
            ScheduledDate.AutoSize = true;
            ScheduledDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            ScheduledDate.ForeColor = Color.FromArgb(0, 0, 192);
            ScheduledDate.Location = new Point(131, 167);
            ScheduledDate.Name = "ScheduledDate";
            ScheduledDate.Size = new Size(134, 25);
            ScheduledDate.TabIndex = 13;
            ScheduledDate.Text = "Schedule Date";
            // 
            // btnCreateJob
            // 
            btnCreateJob.BackColor = Color.DarkBlue;
            btnCreateJob.FlatStyle = FlatStyle.Popup;
            btnCreateJob.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCreateJob.ForeColor = Color.White;
            btnCreateJob.Location = new Point(297, 343);
            btnCreateJob.Name = "btnCreateJob";
            btnCreateJob.Size = new Size(237, 38);
            btnCreateJob.TabIndex = 15;
            btnCreateJob.Text = "CREATE JOB";
            btnCreateJob.UseVisualStyleBackColor = false;
            btnCreateJob.Click += btnCreateJob_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(chkUseSchedule);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(cmbJobStatus);
            panel2.Controls.Add(JobStatus);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(dtpSchedule);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(txtDestination);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(txtStart);
            panel2.Controls.Add(ScheduledDate);
            panel2.Controls.Add(btnCreateJob);
            panel2.Controls.Add(StartLocation);
            panel2.Controls.Add(Destination);
            panel2.Location = new Point(279, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(896, 436);
            panel2.TabIndex = 16;
            // 
            // chkUseSchedule
            // 
            chkUseSchedule.AutoSize = true;
            chkUseSchedule.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkUseSchedule.ForeColor = Color.DarkBlue;
            chkUseSchedule.Location = new Point(298, 206);
            chkUseSchedule.Name = "chkUseSchedule";
            chkUseSchedule.Size = new Size(129, 24);
            chkUseSchedule.TabIndex = 32;
            chkUseSchedule.Text = "User Schedule";
            chkUseSchedule.UseVisualStyleBackColor = true;
            chkUseSchedule.Visible = false;
            // 
            // panel9
            // 
            panel9.BackColor = Color.DarkBlue;
            panel9.Location = new Point(295, 274);
            panel9.Name = "panel9";
            panel9.Size = new Size(238, 4);
            panel9.TabIndex = 22;
            // 
            // cmbJobStatus
            // 
            cmbJobStatus.FormattingEnabled = true;
            cmbJobStatus.Items.AddRange(new object[] { "Pending", "Accepted", "Completed", "Declined" });
            cmbJobStatus.Location = new Point(296, 247);
            cmbJobStatus.Name = "cmbJobStatus";
            cmbJobStatus.Size = new Size(238, 28);
            cmbJobStatus.TabIndex = 31;
            // 
            // JobStatus
            // 
            JobStatus.AutoSize = true;
            JobStatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            JobStatus.ForeColor = Color.FromArgb(0, 0, 192);
            JobStatus.Location = new Point(129, 247);
            JobStatus.Name = "JobStatus";
            JobStatus.Size = new Size(100, 25);
            JobStatus.TabIndex = 30;
            JobStatus.Text = "Job Status";
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkBlue;
            panel8.Location = new Point(297, 186);
            panel8.Name = "panel8";
            panel8.Size = new Size(238, 4);
            panel8.TabIndex = 21;
            // 
            // dtpSchedule
            // 
            dtpSchedule.Location = new Point(296, 161);
            dtpSchedule.Name = "dtpSchedule";
            dtpSchedule.Size = new Size(240, 27);
            dtpSchedule.TabIndex = 20;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkBlue;
            panel7.Location = new Point(297, 122);
            panel7.Name = "panel7";
            panel7.Size = new Size(238, 4);
            panel7.TabIndex = 19;
            // 
            // txtDestination
            // 
            txtDestination.BorderStyle = BorderStyle.FixedSingle;
            txtDestination.Location = new Point(296, 95);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(239, 27);
            txtDestination.TabIndex = 18;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkBlue;
            panel6.Location = new Point(298, 67);
            panel6.Name = "panel6";
            panel6.Size = new Size(238, 4);
            panel6.TabIndex = 17;
            // 
            // txtStart
            // 
            txtStart.BorderStyle = BorderStyle.FixedSingle;
            txtStart.Location = new Point(297, 40);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(239, 27);
            txtStart.TabIndex = 16;
            // 
            // lblNotificationsCount
            // 
            lblNotificationsCount.AutoSize = true;
            lblNotificationsCount.BackColor = Color.Red;
            lblNotificationsCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNotificationsCount.ForeColor = Color.White;
            lblNotificationsCount.Location = new Point(839, 18);
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
            btnNotification.Location = new Point(816, 18);
            btnNotification.Name = "btnNotification";
            btnNotification.Size = new Size(42, 38);
            btnNotification.TabIndex = 5;
            btnNotification.UseVisualStyleBackColor = true;
            btnNotification.Click += btnNotification_Click;
            // 
            // CustomerTransportJob
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 556);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "CustomerTransportJob";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerTransportJob";
            Load += CustomerTransportJob_Load;
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
        private Button btnMyprofile;
        private Button btnLogout;
        private Button btnJobStatus;
        private Button btnLoadDetails;
        private Button btnTransportJob;
        private Panel panel1;
        private Label CustomerDashboard;
        private Label StartLocation;
        private Label Destination;
        private Label ScheduledDate;
        private Button btnCreateJob;
        private Panel panel2;
        private Panel panel6;
        private TextBox txtStart;
        private Panel panel8;
        private DateTimePicker dtpSchedule;
        private Panel panel7;
        private TextBox txtDestination;
        private Label JobStatus;
        private Panel panel9;
        private ComboBox cmbJobStatus;
        private Button btnProductSelection;
        private Button btnViewTransportJob;
        private CheckBox chkUseSchedule;
        private Label lblNotificationsCount;
        private Button btnNotification;
    }
}