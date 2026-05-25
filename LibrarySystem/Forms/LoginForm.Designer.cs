namespace LibrarySystem
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop       = new System.Windows.Forms.Panel();
            this.lblSystemTitle = new System.Windows.Forms.Label();
            this.lblSubTitle    = new System.Windows.Forms.Label();
            this.panelCenter    = new System.Windows.Forms.Panel();
            this.lblLoginHeading = new System.Windows.Forms.Label();
            this.lblDivider     = new System.Windows.Forms.Label();
            this.lblUsername    = new System.Windows.Forms.Label();
            this.txtUsername    = new System.Windows.Forms.TextBox();
            this.lblPassword    = new System.Windows.Forms.Label();
            this.txtPassword    = new System.Windows.Forms.TextBox();
            this.btnLogin       = new System.Windows.Forms.Button();
            this.btnClear       = new System.Windows.Forms.Button();
            this.btnExit        = new System.Windows.Forms.Button();
            this.panelBottom    = new System.Windows.Forms.Panel();
            this.lblFooter      = new System.Windows.Forms.Label();

            this.panelTop.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(20, 60, 120);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 110;
            this.panelTop.Controls.Add(this.lblSystemTitle);
            this.panelTop.Controls.Add(this.lblSubTitle);

            // lblSystemTitle
            this.lblSystemTitle.AutoSize = false;
            this.lblSystemTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblSystemTitle.ForeColor = System.Drawing.Color.White;
            this.lblSystemTitle.Location = new System.Drawing.Point(0, 15);
            this.lblSystemTitle.Size = new System.Drawing.Size(560, 45);
            this.lblSystemTitle.Text = "LIBRARY MANAGEMENT SYSTEM";
            this.lblSystemTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSubTitle
            this.lblSubTitle.AutoSize = false;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(180, 210, 255);
            this.lblSubTitle.Location = new System.Drawing.Point(0, 62);
            this.lblSubTitle.Size = new System.Drawing.Size(560, 30);
            this.lblSubTitle.Text = "Manage Your Library Books Easily";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // panelBottom
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(20, 60, 120);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Height = 35;
            this.panelBottom.Controls.Add(this.lblFooter);

            // lblFooter
            this.lblFooter.AutoSize = false;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(160, 200, 255);
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFooter.Text = "Library Management System  |  Version 1.0  |  Visual Programming CS-412";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // panelCenter
            this.panelCenter.BackColor = System.Drawing.Color.White;
            this.panelCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCenter.Location = new System.Drawing.Point(120, 135);
            this.panelCenter.Size = new System.Drawing.Size(320, 295);
            this.panelCenter.Controls.Add(this.lblLoginHeading);
            this.panelCenter.Controls.Add(this.lblDivider);
            this.panelCenter.Controls.Add(this.lblUsername);
            this.panelCenter.Controls.Add(this.txtUsername);
            this.panelCenter.Controls.Add(this.lblPassword);
            this.panelCenter.Controls.Add(this.txtPassword);
            this.panelCenter.Controls.Add(this.btnLogin);
            this.panelCenter.Controls.Add(this.btnClear);
            this.panelCenter.Controls.Add(this.btnExit);

            // lblLoginHeading
            this.lblLoginHeading.AutoSize = false;
            this.lblLoginHeading.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblLoginHeading.ForeColor = System.Drawing.Color.FromArgb(20, 60, 120);
            this.lblLoginHeading.Location = new System.Drawing.Point(0, 18);
            this.lblLoginHeading.Size = new System.Drawing.Size(318, 35);
            this.lblLoginHeading.Text = "User Login";
            this.lblLoginHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblDivider
            this.lblDivider.AutoSize = false;
            this.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDivider.Location = new System.Drawing.Point(20, 57);
            this.lblDivider.Size = new System.Drawing.Size(278, 2);

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(50, 50, 80);
            this.lblUsername.Location = new System.Drawing.Point(25, 75);
            this.lblUsername.Text = "Username";

            // txtUsername
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.Location = new System.Drawing.Point(25, 98);
            this.txtUsername.Size = new System.Drawing.Size(268, 28);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(50, 50, 80);
            this.lblPassword.Location = new System.Drawing.Point(25, 138);
            this.lblPassword.Text = "Password";

            // txtPassword
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.Location = new System.Drawing.Point(25, 161);
            this.txtPassword.Size = new System.Drawing.Size(268, 28);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // btnLogin
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(20, 60, 120);
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(25, 205);
            this.btnLogin.Size = new System.Drawing.Size(268, 38);
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // btnClear
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(25, 252);
            this.btnClear.Size = new System.Drawing.Size(125, 33);
            this.btnClear.Text = "Clear";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // btnExit
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(180, 30, 30);
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(168, 252);
            this.btnExit.Size = new System.Drawing.Size(125, 33);
            this.btnExit.Text = "Exit";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // LoginForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(235, 242, 255);
            this.ClientSize = new System.Drawing.Size(560, 500);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.MinimumSize = new System.Drawing.Size(580, 550);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System - Login";

            this.panelTop.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel     panelTop;
        private System.Windows.Forms.Panel     panelCenter;
        private System.Windows.Forms.Panel     panelBottom;
        private System.Windows.Forms.Label     lblSystemTitle;
        private System.Windows.Forms.Label     lblSubTitle;
        private System.Windows.Forms.Label     lblLoginHeading;
        private System.Windows.Forms.Label     lblDivider;
        private System.Windows.Forms.Label     lblUsername;
        private System.Windows.Forms.TextBox   txtUsername;
        private System.Windows.Forms.Label     lblPassword;
        private System.Windows.Forms.TextBox   txtPassword;
        private System.Windows.Forms.Button    btnLogin;
        private System.Windows.Forms.Button    btnClear;
        private System.Windows.Forms.Button    btnExit;
        private System.Windows.Forms.Label     lblFooter;
    }
}
