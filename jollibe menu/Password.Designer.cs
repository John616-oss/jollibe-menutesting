namespace jollibe_menu
{
    partial class Password
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
            txtEmail = new TextBox();
            txtCode = new TextBox();
            btnSend = new Button();
            btnConfirm = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(298, 215);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter Email";
            txtEmail.Size = new Size(477, 27);
            txtEmail.TabIndex = 0;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(298, 313);
            txtCode.Name = "txtCode";
            txtCode.PlaceholderText = "Type The Code";
            txtCode.Size = new Size(477, 27);
            txtCode.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.White;
            btnSend.FlatStyle = FlatStyle.Popup;
            btnSend.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSend.ForeColor = Color.Red;
            btnSend.Location = new Point(781, 205);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(139, 37);
            btnSend.TabIndex = 2;
            btnSend.Text = "SEND CODE";
            btnSend.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.White;
            btnConfirm.FlatStyle = FlatStyle.Popup;
            btnConfirm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.Red;
            btnConfirm.Location = new Point(781, 301);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(139, 39);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "CONFIRM";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(374, 74);
            label1.Name = "label1";
            label1.Size = new Size(520, 50);
            label1.TabIndex = 4;
            label1.Text = "RECOVERY ACCOUNT USER";
            // 
            // Password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1236, 621);
            Controls.Add(label1);
            Controls.Add(btnConfirm);
            Controls.Add(btnSend);
            Controls.Add(txtCode);
            Controls.Add(txtEmail);
            Name = "Password";
            Text = "Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtCode;
        private Button btnSend;
        private Button btnConfirm;
        private Label label1;
    }
}