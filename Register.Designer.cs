﻿namespace social_media
{
    partial class Register
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            getStarted = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtConfirm = new TextBox();
            lblConfirm = new Label();
            chkPassword = new CheckBox();
            btnRegister = new Button();
            btnClear = new Button();
            txtAlready = new Label();
            lblBackLogin = new Label();
            txtId = new TextBox();
            lblId = new Label();
            lblBeforeID = new Label();
            SuspendLayout();
            // 
            // getStarted
            // 
            getStarted.Anchor = AnchorStyles.Top;
            getStarted.AutoSize = true;
            getStarted.BackColor = Color.Transparent;
            getStarted.Font = new Font("Yu Gothic UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            getStarted.ForeColor = Color.Navy;
            getStarted.Location = new Point(119, 9);
            getStarted.Name = "getStarted";
            getStarted.Size = new Size(252, 60);
            getStarted.TabIndex = 0;
            getStarted.Text = "Get Started";
            getStarted.TextAlign = ContentAlignment.MiddleCenter;
            getStarted.Click += getStarted_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblUsername.ForeColor = Color.CornflowerBlue;
            lblUsername.Location = new Point(29, 141);
            lblUsername.Margin = new Padding(20, 0, 3, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(142, 38);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10.8F);
            txtUsername.ForeColor = SystemColors.ControlText;
            txtUsername.Location = new Point(29, 182);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(342, 31);
            txtUsername.TabIndex = 2;
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
            txtPassword.TabIndex = 4;
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
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            lblPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtConfirm
            // 
            txtConfirm.BackColor = Color.White;
            txtConfirm.BorderStyle = BorderStyle.FixedSingle;
            txtConfirm.Font = new Font("Segoe UI", 10.8F);
            txtConfirm.ForeColor = SystemColors.ControlText;
            txtConfirm.Location = new Point(29, 344);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(342, 31);
            txtConfirm.TabIndex = 6;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblConfirm.ForeColor = Color.CornflowerBlue;
            lblConfirm.Location = new Point(29, 303);
            lblConfirm.Margin = new Padding(20, 10, 3, 0);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(231, 38);
            lblConfirm.TabIndex = 5;
            lblConfirm.Text = "Confim password";
            lblConfirm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkPassword
            // 
            chkPassword.AutoSize = true;
            chkPassword.Cursor = Cursors.Hand;
            chkPassword.FlatStyle = FlatStyle.Flat;
            chkPassword.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chkPassword.ForeColor = Color.CornflowerBlue;
            chkPassword.Location = new Point(29, 381);
            chkPassword.Name = "chkPassword";
            chkPassword.Size = new Size(166, 32);
            chkPassword.TabIndex = 7;
            chkPassword.Text = "Show password";
            chkPassword.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Navy;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Yu Gothic UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRegister.ForeColor = Color.WhiteSmoke;
            btnRegister.Location = new Point(119, 456);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(252, 51);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += this.btnRegister_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.WhiteSmoke;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 2;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Yu Gothic UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnClear.ForeColor = Color.Navy;
            btnClear.Location = new Point(119, 520);
            btnClear.Margin = new Padding(3, 10, 3, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(252, 51);
            btnClear.TabIndex = 9;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // txtAlready
            // 
            txtAlready.AutoSize = true;
            txtAlready.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAlready.ForeColor = Color.CornflowerBlue;
            txtAlready.Location = new Point(130, 574);
            txtAlready.Margin = new Padding(20, 0, 3, 0);
            txtAlready.Name = "txtAlready";
            txtAlready.Padding = new Padding(0, 10, 0, 0);
            txtAlready.Size = new Size(234, 38);
            txtAlready.TabIndex = 10;
            txtAlready.Text = "Already Have An Account";
            txtAlready.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBackLogin
            // 
            lblBackLogin.AutoSize = true;
            lblBackLogin.Cursor = Cursors.Hand;
            lblBackLogin.FlatStyle = FlatStyle.Flat;
            lblBackLogin.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBackLogin.ForeColor = Color.Navy;
            lblBackLogin.Location = new Point(170, 612);
            lblBackLogin.Margin = new Padding(20, 0, 3, 0);
            lblBackLogin.Name = "lblBackLogin";
            lblBackLogin.Padding = new Padding(0, 10, 0, 0);
            lblBackLogin.Size = new Size(140, 38);
            lblBackLogin.TabIndex = 11;
            lblBackLogin.Text = "Back To LOGIN";
            lblBackLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            txtId.BackColor = Color.White;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Segoe UI", 10.8F);
            txtId.ForeColor = SystemColors.ControlText;
            txtId.Location = new Point(57, 110);
            txtId.Margin = new Padding(0, 3, 3, 3);
            txtId.Name = "txtId";
            txtId.Size = new Size(307, 31);
            txtId.TabIndex = 13;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblId.ForeColor = Color.CornflowerBlue;
            lblId.Location = new Point(29, 69);
            lblId.Margin = new Padding(20, 0, 3, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(44, 38);
            lblId.TabIndex = 12;
            lblId.Text = "ID";
            lblId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBeforeID
            // 
            lblBeforeID.BackColor = Color.White;
            lblBeforeID.BorderStyle = BorderStyle.FixedSingle;
            lblBeforeID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBeforeID.Location = new Point(29, 110);
            lblBeforeID.Name = "lblBeforeID";
            lblBeforeID.Size = new Size(29, 31);
            lblBeforeID.TabIndex = 14;
            lblBeforeID.Text = "@";
            lblBeforeID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(486, 682);
            Controls.Add(lblBeforeID);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(lblBackLogin);
            Controls.Add(txtAlready);
            Controls.Add(btnClear);
            Controls.Add(btnRegister);
            Controls.Add(chkPassword);
            Controls.Add(txtConfirm);
            Controls.Add(lblConfirm);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(getStarted);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label getStarted;
        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtConfirm;
        private Label lblConfirm;
        private CheckBox chkPassword;
        private Button btnRegister;
        private Button btnClear;
        private Label txtAlready;
        private Label lblBackLogin;
        private TextBox txtId;
        private Label lblId;
        private Label lblBeforeID;
    }
}