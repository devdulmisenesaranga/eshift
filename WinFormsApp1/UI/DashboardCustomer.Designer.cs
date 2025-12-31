namespace WinFormsApp1.UI
{
    partial class DashboardCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardCustomer));
            panel4 = new Panel();
            DashboardIcon = new PictureBox();
            HomeDashboard = new Label();
            Dashboard = new Label();
            panel1 = new Panel();
            CustomerDashboard = new Label();
            panel5 = new Panel();
            Logo = new PictureBox();
            eShift = new Label();
            panel2 = new Panel();
            panel9 = new Panel();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnUpdate = new Button();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            rtbAddress = new RichTextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            Address = new Label();
            Phone = new Label();
            Email = new Label();
            panel3 = new Panel();
            btnMyprofile = new Button();
            btnTransportJob = new Button();
            btnProductSelection = new Button();
            btnLogout = new Button();
            btnJobStatus = new Button();
            btnLoadDetails = new Button();
            btnViewTransportJob = new Button();
            lblNotificationsCount = new Label();
            btnNotification = new Button();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DashboardIcon).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(DashboardIcon);
            panel4.Controls.Add(HomeDashboard);
            panel4.Controls.Add(Dashboard);
            panel4.Location = new Point(279, 71);
            panel4.Name = "panel4";
            panel4.Size = new Size(763, 53);
            panel4.TabIndex = 5;
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
            HomeDashboard.TabIndex = 90;
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
            Dashboard.TabIndex = 900;
            Dashboard.Text = "MY PROFILE";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(lblNotificationsCount);
            panel1.Controls.Add(btnNotification);
            panel1.Controls.Add(CustomerDashboard);
            panel1.Location = new Point(279, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 72);
            panel1.TabIndex = 3;
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
            CustomerDashboard.TabIndex = 200;
            CustomerDashboard.Text = "Customer Dashboard";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(Logo);
            panel5.Controls.Add(eShift);
            panel5.Location = new Point(1, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(279, 72);
            panel5.TabIndex = 6;
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(rtbAddress);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(Address);
            panel2.Controls.Add(Phone);
            panel2.Controls.Add(Email);
            panel2.Location = new Point(282, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(763, 418);
            panel2.TabIndex = 7;
            // 
            // panel9
            // 
            panel9.BackColor = Color.DarkBlue;
            panel9.Location = new Point(271, 121);
            panel9.Name = "panel9";
            panel9.Size = new Size(282, 4);
            panel9.TabIndex = 32;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(271, 94);
            txtName.Name = "txtName";
            txtName.Size = new Size(281, 27);
            txtName.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(151, 94);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 30;
            label2.Text = "Full Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(216, 15);
            label1.Name = "label1";
            label1.Size = new Size(277, 38);
            label1.TabIndex = 29;
            label1.Text = "Update Your Details";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkBlue;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(272, 339);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(183, 44);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "UPDATE PROFILE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkBlue;
            panel6.Location = new Point(272, 307);
            panel6.Name = "panel6";
            panel6.Size = new Size(285, 4);
            panel6.TabIndex = 26;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkBlue;
            panel7.Location = new Point(272, 219);
            panel7.Name = "panel7";
            panel7.Size = new Size(281, 4);
            panel7.TabIndex = 25;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkBlue;
            panel8.Location = new Point(272, 171);
            panel8.Name = "panel8";
            panel8.Size = new Size(282, 4);
            panel8.TabIndex = 24;
            // 
            // rtbAddress
            // 
            rtbAddress.BorderStyle = BorderStyle.FixedSingle;
            rtbAddress.Location = new Point(272, 248);
            rtbAddress.Name = "rtbAddress";
            rtbAddress.Size = new Size(285, 63);
            rtbAddress.TabIndex = 22;
            rtbAddress.Text = "";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Location = new Point(272, 192);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(281, 27);
            txtPhone.TabIndex = 21;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(272, 144);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(281, 27);
            txtEmail.TabIndex = 10;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            Address.ForeColor = Color.DarkBlue;
            Address.Location = new Point(152, 248);
            Address.Name = "Address";
            Address.Size = new Size(80, 25);
            Address.TabIndex = 18;
            Address.Text = "Address";
            Address.Click += Address_Click;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            Phone.ForeColor = Color.DarkBlue;
            Phone.Location = new Point(151, 194);
            Phone.Name = "Phone";
            Phone.Size = new Size(66, 25);
            Phone.TabIndex = 17;
            Phone.Text = "Phone";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            Email.ForeColor = Color.DarkBlue;
            Email.Location = new Point(151, 143);
            Email.Name = "Email";
            Email.Size = new Size(58, 25);
            Email.TabIndex = 16;
            Email.Text = "Email";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkBlue;
            panel3.Controls.Add(btnMyprofile);
            panel3.Controls.Add(btnTransportJob);
            panel3.Controls.Add(btnProductSelection);
            panel3.Controls.Add(btnLogout);
            panel3.Controls.Add(btnJobStatus);
            panel3.Controls.Add(btnLoadDetails);
            panel3.Controls.Add(btnViewTransportJob);
            panel3.Location = new Point(1, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 470);
            panel3.TabIndex = 1;
            // 
            // btnMyprofile
            // 
            btnMyprofile.FlatStyle = FlatStyle.Popup;
            btnMyprofile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMyprofile.ForeColor = Color.Fuchsia;
            btnMyprofile.Location = new Point(4, 3);
            btnMyprofile.Name = "btnMyprofile";
            btnMyprofile.Size = new Size(272, 59);
            btnMyprofile.TabIndex = 1;
            btnMyprofile.Text = "MY PROFILE";
            btnMyprofile.UseVisualStyleBackColor = true;
            btnMyprofile.Click += btnMyprofile_Click;
            // 
            // btnTransportJob
            // 
            btnTransportJob.FlatStyle = FlatStyle.Popup;
            btnTransportJob.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTransportJob.ForeColor = Color.White;
            btnTransportJob.Location = new Point(2, 118);
            btnTransportJob.Name = "btnTransportJob";
            btnTransportJob.Size = new Size(273, 59);
            btnTransportJob.TabIndex = 13;
            btnTransportJob.Text = "TRANSPORT JOB REQUEST";
            btnTransportJob.UseVisualStyleBackColor = true;
            btnTransportJob.Click += btnTransportJob_Click;
            // 
            // btnProductSelection
            // 
            btnProductSelection.FlatStyle = FlatStyle.Popup;
            btnProductSelection.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnProductSelection.ForeColor = Color.White;
            btnProductSelection.Location = new Point(3, 176);
            btnProductSelection.Name = "btnProductSelection";
            btnProductSelection.Size = new Size(273, 59);
            btnProductSelection.TabIndex = 12;
            btnProductSelection.Text = "PRODUCT SELECTION";
            btnProductSelection.UseVisualStyleBackColor = true;
            btnProductSelection.Click += btnProductSelection_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.Cyan;
            btnLogout.Location = new Point(3, 406);
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
            btnJobStatus.Location = new Point(3, 289);
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
            btnLoadDetails.Location = new Point(3, 234);
            btnLoadDetails.Name = "btnLoadDetails";
            btnLoadDetails.Size = new Size(273, 59);
            btnLoadDetails.TabIndex = 6;
            btnLoadDetails.Text = "LOAD DETAILS";
            btnLoadDetails.UseVisualStyleBackColor = true;
            btnLoadDetails.Click += btnLoadDetails_Click;
            // 
            // btnViewTransportJob
            // 
            btnViewTransportJob.FlatStyle = FlatStyle.Popup;
            btnViewTransportJob.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewTransportJob.ForeColor = Color.White;
            btnViewTransportJob.Location = new Point(2, 60);
            btnViewTransportJob.Name = "btnViewTransportJob";
            btnViewTransportJob.Size = new Size(273, 59);
            btnViewTransportJob.TabIndex = 5;
            btnViewTransportJob.TabStop = false;
            btnViewTransportJob.Text = "VIEW TRANSPORTJOB";
            btnViewTransportJob.UseVisualStyleBackColor = true;
            btnViewTransportJob.Click += btnViewTransportJob_Click;
            // 
            // lblNotificationsCount
            // 
            lblNotificationsCount.AutoSize = true;
            lblNotificationsCount.BackColor = Color.Red;
            lblNotificationsCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNotificationsCount.ForeColor = Color.White;
            lblNotificationsCount.Location = new Point(701, 18);
            lblNotificationsCount.Name = "lblNotificationsCount";
            lblNotificationsCount.Size = new Size(18, 20);
            lblNotificationsCount.TabIndex = 202;
            lblNotificationsCount.Text = "0";
            // 
            // btnNotification
            // 
            btnNotification.BackgroundImage = (Image)resources.GetObject("btnNotification.BackgroundImage");
            btnNotification.BackgroundImageLayout = ImageLayout.Zoom;
            btnNotification.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotification.Location = new Point(678, 18);
            btnNotification.Name = "btnNotification";
            btnNotification.Size = new Size(42, 38);
            btnNotification.TabIndex = 201;
            btnNotification.UseVisualStyleBackColor = true;
            btnNotification.Click += btnNotification_Click;
            // 
            // DashboardCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1041, 536);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "DashboardCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardCustomer";
            Load += DashboardCustomer_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DashboardIcon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private PictureBox DashboardIcon;
        private Label HomeDashboard;
        private Label Dashboard;
        private Panel panel1;
        private Label CustomerDashboard;
        private Panel panel5;
        private Label eShift;
        private PictureBox Logo;
        private Panel panel2;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private RichTextBox rtbAddress;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Label Address;
        private Label Phone;
        private Label Email;
        private Button btnUpdate;
        private Label label1;
        private Panel panel3;
        private Button btnLogout;
        private Button btnJobStatus;
        private Button btnLoadDetails;
        private Button btnViewTransportJob;
        private Panel panel9;
        private TextBox txtName;
        private Label label2;
        private Button btnProductSelection;
        private Button btnTransportJob;
        private Button btnMyprofile;
        private Label lblNotificationsCount;
        private Button btnNotification;
    }
}