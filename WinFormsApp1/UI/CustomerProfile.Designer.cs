namespace WinFormsApp1.UI
{
    partial class CustomerProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerProfile));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label8 = new Label();
            panel9 = new Panel();
            txtUsername = new TextBox();
            chkShowPassword = new CheckBox();
            btnCancel = new Button();
            label7 = new Label();
            label6 = new Label();
            panel8 = new Panel();
            txtConfirmPassword = new TextBox();
            panel7 = new Panel();
            txtPassword = new TextBox();
            btnRegister = new Button();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            rtbAddress = new RichTextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            Email = new Label();
            FullName = new Label();
            panel2 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(chkShowPassword);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(rtbAddress);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Email);
            panel1.Controls.Add(FullName);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(21, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(595, 666);
            panel1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label8.ForeColor = Color.DarkBlue;
            label8.Location = new Point(88, 347);
            label8.Name = "label8";
            label8.Size = new Size(97, 25);
            label8.TabIndex = 28;
            label8.Text = "Username";
            // 
            // panel9
            // 
            panel9.BackColor = Color.DarkBlue;
            panel9.Location = new Point(209, 375);
            panel9.Name = "panel9";
            panel9.Size = new Size(281, 4);
            panel9.TabIndex = 27;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(209, 348);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(281, 27);
            txtUsername.TabIndex = 26;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.ForeColor = Color.DarkBlue;
            chkShowPassword.Location = new Point(212, 433);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(132, 24);
            chkShowPassword.TabIndex = 25;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkBlue;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(89, 600);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(410, 39);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.ForeColor = Color.DarkBlue;
            label7.Location = new Point(88, 477);
            label7.Name = "label7";
            label7.Size = new Size(165, 25);
            label7.TabIndex = 23;
            label7.Text = "Confirm Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(88, 396);
            label6.Name = "label6";
            label6.Size = new Size(92, 25);
            label6.TabIndex = 22;
            label6.Text = "Password";
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkBlue;
            panel8.Location = new Point(271, 500);
            panel8.Name = "panel8";
            panel8.Size = new Size(220, 4);
            panel8.TabIndex = 21;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Location = new Point(271, 474);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(220, 27);
            txtConfirmPassword.TabIndex = 20;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkBlue;
            panel7.Location = new Point(209, 424);
            panel7.Name = "panel7";
            panel7.Size = new Size(281, 4);
            panel7.TabIndex = 19;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(209, 397);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(281, 27);
            txtPassword.TabIndex = 18;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkBlue;
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(89, 543);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(410, 39);
            btnRegister.TabIndex = 15;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkBlue;
            panel6.Location = new Point(209, 323);
            panel6.Name = "panel6";
            panel6.Size = new Size(285, 4);
            panel6.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkBlue;
            panel5.Location = new Point(209, 235);
            panel5.Name = "panel5";
            panel5.Size = new Size(281, 4);
            panel5.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkBlue;
            panel4.Location = new Point(209, 187);
            panel4.Name = "panel4";
            panel4.Size = new Size(282, 4);
            panel4.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkBlue;
            panel3.Location = new Point(209, 134);
            panel3.Name = "panel3";
            panel3.Size = new Size(281, 4);
            panel3.TabIndex = 11;
            // 
            // rtbAddress
            // 
            rtbAddress.BorderStyle = BorderStyle.FixedSingle;
            rtbAddress.Location = new Point(209, 264);
            rtbAddress.Name = "rtbAddress";
            rtbAddress.Size = new Size(285, 63);
            rtbAddress.TabIndex = 10;
            rtbAddress.Text = "";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Location = new Point(209, 208);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(281, 27);
            txtPhone.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(209, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(281, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Location = new Point(209, 108);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(281, 27);
            txtFullName.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(89, 264);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 5;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(88, 210);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 4;
            label4.Text = "Phone";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            Email.ForeColor = Color.DarkBlue;
            Email.Location = new Point(88, 159);
            Email.Name = "Email";
            Email.Size = new Size(58, 25);
            Email.TabIndex = 3;
            Email.Text = "Email";
            // 
            // FullName
            // 
            FullName.AutoSize = true;
            FullName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            FullName.ForeColor = Color.DarkBlue;
            FullName.Location = new Point(88, 106);
            FullName.Name = "FullName";
            FullName.Size = new Size(97, 25);
            FullName.TabIndex = 2;
            FullName.Text = "Full Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(873, 78);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(115, 17);
            label1.Name = "label1";
            label1.Size = new Size(378, 46);
            label1.TabIndex = 1;
            label1.Text = "Customer Registration";
            // 
            // CustomerProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(638, 699);
            Controls.Add(panel1);
            Name = "CustomerProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerProfile";
            Load += CustomerProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label Email;
        private Label FullName;
        private Label label1;
        private RichTextBox rtbAddress;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtFullName;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Button btnRegister;
        private Label label7;
        private Label label6;
        private Panel panel8;
        private TextBox txtConfirmPassword;
        private Panel panel7;
        private TextBox txtPassword;
        private Button btnCancel;
        private CheckBox chkShowPassword;
        private Label label8;
        private Panel panel9;
        private TextBox txtUsername;
    }
}