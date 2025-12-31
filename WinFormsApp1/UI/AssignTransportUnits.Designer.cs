namespace WinFormsApp1.UI
{
    partial class AssignTransportUnits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignTransportUnits));
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
            btnAssignUnit = new Button();
            cmbTransportUnit = new ComboBox();
            panel6 = new Panel();
            AvailableTransportUnits = new Label();
            YourTransportJobs = new Label();
            dgvLoads = new DataGridView();
            cmbJobs = new ComboBox();
            panel8 = new Panel();
            SelectJobID = new Label();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoads).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(-1, -1);
            panel5.Name = "panel5";
            panel5.Size = new Size(278, 72);
            panel5.TabIndex = 15;
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
            panel4.Location = new Point(277, 70);
            panel4.Name = "panel4";
            panel4.Size = new Size(982, 60);
            panel4.TabIndex = 14;
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
            label2.Size = new Size(232, 23);
            label2.TabIndex = 0;
            label2.Text = "ASSIGN TRANSPORT UNITS";
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
            panel3.Location = new Point(-1, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 597);
            panel3.TabIndex = 13;
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
            btnAssignTransportUnits.ForeColor = Color.Fuchsia;
            btnAssignTransportUnits.Location = new Point(3, 117);
            btnAssignTransportUnits.Name = "btnAssignTransportUnits";
            btnAssignTransportUnits.Size = new Size(273, 59);
            btnAssignTransportUnits.TabIndex = 4;
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
            btnCustomerDetails.TabIndex = 6;
            btnCustomerDetails.Text = "CUSTOMER DETAILS";
            btnCustomerDetails.UseVisualStyleBackColor = true;
            btnCustomerDetails.Click += btnCustomerDetails_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label1);
            panel1.Location = new Point(277, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1004, 132);
            panel1.TabIndex = 12;
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
            panel2.Controls.Add(btnAssignUnit);
            panel2.Controls.Add(cmbTransportUnit);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(AvailableTransportUnits);
            panel2.Controls.Add(YourTransportJobs);
            panel2.Controls.Add(dgvLoads);
            panel2.Controls.Add(cmbJobs);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(SelectJobID);
            panel2.Location = new Point(278, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(978, 539);
            panel2.TabIndex = 16;
            // 
            // btnAssignUnit
            // 
            btnAssignUnit.BackColor = Color.DarkBlue;
            btnAssignUnit.FlatStyle = FlatStyle.Popup;
            btnAssignUnit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAssignUnit.ForeColor = Color.White;
            btnAssignUnit.Location = new Point(588, 111);
            btnAssignUnit.Name = "btnAssignUnit";
            btnAssignUnit.Size = new Size(156, 38);
            btnAssignUnit.TabIndex = 54;
            btnAssignUnit.Text = "ASSIGN UNIT";
            btnAssignUnit.UseVisualStyleBackColor = false;
            btnAssignUnit.Click += btnAssignUnit_Click;
            // 
            // cmbTransportUnit
            // 
            cmbTransportUnit.FormattingEnabled = true;
            cmbTransportUnit.Location = new Point(306, 110);
            cmbTransportUnit.Name = "cmbTransportUnit";
            cmbTransportUnit.Size = new Size(202, 28);
            cmbTransportUnit.TabIndex = 53;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkBlue;
            panel6.Location = new Point(306, 137);
            panel6.Name = "panel6";
            panel6.Size = new Size(202, 4);
            panel6.TabIndex = 52;
            // 
            // AvailableTransportUnits
            // 
            AvailableTransportUnits.AutoSize = true;
            AvailableTransportUnits.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            AvailableTransportUnits.ForeColor = Color.DarkBlue;
            AvailableTransportUnits.Location = new Point(74, 116);
            AvailableTransportUnits.Name = "AvailableTransportUnits";
            AvailableTransportUnits.Size = new Size(223, 25);
            AvailableTransportUnits.TabIndex = 51;
            AvailableTransportUnits.Text = "Available TransportUnits";
            // 
            // YourTransportJobs
            // 
            YourTransportJobs.AutoSize = true;
            YourTransportJobs.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            YourTransportJobs.ForeColor = Color.DarkBlue;
            YourTransportJobs.Location = new Point(344, 196);
            YourTransportJobs.Name = "YourTransportJobs";
            YourTransportJobs.Size = new Size(327, 38);
            YourTransportJobs.TabIndex = 50;
            YourTransportJobs.Text = "Loads For Selected Jobs";
            // 
            // dgvLoads
            // 
            dgvLoads.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoads.BackgroundColor = Color.White;
            dgvLoads.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoads.Location = new Point(38, 249);
            dgvLoads.Name = "dgvLoads";
            dgvLoads.RowHeadersWidth = 51;
            dgvLoads.Size = new Size(897, 269);
            dgvLoads.TabIndex = 49;
            dgvLoads.CellClick += dgvLoads_CellClick;
            // 
            // cmbJobs
            // 
            cmbJobs.FormattingEnabled = true;
            cmbJobs.Location = new Point(306, 44);
            cmbJobs.Name = "cmbJobs";
            cmbJobs.Size = new Size(202, 28);
            cmbJobs.TabIndex = 41;
            cmbJobs.SelectedIndexChanged += cmbJobs_SelectedIndexChanged;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkBlue;
            panel8.Location = new Point(306, 71);
            panel8.Name = "panel8";
            panel8.Size = new Size(202, 4);
            panel8.TabIndex = 40;
            // 
            // SelectJobID
            // 
            SelectJobID.AutoSize = true;
            SelectJobID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            SelectJobID.ForeColor = Color.DarkBlue;
            SelectJobID.Location = new Point(74, 50);
            SelectJobID.Name = "SelectJobID";
            SelectJobID.Size = new Size(122, 25);
            SelectJobID.TabIndex = 39;
            SelectJobID.Text = "Select Job ID";
            // 
            // AssignTransportUnits
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 666);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "AssignTransportUnits";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssignTransportUnits";
            Load += AssignTransportUnits_Load;
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
            ((System.ComponentModel.ISupportInitialize)dgvLoads).EndInit();
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
        private ComboBox cmbJobs;
        private Panel panel8;
        private Label SelectJobID;
        private DataGridView dgvLoads;
        private Label YourTransportJobs;
        private ComboBox cmbTransportUnit;
        private Panel panel6;
        private Label AvailableTransportUnits;
        private Button btnAssignUnit;
    }
}