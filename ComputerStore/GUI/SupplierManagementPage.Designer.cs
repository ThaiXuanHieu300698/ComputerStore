namespace GUI
{
    partial class SupplierManagementPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblListSupplier = new System.Windows.Forms.Label();
            this.txtSearchSupplier = new System.Windows.Forms.TextBox();
            this.lblTitlePage = new System.Windows.Forms.Label();
            this.grbInfoSupplier = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.lblContactName = new System.Windows.Forms.Label();
            this.btnSearchSupplier = new System.Windows.Forms.Button();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.grbInfoSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListSupplier
            // 
            this.lblListSupplier.AutoSize = true;
            this.lblListSupplier.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblListSupplier.Location = new System.Drawing.Point(359, 312);
            this.lblListSupplier.Name = "lblListSupplier";
            this.lblListSupplier.Size = new System.Drawing.Size(334, 38);
            this.lblListSupplier.TabIndex = 53;
            this.lblListSupplier.Text = "Danh sách nhà cung cấp";
            // 
            // txtSearchSupplier
            // 
            this.txtSearchSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSupplier.Location = new System.Drawing.Point(578, 262);
            this.txtSearchSupplier.Multiline = true;
            this.txtSearchSupplier.Name = "txtSearchSupplier";
            this.txtSearchSupplier.Size = new System.Drawing.Size(268, 40);
            this.txtSearchSupplier.TabIndex = 51;
            this.txtSearchSupplier.Text = "Nhập tên công ty...";
            // 
            // lblTitlePage
            // 
            this.lblTitlePage.AutoSize = true;
            this.lblTitlePage.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitlePage.Location = new System.Drawing.Point(371, 9);
            this.lblTitlePage.Name = "lblTitlePage";
            this.lblTitlePage.Size = new System.Drawing.Size(300, 38);
            this.lblTitlePage.TabIndex = 47;
            this.lblTitlePage.Text = "Quản lý nhà cung cấp";
            // 
            // grbInfoSupplier
            // 
            this.grbInfoSupplier.Controls.Add(this.txtPhone);
            this.grbInfoSupplier.Controls.Add(this.lblPhone);
            this.grbInfoSupplier.Controls.Add(this.txtEmail);
            this.grbInfoSupplier.Controls.Add(this.lblEmail);
            this.grbInfoSupplier.Controls.Add(this.txtAddress);
            this.grbInfoSupplier.Controls.Add(this.lblAddress);
            this.grbInfoSupplier.Controls.Add(this.txtCompanyName);
            this.grbInfoSupplier.Controls.Add(this.lblCompanyName);
            this.grbInfoSupplier.Controls.Add(this.txtContactName);
            this.grbInfoSupplier.Controls.Add(this.lblContactName);
            this.grbInfoSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfoSupplier.Location = new System.Drawing.Point(18, 66);
            this.grbInfoSupplier.Name = "grbInfoSupplier";
            this.grbInfoSupplier.Size = new System.Drawing.Size(985, 178);
            this.grbInfoSupplier.TabIndex = 55;
            this.grbInfoSupplier.TabStop = false;
            this.grbInfoSupplier.Text = "Thông tin nhà cung cấp";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(664, 46);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(289, 34);
            this.txtPhone.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(559, 45);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(70, 32);
            this.lblPhone.TabIndex = 63;
            this.lblPhone.Text = "SĐT :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(664, 87);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(289, 34);
            this.txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(559, 88);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(84, 32);
            this.lblEmail.TabIndex = 61;
            this.lblEmail.Text = "Email :";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(164, 125);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(289, 34);
            this.txtAddress.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(6, 126);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 32);
            this.lblAddress.TabIndex = 59;
            this.lblAddress.Text = "Địa chỉ :";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(164, 45);
            this.txtCompanyName.Multiline = true;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(289, 34);
            this.txtCompanyName.TabIndex = 0;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(6, 47);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(152, 32);
            this.lblCompanyName.TabIndex = 57;
            this.lblCompanyName.Text = "Tên công ty :";
            // 
            // txtContactName
            // 
            this.txtContactName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactName.Location = new System.Drawing.Point(164, 86);
            this.txtContactName.Multiline = true;
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(289, 34);
            this.txtContactName.TabIndex = 1;
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactName.Location = new System.Drawing.Point(6, 87);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(145, 32);
            this.lblContactName.TabIndex = 55;
            this.lblContactName.Text = "Tên liên hệ :";
            // 
            // btnSearchSupplier
            // 
            this.btnSearchSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(150)))));
            this.btnSearchSupplier.FlatAppearance.BorderSize = 0;
            this.btnSearchSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSearchSupplier.Image = global::GUI.Properties.Resources.icons8_Search_26px;
            this.btnSearchSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchSupplier.Location = new System.Drawing.Point(852, 262);
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Size = new System.Drawing.Size(151, 40);
            this.btnSearchSupplier.TabIndex = 52;
            this.btnSearchSupplier.Text = "     Tìm kiếm";
            this.btnSearchSupplier.UseVisualStyleBackColor = false;
            this.btnSearchSupplier.Click += new System.EventHandler(this.btnSearchSupplier_Click);
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.BackColor = System.Drawing.Color.Red;
            this.btnDeleteSupplier.FlatAppearance.BorderSize = 0;
            this.btnDeleteSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSupplier.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSupplier.Image = global::GUI.Properties.Resources.icons8_Trash_Can_26px;
            this.btnDeleteSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteSupplier.Location = new System.Drawing.Point(298, 262);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(134, 40);
            this.btnDeleteSupplier.TabIndex = 50;
            this.btnDeleteSupplier.Text = "   Xóa";
            this.btnDeleteSupplier.UseVisualStyleBackColor = false;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddSupplier.FlatAppearance.BorderSize = 0;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.Image = global::GUI.Properties.Resources.icons8_Plus_Math_26px;
            this.btnAddSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSupplier.Location = new System.Drawing.Point(18, 262);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(134, 40);
            this.btnAddSupplier.TabIndex = 48;
            this.btnAddSupplier.Text = "   Thêm";
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
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
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "   Ghi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Location = new System.Drawing.Point(18, 358);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.RowTemplate.Height = 24;
            this.dgvSuppliers.Size = new System.Drawing.Size(985, 313);
            this.dgvSuppliers.TabIndex = 58;
            this.dgvSuppliers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliers_RowEnter);
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.BackColor = System.Drawing.Color.Gold;
            this.btnEditSupplier.FlatAppearance.BorderSize = 0;
            this.btnEditSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSupplier.ForeColor = System.Drawing.Color.Black;
            this.btnEditSupplier.Image = global::GUI.Properties.Resources.icons8_Edit_26px;
            this.btnEditSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditSupplier.Location = new System.Drawing.Point(158, 262);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(134, 40);
            this.btnEditSupplier.TabIndex = 59;
            this.btnEditSupplier.Text = "   Sửa";
            this.btnEditSupplier.UseVisualStyleBackColor = false;
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // SupplierManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnEditSupplier);
            this.Controls.Add(this.dgvSuppliers);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbInfoSupplier);
            this.Controls.Add(this.lblListSupplier);
            this.Controls.Add(this.btnSearchSupplier);
            this.Controls.Add(this.txtSearchSupplier);
            this.Controls.Add(this.btnDeleteSupplier);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.lblTitlePage);
            this.Name = "SupplierManagementPage";
            this.Size = new System.Drawing.Size(1020, 684);
            this.Load += new System.EventHandler(this.SupplierManagementPage_Load);
            this.grbInfoSupplier.ResumeLayout(false);
            this.grbInfoSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblListSupplier;
        private System.Windows.Forms.Button btnSearchSupplier;
        private System.Windows.Forms.TextBox txtSearchSupplier;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Label lblTitlePage;
        private System.Windows.Forms.GroupBox grbInfoSupplier;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.Button btnEditSupplier;
    }
}
