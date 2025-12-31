namespace WinFormsApp1.UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            chkShowPassword = new CheckBox();
            cmbRole = new ComboBox();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            btnRegistration = new Button();
            label3 = new Label();
            Userlabel = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(chkShowPassword);
            panel1.Controls.Add(cmbRole);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnRegistration);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Userlabel);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Location = new Point(476, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 529);
            panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(116, 18);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(145, 91);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(53, 236);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 7.8F);
            chkShowPassword.ForeColor = Color.Blue;
            chkShowPassword.Location = new Point(49, 280);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(121, 21);
            chkShowPassword.TabIndex = 12;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // cmbRole
            // 
            cmbRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbRole.ForeColor = Color.FromArgb(128, 128, 255);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Customer", "Admin" });
            cmbRole.Location = new Point(52, 326);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(151, 28);
            cmbRole.TabIndex = 11;
            cmbRole.Text = "Select User Role";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(52, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 17);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Blue;
            panel3.Location = new Point(48, 263);
            panel3.Name = "panel3";
            panel3.Size = new Size(285, 5);
            panel3.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Location = new Point(47, 179);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 5);
            panel2.TabIndex = 7;
            // 
            // btnRegistration
            // 
            btnRegistration.BackColor = Color.Red;
            btnRegistration.FlatStyle = FlatStyle.Popup;
            btnRegistration.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegistration.ForeColor = Color.White;
            btnRegistration.Location = new Point(52, 446);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(281, 42);
            btnRegistration.TabIndex = 6;
            btnRegistration.Text = "REGISTRATION";
            btnRegistration.UseVisualStyleBackColor = false;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(47, 206);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // Userlabel
            // 
            Userlabel.AutoSize = true;
            Userlabel.BackColor = Color.Transparent;
            Userlabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Userlabel.ForeColor = Color.Blue;
            Userlabel.Location = new Point(47, 126);
            Userlabel.Name = "Userlabel";
            Userlabel.Size = new Size(89, 23);
            Userlabel.TabIndex = 4;
            Userlabel.Text = "Username";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(52, 393);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(281, 42);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtPassword.Location = new Point(48, 236);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(285, 27);
            txtPassword.TabIndex = 2;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Window;
            txtUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtUsername.Location = new Point(48, 152);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(285, 27);
            txtUsername.TabIndex = 1;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(37, 200);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(400, 294);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(61, 62);
            label4.Name = "label4";
            label4.Size = new Size(359, 50);
            label4.TabIndex = 1;
            label4.Text = "Welcome to e-Shift";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(46, 136);
            label5.Name = "label5";
            label5.Size = new Size(408, 25);
            label5.TabIndex = 2;
            label5.Text = "Your Trusted Household Goods Shifting Partner";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(877, 553);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label Userlabel;
        private Panel panel2;
        private Button btnRegistration;
        private Panel panel3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox cmbRole;
        private CheckBox chkShowPassword;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox4;
    }
}