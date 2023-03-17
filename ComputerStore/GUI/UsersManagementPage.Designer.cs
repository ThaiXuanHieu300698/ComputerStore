namespace GUI
{
    partial class UsersManagementPage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersManagementPage));
            this.lblTitlePage = new System.Windows.Forms.Label();
            this.dgvListUser = new System.Windows.Forms.DataGridView();
            this.grbInfoUser = new System.Windows.Forms.GroupBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.rdOrther = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblListUser = new System.Windows.Forms.Label();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.llbRoleManagement = new System.Windows.Forms.LinkLabel();
            this.pnlRoleManagement = new System.Windows.Forms.Panel();
            this.btnPermissionRole = new System.Windows.Forms.Button();
            this.btnEditRole = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.grbPermissionRole = new System.Windows.Forms.GroupBox();
            this.cbFullName = new System.Windows.Forms.ComboBox();
            this.lblPermissionRoleFor = new System.Windows.Forms.Label();
            this.grbInfoRole = new System.Windows.Forms.GroupBox();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.btnSaveRole = new System.Windows.Forms.Button();
            this.dgvRoleUsers = new System.Windows.Forms.DataGridView();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblRoles = new System.Windows.Forms.Label();
            this.lblRoleManagement = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRevoke = new System.Windows.Forms.Button();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.llbBack = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUser)).BeginInit();
            this.grbInfoUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnlRoleManagement.SuspendLayout();
            this.grbPermissionRole.SuspendLayout();
            this.grbInfoRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlePage
            // 
            this.lblTitlePage.AutoSize = true;
            this.lblTitlePage.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitlePage.Location = new System.Drawing.Point(370, 9);
            this.lblTitlePage.Name = "lblTitlePage";
            this.lblTitlePage.Size = new System.Drawing.Size(281, 38);
            this.lblTitlePage.TabIndex = 41;
            this.lblTitlePage.Text = "Quản lý người dùng";
            // 
            // dgvListUser
            // 
            this.dgvListUser.AllowUserToAddRows = false;
            this.dgvListUser.AllowUserToDeleteRows = false;
            this.dgvListUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListUser.Location = new System.Drawing.Point(18, 358);
            this.dgvListUser.Name = "dgvListUser";
            this.dgvListUser.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListUser.RowTemplate.Height = 24;
            this.dgvListUser.Size = new System.Drawing.Size(985, 313);
            this.dgvListUser.TabIndex = 60;
            this.dgvListUser.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListUser_RowEnter);
            // 
            // grbInfoUser
            // 
            this.grbInfoUser.Controls.Add(this.lblGender);
            this.grbInfoUser.Controls.Add(this.rdOrther);
            this.grbInfoUser.Controls.Add(this.rdFemale);
            this.grbInfoUser.Controls.Add(this.rdMale);
            this.grbInfoUser.Controls.Add(this.btnChangeImage);
            this.grbInfoUser.Controls.Add(this.picAvatar);
            this.grbInfoUser.Controls.Add(this.txtEmail);
            this.grbInfoUser.Controls.Add(this.lblEmail);
            this.grbInfoUser.Controls.Add(this.txtPhone);
            this.grbInfoUser.Controls.Add(this.lblPhone);
            this.grbInfoUser.Controls.Add(this.lblPassword);
            this.grbInfoUser.Controls.Add(this.lblUserName);
            this.grbInfoUser.Controls.Add(this.txtPassword);
            this.grbInfoUser.Controls.Add(this.txtUserName);
            this.grbInfoUser.Controls.Add(this.txtFullName);
            this.grbInfoUser.Controls.Add(this.lblFullName);
            this.grbInfoUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfoUser.Location = new System.Drawing.Point(18, 66);
            this.grbInfoUser.Name = "grbInfoUser";
            this.grbInfoUser.Size = new System.Drawing.Size(985, 178);
            this.grbInfoUser.TabIndex = 58;
            this.grbInfoUser.TabStop = false;
            this.grbInfoUser.Text = "Thông tin người dùng";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(399, 47);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(118, 32);
            this.lblGender.TabIndex = 73;
            this.lblGender.Text = "Giới tính :";
            // 
            // rdOrther
            // 
            this.rdOrther.AutoSize = true;
            this.rdOrther.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdOrther.Location = new System.Drawing.Point(690, 43);
            this.rdOrther.Name = "rdOrther";
            this.rdOrther.Size = new System.Drawing.Size(87, 36);
            this.rdOrther.TabIndex = 6;
            this.rdOrther.TabStop = true;
            this.rdOrther.Text = "Khác";
            this.rdOrther.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFemale.Location = new System.Drawing.Point(616, 43);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(68, 36);
            this.rdFemale.TabIndex = 5;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Nữ";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Checked = true;
            this.rdMale.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMale.Location = new System.Drawing.Point(523, 43);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(87, 36);
            this.rdMale.TabIndex = 4;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Nam";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeImage.ForeColor = System.Drawing.Color.Black;
            this.btnChangeImage.Image = global::GUI.Properties.Resources.icons8_Edit_26px;
            this.btnChangeImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeImage.Location = new System.Drawing.Point(802, 132);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(45, 38);
            this.btnChangeImage.TabIndex = 70;
            this.btnChangeImage.UseVisualStyleBackColor = false;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(800, 18);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(179, 154);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 68;
            this.picAvatar.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(523, 130);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 34);
            this.txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(399, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(84, 32);
            this.lblEmail.TabIndex = 64;
            this.lblEmail.Text = "Email :";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(523, 90);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(243, 34);
            this.txtPhone.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(399, 91);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(70, 32);
            this.lblPhone.TabIndex = 62;
            this.lblPhone.Text = "SĐT :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(6, 132);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(128, 32);
            this.lblPassword.TabIndex = 60;
            this.lblPassword.Text = "Mật khẩu :";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(6, 87);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(128, 32);
            this.lblUserName.TabIndex = 57;
            this.lblUserName.Text = "Tài khoản :";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(144, 130);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(249, 34);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(144, 87);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(249, 34);
            this.txtUserName.TabIndex = 2;
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(144, 45);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(249, 34);
            this.txtFullName.TabIndex = 1;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(6, 47);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(134, 32);
            this.lblFullName.TabIndex = 55;
            this.lblFullName.Text = "Họ và Tên :";
            // 
            // lblListUser
            // 
            this.lblListUser.AutoSize = true;
            this.lblListUser.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblListUser.Location = new System.Drawing.Point(359, 312);
            this.lblListUser.Name = "lblListUser";
            this.lblListUser.Size = new System.Drawing.Size(315, 38);
            this.lblListUser.TabIndex = 57;
            this.lblListUser.Text = "Danh sách người dùng";
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUser.ForeColor = System.Drawing.Color.Black;
            this.txtSearchUser.Location = new System.Drawing.Point(578, 261);
            this.txtSearchUser.Multiline = true;
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(268, 40);
            this.txtSearchUser.TabIndex = 55;
            this.txtSearchUser.Text = "Nhập tên người dùng...";
            // 
            // Timer
            // 
            this.Timer.Interval = 30;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // llbRoleManagement
            // 
            this.llbRoleManagement.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llbRoleManagement.AutoSize = true;
            this.llbRoleManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbRoleManagement.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llbRoleManagement.Location = new System.Drawing.Point(13, 9);
            this.llbRoleManagement.Name = "llbRoleManagement";
            this.llbRoleManagement.Size = new System.Drawing.Size(241, 25);
            this.llbRoleManagement.TabIndex = 63;
            this.llbRoleManagement.TabStop = true;
            this.llbRoleManagement.Text = "Quản lý quyền người dùng";
            this.llbRoleManagement.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llbRoleManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbRoleManagement_LinkClicked);
            // 
            // pnlRoleManagement
            // 
            this.pnlRoleManagement.Controls.Add(this.btnPermissionRole);
            this.pnlRoleManagement.Controls.Add(this.btnEditRole);
            this.pnlRoleManagement.Controls.Add(this.btnAddRole);
            this.pnlRoleManagement.Controls.Add(this.grbPermissionRole);
            this.pnlRoleManagement.Controls.Add(this.grbInfoRole);
            this.pnlRoleManagement.Controls.Add(this.btnSaveRole);
            this.pnlRoleManagement.Controls.Add(this.dgvRoleUsers);
            this.pnlRoleManagement.Controls.Add(this.dgvRoles);
            this.pnlRoleManagement.Controls.Add(this.lblUsers);
            this.pnlRoleManagement.Controls.Add(this.lblRoles);
            this.pnlRoleManagement.Controls.Add(this.lblRoleManagement);
            this.pnlRoleManagement.Controls.Add(this.btnSearch);
            this.pnlRoleManagement.Controls.Add(this.txtSearch);
            this.pnlRoleManagement.Controls.Add(this.btnRevoke);
            this.pnlRoleManagement.Controls.Add(this.btnDeleteRole);
            this.pnlRoleManagement.Controls.Add(this.llbBack);
            this.pnlRoleManagement.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRoleManagement.Location = new System.Drawing.Point(0, 0);
            this.pnlRoleManagement.Name = "pnlRoleManagement";
            this.pnlRoleManagement.Size = new System.Drawing.Size(10, 684);
            this.pnlRoleManagement.TabIndex = 64;
            // 
            // btnPermissionRole
            // 
            this.btnPermissionRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnPermissionRole.FlatAppearance.BorderSize = 0;
            this.btnPermissionRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermissionRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermissionRole.ForeColor = System.Drawing.Color.White;
            this.btnPermissionRole.Image = global::GUI.Properties.Resources.icons8_Approval_26px;
            this.btnPermissionRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPermissionRole.Location = new System.Drawing.Point(520, 204);
            this.btnPermissionRole.Name = "btnPermissionRole";
            this.btnPermissionRole.Size = new System.Drawing.Size(173, 40);
            this.btnPermissionRole.TabIndex = 81;
            this.btnPermissionRole.Text = "     Cấp quyền";
            this.btnPermissionRole.UseVisualStyleBackColor = false;
            this.btnPermissionRole.Click += new System.EventHandler(this.btnPermissionRole_Click);
            // 
            // btnEditRole
            // 
            this.btnEditRole.BackColor = System.Drawing.Color.Gold;
            this.btnEditRole.FlatAppearance.BorderSize = 0;
            this.btnEditRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRole.ForeColor = System.Drawing.Color.Black;
            this.btnEditRole.Image = global::GUI.Properties.Resources.icons8_Edit_26px;
            this.btnEditRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditRole.Location = new System.Drawing.Point(169, 204);
            this.btnEditRole.Name = "btnEditRole";
            this.btnEditRole.Size = new System.Drawing.Size(134, 40);
            this.btnEditRole.TabIndex = 81;
            this.btnEditRole.Text = "   Sửa";
            this.btnEditRole.UseVisualStyleBackColor = false;
            this.btnEditRole.Click += new System.EventHandler(this.btnEditRole_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddRole.FlatAppearance.BorderSize = 0;
            this.btnAddRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRole.ForeColor = System.Drawing.Color.White;
            this.btnAddRole.Image = global::GUI.Properties.Resources.icons8_Plus_Math_26px;
            this.btnAddRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRole.Location = new System.Drawing.Point(18, 204);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(134, 40);
            this.btnAddRole.TabIndex = 80;
            this.btnAddRole.Text = "   Thêm";
            this.btnAddRole.UseVisualStyleBackColor = false;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // grbPermissionRole
            // 
            this.grbPermissionRole.Controls.Add(this.cbFullName);
            this.grbPermissionRole.Controls.Add(this.lblPermissionRoleFor);
            this.grbPermissionRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPermissionRole.Location = new System.Drawing.Point(520, 66);
            this.grbPermissionRole.Name = "grbPermissionRole";
            this.grbPermissionRole.Size = new System.Drawing.Size(483, 124);
            this.grbPermissionRole.TabIndex = 79;
            this.grbPermissionRole.TabStop = false;
            this.grbPermissionRole.Text = "Cấp quyền";
            // 
            // cbFullName
            // 
            this.cbFullName.FormattingEnabled = true;
            this.cbFullName.Location = new System.Drawing.Point(146, 45);
            this.cbFullName.Name = "cbFullName";
            this.cbFullName.Size = new System.Drawing.Size(291, 36);
            this.cbFullName.TabIndex = 56;
            // 
            // lblPermissionRoleFor
            // 
            this.lblPermissionRoleFor.AutoSize = true;
            this.lblPermissionRoleFor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermissionRoleFor.Location = new System.Drawing.Point(6, 47);
            this.lblPermissionRoleFor.Name = "lblPermissionRoleFor";
            this.lblPermissionRoleFor.Size = new System.Drawing.Size(134, 32);
            this.lblPermissionRoleFor.TabIndex = 55;
            this.lblPermissionRoleFor.Text = "Họ và Tên :";
            // 
            // grbInfoRole
            // 
            this.grbInfoRole.Controls.Add(this.txtRoleName);
            this.grbInfoRole.Controls.Add(this.lblRoleName);
            this.grbInfoRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfoRole.Location = new System.Drawing.Point(18, 66);
            this.grbInfoRole.Name = "grbInfoRole";
            this.grbInfoRole.Size = new System.Drawing.Size(496, 124);
            this.grbInfoRole.TabIndex = 78;
            this.grbInfoRole.TabStop = false;
            this.grbInfoRole.Text = "Thông tin quyền";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoleName.Location = new System.Drawing.Point(151, 46);
            this.txtRoleName.Multiline = true;
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(265, 34);
            this.txtRoleName.TabIndex = 56;
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleName.Location = new System.Drawing.Point(6, 47);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(139, 32);
            this.lblRoleName.TabIndex = 55;
            this.lblRoleName.Text = "Tên quyền :";
            // 
            // btnSaveRole
            // 
            this.btnSaveRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnSaveRole.FlatAppearance.BorderSize = 0;
            this.btnSaveRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRole.ForeColor = System.Drawing.Color.White;
            this.btnSaveRole.Image = global::GUI.Properties.Resources.icons8_Save_26px;
            this.btnSaveRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveRole.Location = new System.Drawing.Point(169, 259);
            this.btnSaveRole.Name = "btnSaveRole";
            this.btnSaveRole.Size = new System.Drawing.Size(134, 40);
            this.btnSaveRole.TabIndex = 77;
            this.btnSaveRole.Text = "   Ghi";
            this.btnSaveRole.UseVisualStyleBackColor = false;
            this.btnSaveRole.Click += new System.EventHandler(this.btnSaveRole_Click);
            // 
            // dgvRoleUsers
            // 
            this.dgvRoleUsers.AllowUserToAddRows = false;
            this.dgvRoleUsers.AllowUserToDeleteRows = false;
            this.dgvRoleUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoleUsers.Location = new System.Drawing.Point(520, 358);
            this.dgvRoleUsers.Name = "dgvRoleUsers";
            this.dgvRoleUsers.RowTemplate.Height = 24;
            this.dgvRoleUsers.Size = new System.Drawing.Size(483, 313);
            this.dgvRoleUsers.TabIndex = 76;
            this.dgvRoleUsers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoleUsers_RowEnter);
            // 
            // dgvRoles
            // 
            this.dgvRoles.AllowUserToAddRows = false;
            this.dgvRoles.AllowUserToDeleteRows = false;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(18, 358);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.RowTemplate.Height = 24;
            this.dgvRoles.Size = new System.Drawing.Size(496, 313);
            this.dgvRoles.TabIndex = 75;
            this.dgvRoles.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_RowEnter);
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblUsers.Location = new System.Drawing.Point(669, 317);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(177, 38);
            this.lblUsers.TabIndex = 74;
            this.lblUsers.Text = "Người dùng";
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRoles.Location = new System.Drawing.Point(151, 317);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(241, 38);
            this.lblRoles.TabIndex = 74;
            this.lblRoles.Text = "Danh sách quyền";
            // 
            // lblRoleManagement
            // 
            this.lblRoleManagement.AutoSize = true;
            this.lblRoleManagement.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRoleManagement.Location = new System.Drawing.Point(338, 9);
            this.lblRoleManagement.Name = "lblRoleManagement";
            this.lblRoleManagement.Size = new System.Drawing.Size(370, 38);
            this.lblRoleManagement.TabIndex = 74;
            this.lblRoleManagement.Text = "Quản lý quyền người dùng";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(150)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::GUI.Properties.Resources.icons8_Search_26px;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(852, 261);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(151, 40);
            this.btnSearch.TabIndex = 72;
            this.btnSearch.Text = "     Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(520, 261);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(326, 40);
            this.txtSearch.TabIndex = 73;
            this.txtSearch.Text = "Nhập tên người dùng...";
            // 
            // btnRevoke
            // 
            this.btnRevoke.BackColor = System.Drawing.Color.Red;
            this.btnRevoke.FlatAppearance.BorderSize = 0;
            this.btnRevoke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevoke.ForeColor = System.Drawing.Color.White;
            this.btnRevoke.Image = global::GUI.Properties.Resources.icons8_Lock_26px;
            this.btnRevoke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevoke.Location = new System.Drawing.Point(699, 204);
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.Size = new System.Drawing.Size(164, 40);
            this.btnRevoke.TabIndex = 70;
            this.btnRevoke.Text = "   Thu hồi";
            this.btnRevoke.UseVisualStyleBackColor = false;
            this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.BackColor = System.Drawing.Color.Red;
            this.btnDeleteRole.FlatAppearance.BorderSize = 0;
            this.btnDeleteRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRole.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRole.Image = global::GUI.Properties.Resources.icons8_Trash_Can_26px;
            this.btnDeleteRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteRole.Location = new System.Drawing.Point(18, 259);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(134, 40);
            this.btnDeleteRole.TabIndex = 70;
            this.btnDeleteRole.Text = "   Xóa";
            this.btnDeleteRole.UseVisualStyleBackColor = false;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // llbBack
            // 
            this.llbBack.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llbBack.AutoSize = true;
            this.llbBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbBack.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llbBack.Location = new System.Drawing.Point(935, 19);
            this.llbBack.Name = "llbBack";
            this.llbBack.Size = new System.Drawing.Size(68, 25);
            this.llbBack.TabIndex = 64;
            this.llbBack.TabStop = true;
            this.llbBack.Text = "Trở về";
            this.llbBack.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llbBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbBack_LinkClicked);
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
            this.btnSave.Location = new System.Drawing.Point(438, 262);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "   Ghi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(150)))));
            this.btnSearchUser.FlatAppearance.BorderSize = 0;
            this.btnSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUser.ForeColor = System.Drawing.Color.White;
            this.btnSearchUser.Image = global::GUI.Properties.Resources.icons8_Search_26px;
            this.btnSearchUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchUser.Location = new System.Drawing.Point(852, 261);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(151, 40);
            this.btnSearchUser.TabIndex = 56;
            this.btnSearchUser.Text = "     Tìm kiếm";
            this.btnSearchUser.UseVisualStyleBackColor = false;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Red;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Image = global::GUI.Properties.Resources.icons8_Trash_Can_26px;
            this.btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUser.Location = new System.Drawing.Point(298, 262);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(134, 40);
            this.btnDeleteUser.TabIndex = 54;
            this.btnDeleteUser.Text = "   Xóa";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.Gold;
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.ForeColor = System.Drawing.Color.Black;
            this.btnEditUser.Image = global::GUI.Properties.Resources.icons8_Edit_26px;
            this.btnEditUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditUser.Location = new System.Drawing.Point(158, 262);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(134, 40);
            this.btnEditUser.TabIndex = 53;
            this.btnEditUser.Text = "   Sửa";
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = global::GUI.Properties.Resources.icons8_Plus_Math_26px;
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(18, 262);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(134, 40);
            this.btnAddUser.TabIndex = 52;
            this.btnAddUser.Text = "   Thêm";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // UsersManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlRoleManagement);
            this.Controls.Add(this.llbRoleManagement);
            this.Controls.Add(this.dgvListUser);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbInfoUser);
            this.Controls.Add(this.lblListUser);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.txtSearchUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblTitlePage);
            this.Name = "UsersManagementPage";
            this.Size = new System.Drawing.Size(1020, 684);
            this.Load += new System.EventHandler(this.UsersManagementPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUser)).EndInit();
            this.grbInfoUser.ResumeLayout(false);
            this.grbInfoUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnlRoleManagement.ResumeLayout(false);
            this.pnlRoleManagement.PerformLayout();
            this.grbPermissionRole.ResumeLayout(false);
            this.grbPermissionRole.PerformLayout();
            this.grbInfoRole.ResumeLayout(false);
            this.grbInfoRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlePage;
        private System.Windows.Forms.DataGridView dgvListUser;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grbInfoUser;
        private System.Windows.Forms.Button btnChangeImage;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblListUser;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rdOrther;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.LinkLabel llbRoleManagement;
        private System.Windows.Forms.Panel pnlRoleManagement;
        private System.Windows.Forms.LinkLabel llbBack;
        private System.Windows.Forms.Label lblRoleManagement;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.DataGridView dgvRoleUsers;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.Button btnSaveRole;
        private System.Windows.Forms.GroupBox grbInfoRole;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.GroupBox grbPermissionRole;
        private System.Windows.Forms.Label lblPermissionRoleFor;
        private System.Windows.Forms.Button btnEditRole;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.ComboBox cbFullName;
        private System.Windows.Forms.Button btnPermissionRole;
        private System.Windows.Forms.Button btnRevoke;
    }
}
