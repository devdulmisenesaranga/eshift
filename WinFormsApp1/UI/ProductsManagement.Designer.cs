namespace WinFormsApp1.UI
{
    partial class ProductsManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsManagement));
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
            btnDeleteProduct = new Button();
            btnUpdateProduct = new Button();
            btnAddProduct = new Button();
            chkFragile = new CheckBox();
            panel6 = new Panel();
            rtbDescription = new RichTextBox();
            panel9 = new Panel();
            txtProductName = new TextBox();
            ProductDescription = new Label();
            ProductName = new Label();
            ShowAllProducts = new Label();
            dgvProducts = new DataGridView();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(-1, 0);
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
            panel4.Location = new Point(277, 71);
            panel4.Name = "panel4";
            panel4.Size = new Size(1007, 60);
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
            label2.Size = new Size(227, 23);
            label2.TabIndex = 0;
            label2.Text = "PRODUCTS MANAGEMENT";
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
            panel3.Location = new Point(-1, 72);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 620);
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
            btnLogout.Location = new Point(5, 553);
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
            btnProductManagement.ForeColor = Color.Fuchsia;
            btnProductManagement.Location = new Point(3, 172);
            btnProductManagement.Name = "btnProductManagement";
            btnProductManagement.Size = new Size(273, 59);
            btnProductManagement.TabIndex = 4;
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
            btnCustomerDetails.TabIndex = 7;
            btnCustomerDetails.Text = "CUSTOMER DETAILS";
            btnCustomerDetails.UseVisualStyleBackColor = true;
            btnCustomerDetails.Click += btnCustomerDetails_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label1);
            panel1.Location = new Point(277, -1);
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
            panel2.Controls.Add(btnDeleteProduct);
            panel2.Controls.Add(btnUpdateProduct);
            panel2.Controls.Add(btnAddProduct);
            panel2.Controls.Add(chkFragile);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(rtbDescription);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(txtProductName);
            panel2.Controls.Add(ProductDescription);
            panel2.Controls.Add(ProductName);
            panel2.Controls.Add(ShowAllProducts);
            panel2.Controls.Add(dgvProducts);
            panel2.Location = new Point(278, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 562);
            panel2.TabIndex = 16;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.DarkBlue;
            btnDeleteProduct.FlatStyle = FlatStyle.Popup;
            btnDeleteProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteProduct.ForeColor = Color.White;
            btnDeleteProduct.Location = new Point(827, 495);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(133, 38);
            btnDeleteProduct.TabIndex = 73;
            btnDeleteProduct.Text = "DELETE";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.BackColor = Color.DarkBlue;
            btnUpdateProduct.FlatStyle = FlatStyle.Popup;
            btnUpdateProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateProduct.ForeColor = Color.White;
            btnUpdateProduct.Location = new Point(624, 495);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(133, 38);
            btnUpdateProduct.TabIndex = 72;
            btnUpdateProduct.Text = "UPDATE";
            btnUpdateProduct.UseVisualStyleBackColor = false;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.DarkBlue;
            btnAddProduct.FlatStyle = FlatStyle.Popup;
            btnAddProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(420, 497);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(133, 38);
            btnAddProduct.TabIndex = 71;
            btnAddProduct.Text = "ADD NEW";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // chkFragile
            // 
            chkFragile.AutoSize = true;
            chkFragile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkFragile.ForeColor = Color.DarkBlue;
            chkFragile.Location = new Point(271, 465);
            chkFragile.Name = "chkFragile";
            chkFragile.Size = new Size(78, 24);
            chkFragile.TabIndex = 70;
            chkFragile.Text = "Fragile";
            chkFragile.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkBlue;
            panel6.Location = new Point(271, 435);
            panel6.Name = "panel6";
            panel6.Size = new Size(248, 4);
            panel6.TabIndex = 69;
            // 
            // rtbDescription
            // 
            rtbDescription.BorderStyle = BorderStyle.FixedSingle;
            rtbDescription.Location = new Point(271, 351);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(248, 84);
            rtbDescription.TabIndex = 68;
            rtbDescription.Text = "";
            // 
            // panel9
            // 
            panel9.BackColor = Color.DarkBlue;
            panel9.Location = new Point(271, 310);
            panel9.Name = "panel9";
            panel9.Size = new Size(248, 4);
            panel9.TabIndex = 66;
            // 
            // txtProductName
            // 
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Location = new Point(271, 284);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(248, 27);
            txtProductName.TabIndex = 64;
            // 
            // ProductDescription
            // 
            ProductDescription.AutoSize = true;
            ProductDescription.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            ProductDescription.ForeColor = Color.DarkBlue;
            ProductDescription.Location = new Point(79, 351);
            ProductDescription.Name = "ProductDescription";
            ProductDescription.Size = new Size(181, 25);
            ProductDescription.TabIndex = 63;
            ProductDescription.Text = "Product Description";
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            ProductName.ForeColor = Color.DarkBlue;
            ProductName.Location = new Point(79, 287);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(134, 25);
            ProductName.TabIndex = 62;
            ProductName.Text = "Product Name";
            // 
            // ShowAllProducts
            // 
            ShowAllProducts.AutoSize = true;
            ShowAllProducts.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            ShowAllProducts.ForeColor = Color.DarkBlue;
            ShowAllProducts.Location = new Point(365, 15);
            ShowAllProducts.Name = "ShowAllProducts";
            ShowAllProducts.Size = new Size(210, 31);
            ShowAllProducts.TabIndex = 51;
            ShowAllProducts.Text = "Show All Products";
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(45, 60);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(919, 196);
            dgvProducts.TabIndex = 50;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // ProductsManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 691);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "ProductsManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductsManagement";
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
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
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
        private DataGridView dgvProducts;
        private Label ShowAllProducts;
        private Panel panel9;
        private TextBox txtProductName;
        private Label ProductDescription;
        private Label ProductName;
        private Panel panel6;
        private RichTextBox rtbDescription;
        private CheckBox chkFragile;
        private Button btnDeleteProduct;
        private Button btnUpdateProduct;
        private Button btnAddProduct;
    }
}