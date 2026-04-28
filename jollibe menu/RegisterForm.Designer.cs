namespace jollibe_menu
{
    partial class RegisterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            panel1 = new Panel();
            label1 = new Label();
            txtLname = new TextBox();
            label4 = new Label();
            lblFullName = new Label();
            txtFname = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            btnRegister = new Button();
            linkToLogin = new LinkLabel();
            labelTitle = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtLname);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblFullName);
            panel1.Controls.Add(txtFname);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(lblRole);
            panel1.Controls.Add(cmbRole);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(linkToLogin);
            panel1.Location = new Point(477, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 426);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(22, 118);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 17;
            label1.Text = "Last Name";
            // 
            // txtLname
            // 
            txtLname.Location = new Point(23, 144);
            txtLname.Name = "txtLname";
            txtLname.PlaceholderText = "Last name";
            txtLname.Size = new Size(620, 27);
            txtLname.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(344, 316);
            label4.Name = "label4";
            label4.Size = new Size(183, 20);
            label4.TabIndex = 15;
            label4.Text = "Already Have an Account?";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.BackColor = Color.Transparent;
            lblFullName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblFullName.ForeColor = SystemColors.ButtonHighlight;
            lblFullName.Location = new Point(24, 62);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(93, 23);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "First Name";
            lblFullName.Click += lblFullName_Click;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(22, 88);
            txtFname.Name = "txtFname";
            txtFname.PlaceholderText = "First name";
            txtFname.Size = new Size(620, 27);
            txtFname.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblEmail.ForeColor = SystemColors.ButtonHighlight;
            lblEmail.Location = new Point(23, 174);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 23);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(23, 200);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(620, 27);
            txtEmail.TabIndex = 4;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblUsername.ForeColor = SystemColors.ButtonHighlight;
            lblUsername.Location = new Point(23, 230);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 23);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(24, 256);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(300, 27);
            txtUsername.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblPassword.ForeColor = SystemColors.ButtonHighlight;
            lblPassword.Location = new Point(344, 230);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 23);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(344, 256);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(300, 27);
            txtPassword.TabIndex = 8;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.Transparent;
            lblRole.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblRole.ForeColor = SystemColors.ButtonHighlight;
            lblRole.Location = new Point(24, 290);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(44, 23);
            lblRole.TabIndex = 11;
            lblRole.Text = "Role";
            lblRole.Click += lblRole_Click;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Employee", "Admin" });
            cmbRole.Location = new Point(24, 316);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(300, 28);
            cmbRole.TabIndex = 12;
            cmbRole.Text = "--SELECT--";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.RoyalBlue;
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRegister.ForeColor = SystemColors.ButtonHighlight;
            btnRegister.Location = new Point(24, 368);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 40);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // linkToLogin
            // 
            linkToLogin.AutoSize = true;
            linkToLogin.BackColor = Color.Transparent;
            linkToLogin.LinkColor = Color.White;
            linkToLogin.Location = new Point(533, 316);
            linkToLogin.Name = "linkToLogin";
            linkToLogin.Size = new Size(51, 20);
            linkToLogin.TabIndex = 14;
            linkToLogin.TabStop = true;
            linkToLogin.Text = "LOGIN";
            linkToLogin.LinkClicked += linkToLogin_LinkClicked;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            labelTitle.ForeColor = SystemColors.ButtonHighlight;
            labelTitle.Location = new Point(658, 50);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(203, 54);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "REGISTER";
            labelTitle.Click += labelTitle_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1320, 620);
            Controls.Add(panel1);
            Controls.Add(labelTitle);
            Name = "RegisterForm";
            Text = "Register";
            Load += RegisterForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelTitle;
        private Label lblFullName;
        private TextBox txtFname;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblRole;
        private ComboBox cmbRole;
        private Button btnRegister;
        private LinkLabel linkToLogin;
        private Label label4;
        private Label label1;
        private TextBox txtLname;
    }
}