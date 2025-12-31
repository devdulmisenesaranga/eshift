namespace WinFormsApp1.UI
{
    partial class ManageTransportJobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTransportJobs));
            panel5 = new Panel();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            btnManageAdmins = new Button();
            btnTransportUnitsManagement = new Button();
            btnLogout = new Button();
            btnGenerateReports = new Button();
            btnProductManagement = new Button();
            btnAssignTransportUnits = new Button();
            btnManageTransportJobs = new Button();
            btnCustomerDetails = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            panel2 = new Panel();
            btnRefresh = new Button();
            btnDecline = new Button();
            btnAccept = new Button();
            dgvPendingJobs = new DataGridView();
            label5 = new Label();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendingJobs).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(0, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(278, 72);
            panel5.TabIndex = 11;
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
            panel3.Location = new Point(0, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 597);
            panel3.TabIndex = 9;
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
            btnManageTransportJobs.ForeColor = Color.Fuchsia;
            btnManageTransportJobs.Location = new Point(2, 59);
            btnManageTransportJobs.Name = "btnManageTransportJobs";
            btnManageTransportJobs.Size = new Size(273, 59);
            btnManageTransportJobs.TabIndex = 4;
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
            btnCustomerDetails.TabIndex = 5;
            btnCustomerDetails.Text = "CUSTOMER DETAILS";
            btnCustomerDetails.UseVisualStyleBackColor = true;
            btnCustomerDetails.Click += btnCustomerDetails_Click;
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
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label1);
            panel1.Location = new Point(278, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1004, 132);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(58, 16);
            label2.Name = "label2";
            label2.Size = new Size(236, 23);
            label2.TabIndex = 0;
            label2.Text = "MANAGE TRANSPORT JOBS";
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
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(278, 72);
            panel4.Name = "panel4";
            panel4.Size = new Size(1007, 60);
            panel4.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnDecline);
            panel2.Controls.Add(btnAccept);
            panel2.Controls.Add(dgvPendingJobs);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(279, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(1002, 537);
            panel2.TabIndex = 12;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DarkBlue;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(827, 466);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(133, 38);
            btnRefresh.TabIndex = 53;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDecline
            // 
            btnDecline.BackColor = Color.DarkBlue;
            btnDecline.FlatStyle = FlatStyle.Popup;
            btnDecline.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDecline.ForeColor = Color.White;
            btnDecline.Location = new Point(241, 466);
            btnDecline.Name = "btnDecline";
            btnDecline.Size = new Size(133, 38);
            btnDecline.TabIndex = 52;
            btnDecline.Text = "DECLINE";
            btnDecline.UseVisualStyleBackColor = false;
            btnDecline.Click += btnDecline_Click;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.DarkBlue;
            btnAccept.FlatStyle = FlatStyle.Popup;
            btnAccept.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(57, 466);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(133, 38);
            btnAccept.TabIndex = 51;
            btnAccept.Text = "ACCEPT";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // dgvPendingJobs
            // 
            dgvPendingJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPendingJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPendingJobs.Location = new Point(48, 80);
            dgvPendingJobs.Name = "dgvPendingJobs";
            dgvPendingJobs.RowHeadersWidth = 51;
            dgvPendingJobs.Size = new Size(916, 342);
            dgvPendingJobs.TabIndex = 29;
            dgvPendingJobs.DataBindingComplete += dgvPendingJobs_DataBindingComplete;
            dgvPendingJobs.RowPrePaint += dgvPendingJobs_RowPrePaint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(400, 25);
            label5.Name = "label5";
            label5.Size = new Size(231, 38);
            label5.TabIndex = 28;
            label5.Text = "Pending Job List";
            // 
            // ManageTransportJobs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 668);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "ManageTransportJobs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageTransportJobs";
            Load += ManageTransportJobs_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendingJobs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Label label4;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Button btnManageAdmins;
        private Button btnTransportUnitsManagement;
        private Button btnLogout;
        private Button btnGenerateReports;
        private Button btnProductManagement;
        private Button btnAssignTransportUnits;
        private Button btnManageTransportJobs;
        private Button btnCustomerDetails;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Panel panel2;
        private Label label5;
        private DataGridView dgvPendingJobs;
        private Button btnRefresh;
        private Button btnDecline;
        private Button btnAccept;
    }
}