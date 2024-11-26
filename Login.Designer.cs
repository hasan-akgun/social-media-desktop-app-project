namespace social_media
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
            lblCreateAccount = new Label();
            txtDontHave = new Label();
            btnClear = new Button();
            btnLogin = new Button();
            chkPassword = new CheckBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtId = new TextBox();
            lblId = new Label();
            lblLogin = new Label();
            SuspendLayout();
            // 
            // lblCreateAccount
            // 
            lblCreateAccount.AutoSize = true;
            lblCreateAccount.Cursor = Cursors.Hand;
            lblCreateAccount.FlatStyle = FlatStyle.Flat;
            lblCreateAccount.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCreateAccount.ForeColor = Color.Navy;
            lblCreateAccount.Location = new Point(168, 531);
            lblCreateAccount.Margin = new Padding(20, 0, 3, 0);
            lblCreateAccount.Name = "lblCreateAccount";
            lblCreateAccount.Padding = new Padding(0, 10, 0, 0);
            lblCreateAccount.Size = new Size(145, 38);
            lblCreateAccount.TabIndex = 23;
            lblCreateAccount.Text = "Create Account";
            lblCreateAccount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDontHave
            // 
            txtDontHave.AutoSize = true;
            txtDontHave.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtDontHave.ForeColor = Color.CornflowerBlue;
            txtDontHave.Location = new Point(138, 493);
            txtDontHave.Margin = new Padding(20, 0, 3, 0);
            txtDontHave.Name = "txtDontHave";
            txtDontHave.Padding = new Padding(0, 10, 0, 0);
            txtDontHave.Size = new Size(216, 38);
            txtDontHave.TabIndex = 22;
            txtDontHave.Text = "Don't Have An Account";
            txtDontHave.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.WhiteSmoke;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 2;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Yu Gothic UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnClear.ForeColor = Color.Navy;
            btnClear.Location = new Point(119, 439);
            btnClear.Margin = new Padding(3, 10, 3, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(252, 51);
            btnClear.TabIndex = 21;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Navy;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Yu Gothic UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnLogin.ForeColor = Color.WhiteSmoke;
            btnLogin.Location = new Point(119, 375);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(252, 51);
            btnLogin.TabIndex = 20;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // chkPassword
            // 
            chkPassword.AutoSize = true;
            chkPassword.Cursor = Cursors.Hand;
            chkPassword.FlatStyle = FlatStyle.Flat;
            chkPassword.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chkPassword.ForeColor = Color.CornflowerBlue;
            chkPassword.Location = new Point(29, 300);
            chkPassword.Name = "chkPassword";
            chkPassword.Size = new Size(166, 32);
            chkPassword.TabIndex = 19;
            chkPassword.Text = "Show password";
            chkPassword.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10.8F);
            txtPassword.ForeColor = SystemColors.ControlText;
            txtPassword.Location = new Point(29, 263);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(342, 31);
            txtPassword.TabIndex = 16;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblPassword.ForeColor = Color.CornflowerBlue;
            lblPassword.Location = new Point(29, 222);
            lblPassword.Margin = new Padding(20, 10, 3, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(132, 38);
            lblPassword.TabIndex = 15;
            lblPassword.Text = "Password";
            lblPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            txtId.BackColor = Color.White;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Segoe UI", 10.8F);
            txtId.ForeColor = SystemColors.ControlText;
            txtId.Location = new Point(29, 182);
            txtId.Name = "txtId";
            txtId.Size = new Size(342, 31);
            txtId.TabIndex = 14;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblId.ForeColor = Color.CornflowerBlue;
            lblId.Location = new Point(29, 141);
            lblId.Margin = new Padding(20, 0, 3, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(44, 38);
            lblId.TabIndex = 13;
            lblId.Text = "ID";
            lblId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top;
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Yu Gothic UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLogin.ForeColor = Color.Navy;
            lblLogin.Location = new Point(164, 30);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(158, 60);
            lblLogin.TabIndex = 12;
            lblLogin.Text = "LOGIN";
            lblLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(486, 682);
            Controls.Add(lblCreateAccount);
            Controls.Add(txtDontHave);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Controls.Add(chkPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(lblLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCreateAccount;
        private Label txtDontHave;
        private Button btnClear;
        private Button btnLogin;
        private CheckBox chkPassword;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtId;
        private Label lblId;
        private Label lblLogin;
    }
}