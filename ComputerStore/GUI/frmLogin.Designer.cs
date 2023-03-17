namespace GUI
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.pnlSignin = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblFotgetPassword = new System.Windows.Forms.Label();
            this.llbBack1 = new System.Windows.Forms.LinkLabel();
            this.btnGenNewPassword = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pnlSignup = new System.Windows.Forms.Panel();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtReEnterPassword = new System.Windows.Forms.TextBox();
            this.lblSignup = new System.Windows.Forms.Label();
            this.llbBack = new System.Windows.Forms.LinkLabel();
            this.btnSignup = new System.Windows.Forms.Button();
            this.txtPasswordNew = new System.Windows.Forms.TextBox();
            this.txtUsernameNew = new System.Windows.Forms.TextBox();
            this.llbForgetPassword = new System.Windows.Forms.LinkLabel();
            this.llbSignup = new System.Windows.Forms.LinkLabel();
            this.lblSignin = new System.Windows.Forms.Label();
            this.btnSignin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            this.pnlSignin.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlSignup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.pnlTop.Controls.Add(this.lbl);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(377, 61);
            this.pnlTop.TabIndex = 7;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(75, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(225, 38);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Computer Store";
            // 
            // pnlSignin
            // 
            this.pnlSignin.Controls.Add(this.pnlRight);
            this.pnlSignin.Controls.Add(this.pnlSignup);
            this.pnlSignin.Controls.Add(this.llbForgetPassword);
            this.pnlSignin.Controls.Add(this.llbSignup);
            this.pnlSignin.Controls.Add(this.lblSignin);
            this.pnlSignin.Controls.Add(this.btnSignin);
            this.pnlSignin.Controls.Add(this.txtPassword);
            this.pnlSignin.Controls.Add(this.txtUsername);
            this.pnlSignin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSignin.Location = new System.Drawing.Point(0, 61);
            this.pnlSignin.Name = "pnlSignin";
            this.pnlSignin.Size = new System.Drawing.Size(377, 369);
            this.pnlSignin.TabIndex = 9;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.lblFotgetPassword);
            this.pnlRight.Controls.Add(this.llbBack1);
            this.pnlRight.Controls.Add(this.btnGenNewPassword);
            this.pnlRight.Controls.Add(this.txtEmail);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(367, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(10, 369);
            this.pnlRight.TabIndex = 20;
            // 
            // lblFotgetPassword
            // 
            this.lblFotgetPassword.AutoSize = true;
            this.lblFotgetPassword.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFotgetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.lblFotgetPassword.Location = new System.Drawing.Point(78, 55);
            this.lblFotgetPassword.Name = "lblFotgetPassword";
            this.lblFotgetPassword.Size = new System.Drawing.Size(222, 41);
            this.lblFotgetPassword.TabIndex = 16;
            this.lblFotgetPassword.Text = "Quên mật khẩu";
            // 
            // llbBack1
            // 
            this.llbBack1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.llbBack1.AutoSize = true;
            this.llbBack1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbBack1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.llbBack1.Location = new System.Drawing.Point(9, 12);
            this.llbBack1.Name = "llbBack1";
            this.llbBack1.Size = new System.Drawing.Size(64, 28);
            this.llbBack1.TabIndex = 8;
            this.llbBack1.TabStop = true;
            this.llbBack1.Text = "Trở về";
            this.llbBack1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.llbBack1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbBack1_LinkClicked);
            // 
            // btnGenNewPassword
            // 
            this.btnGenNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnGenNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenNewPassword.ForeColor = System.Drawing.Color.White;
            this.btnGenNewPassword.Location = new System.Drawing.Point(79, 221);
            this.btnGenNewPassword.Name = "btnGenNewPassword";
            this.btnGenNewPassword.Size = new System.Drawing.Size(206, 44);
            this.btnGenNewPassword.TabIndex = 7;
            this.btnGenNewPassword.Text = "Mật khẩu mới";
            this.btnGenNewPassword.UseVisualStyleBackColor = false;
            this.btnGenNewPassword.Click += new System.EventHandler(this.btnGenNewPassword_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(39, 130);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(293, 41);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "Email";
            // 
            // pnlSignup
            // 
            this.pnlSignup.Controls.Add(this.txtFullName);
            this.pnlSignup.Controls.Add(this.txtReEnterPassword);
            this.pnlSignup.Controls.Add(this.lblSignup);
            this.pnlSignup.Controls.Add(this.llbBack);
            this.pnlSignup.Controls.Add(this.btnSignup);
            this.pnlSignup.Controls.Add(this.txtPasswordNew);
            this.pnlSignup.Controls.Add(this.txtUsernameNew);
            this.pnlSignup.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSignup.Location = new System.Drawing.Point(0, 0);
            this.pnlSignup.Name = "pnlSignup";
            this.pnlSignup.Size = new System.Drawing.Size(10, 369);
            this.pnlSignup.TabIndex = 19;
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(42, 83);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(293, 41);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.Text = "Họ tên";
            // 
            // txtReEnterPassword
            // 
            this.txtReEnterPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReEnterPassword.Location = new System.Drawing.Point(42, 224);
            this.txtReEnterPassword.Multiline = true;
            this.txtReEnterPassword.Name = "txtReEnterPassword";
            this.txtReEnterPassword.PasswordChar = '*';
            this.txtReEnterPassword.Size = new System.Drawing.Size(293, 41);
            this.txtReEnterPassword.TabIndex = 3;
            this.txtReEnterPassword.Text = "Nhập lại mật khẩu";
            // 
            // lblSignup
            // 
            this.lblSignup.AutoSize = true;
            this.lblSignup.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.lblSignup.Location = new System.Drawing.Point(126, 25);
            this.lblSignup.Name = "lblSignup";
            this.lblSignup.Size = new System.Drawing.Size(127, 41);
            this.lblSignup.TabIndex = 19;
            this.lblSignup.Text = "Đăng ký";
            // 
            // llbBack
            // 
            this.llbBack.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.llbBack.AutoSize = true;
            this.llbBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbBack.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.llbBack.Location = new System.Drawing.Point(301, 12);
            this.llbBack.Name = "llbBack";
            this.llbBack.Size = new System.Drawing.Size(64, 28);
            this.llbBack.TabIndex = 5;
            this.llbBack.TabStop = true;
            this.llbBack.Text = "Trở về";
            this.llbBack.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.llbBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbBack_LinkClicked);
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(82, 302);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(206, 44);
            this.btnSignup.TabIndex = 4;
            this.btnSignup.Text = "Đăng ký";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // txtPasswordNew
            // 
            this.txtPasswordNew.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordNew.Location = new System.Drawing.Point(42, 177);
            this.txtPasswordNew.Multiline = true;
            this.txtPasswordNew.Name = "txtPasswordNew";
            this.txtPasswordNew.PasswordChar = '*';
            this.txtPasswordNew.Size = new System.Drawing.Size(293, 41);
            this.txtPasswordNew.TabIndex = 2;
            this.txtPasswordNew.Text = "Mật khẩu";
            // 
            // txtUsernameNew
            // 
            this.txtUsernameNew.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameNew.Location = new System.Drawing.Point(42, 130);
            this.txtUsernameNew.Multiline = true;
            this.txtUsernameNew.Name = "txtUsernameNew";
            this.txtUsernameNew.Size = new System.Drawing.Size(293, 41);
            this.txtUsernameNew.TabIndex = 1;
            this.txtUsernameNew.Text = "Tài khoản";
            // 
            // llbForgetPassword
            // 
            this.llbForgetPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.llbForgetPassword.AutoSize = true;
            this.llbForgetPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbForgetPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.llbForgetPassword.Location = new System.Drawing.Point(190, 318);
            this.llbForgetPassword.Name = "llbForgetPassword";
            this.llbForgetPassword.Size = new System.Drawing.Size(145, 28);
            this.llbForgetPassword.TabIndex = 18;
            this.llbForgetPassword.TabStop = true;
            this.llbForgetPassword.Text = "Quên mật khẩu";
            this.llbForgetPassword.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.llbForgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbForgetPassword_LinkClicked);
            // 
            // llbSignup
            // 
            this.llbSignup.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.llbSignup.AutoSize = true;
            this.llbSignup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbSignup.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.llbSignup.Location = new System.Drawing.Point(37, 318);
            this.llbSignup.Name = "llbSignup";
            this.llbSignup.Size = new System.Drawing.Size(132, 28);
            this.llbSignup.TabIndex = 4;
            this.llbSignup.TabStop = true;
            this.llbSignup.Text = "Đăng ký ngay";
            this.llbSignup.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.llbSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSignup_LinkClicked);
            // 
            // lblSignin
            // 
            this.lblSignin.AutoSize = true;
            this.lblSignin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.lblSignin.Location = new System.Drawing.Point(105, 25);
            this.lblSignin.Name = "lblSignin";
            this.lblSignin.Size = new System.Drawing.Size(164, 41);
            this.lblSignin.TabIndex = 15;
            this.lblSignin.Text = "Đăng nhập";
            // 
            // btnSignin
            // 
            this.btnSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.ForeColor = System.Drawing.Color.White;
            this.btnSignin.Location = new System.Drawing.Point(82, 226);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(206, 44);
            this.btnSignin.TabIndex = 3;
            this.btnSignin.Text = "Đăng nhập";
            this.btnSignin.UseVisualStyleBackColor = false;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(42, 146);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(293, 41);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(42, 99);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(293, 41);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Tài khoản";
            // 
            // Timer
            // 
            this.Timer.Interval = 30;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 30;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 430);
            this.Controls.Add(this.pnlSignin);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Store";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlSignin.ResumeLayout(false);
            this.pnlSignin.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlSignup.ResumeLayout(false);
            this.pnlSignup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Panel pnlSignin;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.LinkLabel llbForgetPassword;
        private System.Windows.Forms.LinkLabel llbSignup;
        private System.Windows.Forms.Label lblSignin;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel pnlSignup;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtReEnterPassword;
        private System.Windows.Forms.Label lblSignup;
        private System.Windows.Forms.LinkLabel llbBack;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.TextBox txtPasswordNew;
        private System.Windows.Forms.TextBox txtUsernameNew;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblFotgetPassword;
        private System.Windows.Forms.LinkLabel llbBack1;
        private System.Windows.Forms.Button btnGenNewPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Timer Timer1;
    }
}