namespace GUI
{
    partial class UserPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPage));
            this.grbUserInfo = new System.Windows.Forms.GroupBox();
            this.grbChangePassword = new System.Windows.Forms.GroupBox();
            this.lblReEnterPassword = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtReEnterPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.grbMainInfo = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.rdOrther = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.grbAvatar = new System.Windows.Forms.GroupBox();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitlePage = new System.Windows.Forms.Label();
            this.grbUserInfo.SuspendLayout();
            this.grbChangePassword.SuspendLayout();
            this.grbMainInfo.SuspendLayout();
            this.grbAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // grbUserInfo
            // 
            this.grbUserInfo.Controls.Add(this.grbChangePassword);
            this.grbUserInfo.Controls.Add(this.grbMainInfo);
            this.grbUserInfo.Controls.Add(this.grbAvatar);
            this.grbUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUserInfo.Location = new System.Drawing.Point(15, 81);
            this.grbUserInfo.Name = "grbUserInfo";
            this.grbUserInfo.Size = new System.Drawing.Size(988, 551);
            this.grbUserInfo.TabIndex = 0;
            this.grbUserInfo.TabStop = false;
            this.grbUserInfo.Text = "Thông tin người dùng";
            // 
            // grbChangePassword
            // 
            this.grbChangePassword.Controls.Add(this.lblReEnterPassword);
            this.grbChangePassword.Controls.Add(this.btnChangePassword);
            this.grbChangePassword.Controls.Add(this.lblNewPassword);
            this.grbChangePassword.Controls.Add(this.lblUserName);
            this.grbChangePassword.Controls.Add(this.lblCurrentPassword);
            this.grbChangePassword.Controls.Add(this.txtUsername);
            this.grbChangePassword.Controls.Add(this.txtPassword);
            this.grbChangePassword.Controls.Add(this.txtReEnterPassword);
            this.grbChangePassword.Controls.Add(this.txtNewPassword);
            this.grbChangePassword.Location = new System.Drawing.Point(513, 50);
            this.grbChangePassword.Name = "grbChangePassword";
            this.grbChangePassword.Size = new System.Drawing.Size(446, 495);
            this.grbChangePassword.TabIndex = 5;
            this.grbChangePassword.TabStop = false;
            this.grbChangePassword.Text = "Đổi mật khẩu";
            // 
            // lblReEnterPassword
            // 
            this.lblReEnterPassword.AutoSize = true;
            this.lblReEnterPassword.Location = new System.Drawing.Point(34, 294);
            this.lblReEnterPassword.Name = "lblReEnterPassword";
            this.lblReEnterPassword.Size = new System.Drawing.Size(262, 29);
            this.lblReEnterPassword.TabIndex = 4;
            this.lblReEnterPassword.Text = "Nhập lại mật khẩu mới :";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Image = global::GUI.Properties.Resources.icons8_Save_26px;
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.Location = new System.Drawing.Point(39, 398);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(162, 40);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "     Thay đổi";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(34, 214);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(167, 29);
            this.lblNewPassword.TabIndex = 4;
            this.lblNewPassword.Text = "Mật khẩu mới :";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(34, 53);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(131, 29);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Tài khoản :";
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Location = new System.Drawing.Point(34, 134);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(204, 29);
            this.lblCurrentPassword.TabIndex = 4;
            this.lblCurrentPassword.Text = "Mật khẩu hiện tại :";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(39, 85);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(289, 34);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(39, 166);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(289, 34);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.Text = "Password";
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtReEnterPassword
            // 
            this.txtReEnterPassword.Location = new System.Drawing.Point(39, 334);
            this.txtReEnterPassword.Name = "txtReEnterPassword";
            this.txtReEnterPassword.PasswordChar = '*';
            this.txtReEnterPassword.Size = new System.Drawing.Size(289, 34);
            this.txtReEnterPassword.TabIndex = 2;
            this.txtReEnterPassword.Text = "ReEnterPassword";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(39, 246);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(289, 34);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.Text = "NewPassword";
            // 
            // grbMainInfo
            // 
            this.grbMainInfo.Controls.Add(this.lblEmail);
            this.grbMainInfo.Controls.Add(this.lblPhone);
            this.grbMainInfo.Controls.Add(this.lblGender);
            this.grbMainInfo.Controls.Add(this.lblFullName);
            this.grbMainInfo.Controls.Add(this.rdOrther);
            this.grbMainInfo.Controls.Add(this.rdFemale);
            this.grbMainInfo.Controls.Add(this.rdMale);
            this.grbMainInfo.Controls.Add(this.txtEmail);
            this.grbMainInfo.Controls.Add(this.txtPhone);
            this.grbMainInfo.Controls.Add(this.txtFullName);
            this.grbMainInfo.Location = new System.Drawing.Point(7, 256);
            this.grbMainInfo.Name = "grbMainInfo";
            this.grbMainInfo.Size = new System.Drawing.Size(500, 289);
            this.grbMainInfo.TabIndex = 1;
            this.grbMainInfo.TabStop = false;
            this.grbMainInfo.Text = "Thông tin chính";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(17, 192);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(86, 29);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(17, 146);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(166, 29);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Số điện thoại :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(17, 105);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(113, 29);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Giới tính :";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(17, 60);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(135, 29);
            this.lblFullName.TabIndex = 4;
            this.lblFullName.Text = "Họ và Tên :";
            // 
            // rdOrther
            // 
            this.rdOrther.AutoSize = true;
            this.rdOrther.Location = new System.Drawing.Point(390, 103);
            this.rdOrther.Name = "rdOrther";
            this.rdOrther.Size = new System.Drawing.Size(88, 33);
            this.rdOrther.TabIndex = 4;
            this.rdOrther.TabStop = true;
            this.rdOrther.Text = "Khác";
            this.rdOrther.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(302, 103);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(65, 33);
            this.rdFemale.TabIndex = 3;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Nữ";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(201, 103);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(85, 33);
            this.rdMale.TabIndex = 2;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Nam";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(201, 189);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(277, 34);
            this.txtEmail.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(201, 143);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(277, 34);
            this.txtPhone.TabIndex = 5;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(201, 57);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(277, 34);
            this.txtFullName.TabIndex = 0;
            // 
            // grbAvatar
            // 
            this.grbAvatar.Controls.Add(this.btnChangeImage);
            this.grbAvatar.Controls.Add(this.picAvatar);
            this.grbAvatar.Location = new System.Drawing.Point(7, 50);
            this.grbAvatar.Name = "grbAvatar";
            this.grbAvatar.Size = new System.Drawing.Size(500, 200);
            this.grbAvatar.TabIndex = 1;
            this.grbAvatar.TabStop = false;
            this.grbAvatar.Text = "Ảnh đại diện 3x4";
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeImage.Image = global::GUI.Properties.Resources.icons8_Edit_26px;
            this.btnChangeImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeImage.Location = new System.Drawing.Point(167, 153);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(150, 40);
            this.btnChangeImage.TabIndex = 1;
            this.btnChangeImage.Text = "       Chỉnh sửa";
            this.btnChangeImage.UseVisualStyleBackColor = true;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(6, 33);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(146, 160);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::GUI.Properties.Resources.icons8_Save_26px;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(869, 638);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "   Ghi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitlePage
            // 
            this.lblTitlePage.AutoSize = true;
            this.lblTitlePage.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitlePage.Location = new System.Drawing.Point(461, 9);
            this.lblTitlePage.Name = "lblTitlePage";
            this.lblTitlePage.Size = new System.Drawing.Size(93, 38);
            this.lblTitlePage.TabIndex = 41;
            this.lblTitlePage.Text = "Hồ sơ";
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTitlePage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbUserInfo);
            this.Name = "UserPage";
            this.Size = new System.Drawing.Size(1020, 684);
            this.Load += new System.EventHandler(this.UserPage_Load);
            this.grbUserInfo.ResumeLayout(false);
            this.grbChangePassword.ResumeLayout(false);
            this.grbChangePassword.PerformLayout();
            this.grbMainInfo.ResumeLayout(false);
            this.grbMainInfo.PerformLayout();
            this.grbAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUserInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitlePage;
        private System.Windows.Forms.GroupBox grbMainInfo;
        private System.Windows.Forms.RadioButton rdOrther;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.GroupBox grbAvatar;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.GroupBox grbChangePassword;
        private System.Windows.Forms.Label lblReEnterPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtReEnterPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnChangeImage;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUsername;
    }
}
