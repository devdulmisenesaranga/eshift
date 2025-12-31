namespace WinFormsApp1.UI
{
    partial class CustomerProductSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerProductSelection));
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
            btnTransportJobRequest = new Button();
            panel1 = new Panel();
            lblNotificationsCount = new Label();
            btnNotification = new Button();
            CustomerDashboard = new Label();
            panel2 = new Panel();
            label4 = new Label();
            panel11 = new Panel();
            nudMaxWeight = new NumericUpDown();
            label3 = new Label();
            btnFilter = new Button();
            panel6 = new Panel();
            nudMinWeight = new NumericUpDown();
            LoadDetailsList = new Label();
            dgvLoads = new DataGridView();
            btnAddLoad = new Button();
            panel10 = new Panel();
            nudVolume = new NumericUpDown();
            panel9 = new Panel();
            nudWeight = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            cmbJob = new ComboBox();
            panel8 = new Panel();
            cmbProduct = new ComboBox();
            panel7 = new Panel();
            SelectProduct = new Label();
            SelectJobID = new Label();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DashboardIcon).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaxWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoads).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(Logo);
            panel5.Controls.Add(eShift);
            panel5.Location = new Point(1, 0);
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
            panel4.Location = new Point(279, 71);
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
            TransportJobDetails.Size = new Size(161, 20);
            TransportJobDetails.TabIndex = 0;
            TransportJobDetails.Text = "PRODUCT SELECTION";
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
            panel3.Location = new Point(1, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 488);
            panel3.TabIndex = 12;
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
            btnProductSelection.ForeColor = Color.Fuchsia;
            btnProductSelection.Location = new Point(3, 177);
            btnProductSelection.Name = "btnProductSelection";
            btnProductSelection.Size = new Size(273, 59);
            btnProductSelection.TabIndex = 5;
            btnProductSelection.Text = "PRODUCT SELECTION";
            btnProductSelection.UseVisualStyleBackColor = true;
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
            // btnTransportJobRequest
            // 
            btnTransportJobRequest.FlatStyle = FlatStyle.Popup;
            btnTransportJobRequest.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTransportJobRequest.ForeColor = Color.White;
            btnTransportJobRequest.Location = new Point(2, 119);
            btnTransportJobRequest.Name = "btnTransportJobRequest";
            btnTransportJobRequest.Size = new Size(273, 59);
            btnTransportJobRequest.TabIndex = 12;
            btnTransportJobRequest.Text = "TRANSPORT JOB REQUEST";
            btnTransportJobRequest.UseVisualStyleBackColor = true;
            btnTransportJobRequest.Click += btnTransportJobRequest_Click;
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
            panel1.Size = new Size(896, 72);
            panel1.TabIndex = 11;
            // 
            // lblNotificationsCount
            // 
            lblNotificationsCount.AutoSize = true;
            lblNotificationsCount.BackColor = Color.Red;
            lblNotificationsCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNotificationsCount.ForeColor = Color.White;
            lblNotificationsCount.Location = new Point(831, 18);
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
            btnNotification.Location = new Point(808, 18);
            btnNotification.Name = "btnNotification";
            btnNotification.Size = new Size(42, 38);
            btnNotification.TabIndex = 5;
            btnNotification.UseVisualStyleBackColor = true;
            btnNotification.Click += btnNotification_Click;
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
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel11);
            panel2.Controls.Add(nudMaxWeight);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnFilter);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(nudMinWeight);
            panel2.Controls.Add(LoadDetailsList);
            panel2.Controls.Add(dgvLoads);
            panel2.Controls.Add(btnAddLoad);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(nudVolume);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(nudWeight);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cmbJob);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(cmbProduct);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(SelectProduct);
            panel2.Controls.Add(SelectJobID);
            panel2.Location = new Point(280, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(895, 432);
            panel2.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(560, 71);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 72;
            label4.Text = "Max Weight";
            // 
            // panel11
            // 
            panel11.BackColor = Color.DarkBlue;
            panel11.Location = new Point(563, 125);
            panel11.Name = "panel11";
            panel11.Size = new Size(106, 4);
            panel11.TabIndex = 71;
            // 
            // nudMaxWeight
            // 
            nudMaxWeight.Location = new Point(564, 98);
            nudMaxWeight.Name = "nudMaxWeight";
            nudMaxWeight.Size = new Size(105, 27);
            nudMaxWeight.TabIndex = 70;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(435, 72);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 69;
            label3.Text = "Min Weight";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.DarkBlue;
            btnFilter.FlatStyle = FlatStyle.Popup;
            btnFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(736, 92);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(133, 38);
            btnFilter.TabIndex = 68;
            btnFilter.Text = "FILTER";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkBlue;
            panel6.Location = new Point(438, 125);
            panel6.Name = "panel6";
            panel6.Size = new Size(116, 4);
            panel6.TabIndex = 67;
            // 
            // nudMinWeight
            // 
            nudMinWeight.Location = new Point(439, 98);
            nudMinWeight.Name = "nudMinWeight";
            nudMinWeight.Size = new Size(115, 27);
            nudMinWeight.TabIndex = 66;
            // 
            // LoadDetailsList
            // 
            LoadDetailsList.AutoSize = true;
            LoadDetailsList.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            LoadDetailsList.ForeColor = Color.DarkBlue;
            LoadDetailsList.Location = new Point(527, 14);
            LoadDetailsList.Name = "LoadDetailsList";
            LoadDetailsList.Size = new Size(271, 38);
            LoadDetailsList.TabIndex = 65;
            LoadDetailsList.Text = "Product Details List";
            // 
            // dgvLoads
            // 
            dgvLoads.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoads.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoads.Location = new Point(438, 148);
            dgvLoads.Name = "dgvLoads";
            dgvLoads.RowHeadersWidth = 51;
            dgvLoads.Size = new Size(432, 269);
            dgvLoads.TabIndex = 64;
            dgvLoads.CellContentClick += dgvLoads_CellContentClick;
            // 
            // btnAddLoad
            // 
            btnAddLoad.BackColor = Color.DarkBlue;
            btnAddLoad.FlatStyle = FlatStyle.Popup;
            btnAddLoad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddLoad.ForeColor = Color.White;
            btnAddLoad.Location = new Point(200, 333);
            btnAddLoad.Name = "btnAddLoad";
            btnAddLoad.Size = new Size(133, 38);
            btnAddLoad.TabIndex = 63;
            btnAddLoad.Text = "ADD LOAD";
            btnAddLoad.UseVisualStyleBackColor = false;
            btnAddLoad.Click += btnAddLoad_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.DarkBlue;
            panel10.Location = new Point(200, 235);
            panel10.Name = "panel10";
            panel10.Size = new Size(203, 4);
            panel10.TabIndex = 62;
            // 
            // nudVolume
            // 
            nudVolume.Location = new Point(201, 208);
            nudVolume.Name = "nudVolume";
            nudVolume.Size = new Size(202, 27);
            nudVolume.TabIndex = 61;
            // 
            // panel9
            // 
            panel9.BackColor = Color.DarkBlue;
            panel9.Location = new Point(200, 184);
            panel9.Name = "panel9";
            panel9.Size = new Size(203, 4);
            panel9.TabIndex = 60;
            // 
            // nudWeight
            // 
            nudWeight.Location = new Point(201, 157);
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new Size(202, 27);
            nudWeight.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(51, 211);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 58;
            label2.Text = "Volume";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(51, 159);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 57;
            label1.Text = "Weight";
            // 
            // cmbJob
            // 
            cmbJob.FormattingEnabled = true;
            cmbJob.Location = new Point(201, 49);
            cmbJob.Name = "cmbJob";
            cmbJob.Size = new Size(202, 28);
            cmbJob.TabIndex = 54;
            cmbJob.SelectedIndexChanged += cmbJob_SelectedIndexChanged;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkBlue;
            panel8.Location = new Point(201, 76);
            panel8.Name = "panel8";
            panel8.Size = new Size(202, 4);
            panel8.TabIndex = 53;
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Items.AddRange(new object[] { "Tv", "Sofa", "Cupboard", "Bookshelf", "Wardrobe", "Chair", "Table", "Washine machine", "Fridge", "Refrigerator", "Generator", "Stand Fan", "Bed" });
            cmbProduct.Location = new Point(201, 100);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(202, 28);
            cmbProduct.TabIndex = 52;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkBlue;
            panel7.Location = new Point(201, 127);
            panel7.Name = "panel7";
            panel7.Size = new Size(202, 4);
            panel7.TabIndex = 51;
            // 
            // SelectProduct
            // 
            SelectProduct.AutoSize = true;
            SelectProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            SelectProduct.ForeColor = Color.DarkBlue;
            SelectProduct.Location = new Point(50, 106);
            SelectProduct.Name = "SelectProduct";
            SelectProduct.Size = new Size(135, 25);
            SelectProduct.TabIndex = 49;
            SelectProduct.Text = "Select Product";
            // 
            // SelectJobID
            // 
            SelectJobID.AutoSize = true;
            SelectJobID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            SelectJobID.ForeColor = Color.DarkBlue;
            SelectJobID.Location = new Point(50, 55);
            SelectJobID.Name = "SelectJobID";
            SelectJobID.Size = new Size(122, 25);
            SelectJobID.TabIndex = 48;
            SelectJobID.Text = "Select Job ID";
            // 
            // CustomerProductSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 554);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "CustomerProductSelection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerProductSelection";
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
            ((System.ComponentModel.ISupportInitialize)nudMaxWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoads).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
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
        private Button btnProductSelection;
        private Button btnMyprofile;
        private Button btnLogout;
        private Button btnJobStatus;
        private Button btnLoadDetails;
        private Button btnTransportJobRequest;
        private Panel panel1;
        private Label CustomerDashboard;
        private Panel panel2;
        private Button btnAddLoad;
        private Panel panel10;
        private NumericUpDown nudVolume;
        private Panel panel9;
        private NumericUpDown nudWeight;
        private Label label2;
        private Label label1;
        private ComboBox cmbJob;
        private Panel panel8;
        private ComboBox cmbProduct;
        private Panel panel7;
        private Label SelectProduct;
        private Label SelectJobID;
        private DataGridView dgvLoads;
        private Label LoadDetailsList;
        private Button btnViewTransportJob;
        private Label lblNotificationsCount;
        private Button btnNotification;
        private Button btnFilter;
        private Panel panel6;
        private NumericUpDown nudMinWeight;
        private Label label4;
        private Panel panel11;
        private NumericUpDown nudMaxWeight;
        private Label label3;
    }
}