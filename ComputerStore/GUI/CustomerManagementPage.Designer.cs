namespace GUI
{
    partial class CustomerManagementPage
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
            this.lblListCustomer = new System.Windows.Forms.Label();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.lblTitlePage = new System.Windows.Forms.Label();
            this.grbInfoCustomer = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.grbInfoCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListCustomer
            // 
            this.lblListCustomer.AutoSize = true;
            this.lblListCustomer.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblListCustomer.Location = new System.Drawing.Point(359, 312);
            this.lblListCustomer.Name = "lblListCustomer";
            this.lblListCustomer.Size = new System.Drawing.Size(312, 38);
            this.lblListCustomer.TabIndex = 45;
            this.lblListCustomer.Text = "Danh sách khách hàng";
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.Location = new System.Drawing.Point(578, 262);
            this.txtSearchCustomer.Multiline = true;
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(268, 40);
            this.txtSearchCustomer.TabIndex = 4;
            this.txtSearchCustomer.Text = "Nhập số điện thoại...";
            // 
            // lblTitlePage
            // 
            this.lblTitlePage.AutoSize = true;
            this.lblTitlePage.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitlePage.Location = new System.Drawing.Point(368, 9);
            this.lblTitlePage.Name = "lblTitlePage";
            this.lblTitlePage.Size = new System.Drawing.Size(278, 38);
            this.lblTitlePage.TabIndex = 39;
            this.lblTitlePage.Text = "Quản lý khách hàng";
            // 
            // grbInfoCustomer
            // 
            this.grbInfoCustomer.Controls.Add(this.txtPhone);
            this.grbInfoCustomer.Controls.Add(this.lblPhone);
            this.grbInfoCustomer.Controls.Add(this.txtEmail);
            this.grbInfoCustomer.Controls.Add(this.lblEmail);
            this.grbInfoCustomer.Controls.Add(this.txtAddress);
            this.grbInfoCustomer.Controls.Add(this.lblAddress);
            this.grbInfoCustomer.Controls.Add(this.txtFirstName);
            this.grbInfoCustomer.Controls.Add(this.lblFirstName);
            this.grbInfoCustomer.Controls.Add(this.txtLastName);
            this.grbInfoCustomer.Controls.Add(this.lblLastName);
            this.grbInfoCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfoCustomer.Location = new System.Drawing.Point(18, 66);
            this.grbInfoCustomer.Name = "grbInfoCustomer";
            this.grbInfoCustomer.Size = new System.Drawing.Size(985, 178);
            this.grbInfoCustomer.TabIndex = 47;
            this.grbInfoCustomer.TabStop = false;
            this.grbInfoCustomer.Text = "Thông tin khách hàng";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(794, 46);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(178, 34);
            this.txtPhone.TabIndex = 4;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(718, 46);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(70, 32);
            this.lblPhone.TabIndex = 63;
            this.lblPhone.Text = "SĐT :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(410, 84);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(289, 34);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(304, 86);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(84, 32);
            this.lblEmail.TabIndex = 61;
            this.lblEmail.Text = "Email :";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(410, 44);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(289, 34);
            this.txtAddress.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(304, 46);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 32);
            this.lblAddress.TabIndex = 59;
            this.lblAddress.Text = "Địa chỉ :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(77, 85);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(207, 34);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(6, 87);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(65, 32);
            this.lblFirstName.TabIndex = 57;
            this.lblFirstName.Text = "Tên :";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(77, 45);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(207, 34);
            this.txtLastName.TabIndex = 0;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(6, 47);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 32);
            this.lblLastName.TabIndex = 55;
            this.lblLastName.Text = "Họ :";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(18, 358);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(985, 313);
            this.dgvCustomers.TabIndex = 52;
            this.dgvCustomers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_RowEnter);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.BackColor = System.Drawing.Color.Gold;
            this.btnEditCustomer.FlatAppearance.BorderSize = 0;
            this.btnEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnEditCustomer.Image = global::GUI.Properties.Resources.icons8_Edit_26px;
            this.btnEditCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCustomer.Location = new System.Drawing.Point(158, 262);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(134, 40);
            this.btnEditCustomer.TabIndex = 1;
            this.btnEditCustomer.Text = "   Sửa";
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
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
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "   Ghi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(150)))));
            this.btnSearchCustomer.FlatAppearance.BorderSize = 0;
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.ForeColor = System.Drawing.Color.White;
            this.btnSearchCustomer.Image = global::GUI.Properties.Resources.icons8_Search_26px;
            this.btnSearchCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomer.Location = new System.Drawing.Point(852, 262);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(151, 40);
            this.btnSearchCustomer.TabIndex = 5;
            this.btnSearchCustomer.Text = "     Tìm kiếm";
            this.btnSearchCustomer.UseVisualStyleBackColor = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.Red;
            this.btnDeleteCustomer.FlatAppearance.BorderSize = 0;
            this.btnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCustomer.Image = global::GUI.Properties.Resources.icons8_Trash_Can_26px;
            this.btnDeleteCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(298, 262);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(134, 40);
            this.btnDeleteCustomer.TabIndex = 2;
            this.btnDeleteCustomer.Text = "   Xóa";
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Image = global::GUI.Properties.Resources.icons8_Plus_Math_26px;
            this.btnAddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCustomer.Location = new System.Drawing.Point(18, 262);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(134, 40);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "   Thêm";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // CustomerManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbInfoCustomer);
            this.Controls.Add(this.lblListCustomer);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblTitlePage);
            this.Name = "CustomerManagementPage";
            this.Size = new System.Drawing.Size(1020, 684);
            this.Load += new System.EventHandler(this.CustomerManagementPage_Load);
            this.grbInfoCustomer.ResumeLayout(false);
            this.grbInfoCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblListCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblTitlePage;
        private System.Windows.Forms.GroupBox grbInfoCustomer;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnEditCustomer;
    }
}
