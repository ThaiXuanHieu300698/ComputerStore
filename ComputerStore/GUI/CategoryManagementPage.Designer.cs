namespace GUI
{
    partial class CategoryManagementPage
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
            this.grbInfoCategory = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblListCategory = new System.Windows.Forms.Label();
            this.txtSearchCategory = new System.Windows.Forms.TextBox();
            this.lblTitlePage = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearchCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.grbInfoCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInfoCategory
            // 
            this.grbInfoCategory.Controls.Add(this.txtDescription);
            this.grbInfoCategory.Controls.Add(this.lblDescription);
            this.grbInfoCategory.Controls.Add(this.txtCategoryName);
            this.grbInfoCategory.Controls.Add(this.lblCategoryName);
            this.grbInfoCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfoCategory.Location = new System.Drawing.Point(18, 66);
            this.grbInfoCategory.Name = "grbInfoCategory";
            this.grbInfoCategory.Size = new System.Drawing.Size(985, 178);
            this.grbInfoCategory.TabIndex = 66;
            this.grbInfoCategory.TabStop = false;
            this.grbInfoCategory.Text = "Thông tin danh mục";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(577, 46);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(402, 34);
            this.txtDescription.TabIndex = 56;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(481, 48);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(90, 32);
            this.lblDescription.TabIndex = 55;
            this.lblDescription.Text = "Mô tả :";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(191, 46);
            this.txtCategoryName.Multiline = true;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(265, 34);
            this.txtCategoryName.TabIndex = 56;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(6, 47);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(179, 32);
            this.lblCategoryName.TabIndex = 55;
            this.lblCategoryName.Text = "Tên danh mục :";
            // 
            // lblListCategory
            // 
            this.lblListCategory.AutoSize = true;
            this.lblListCategory.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblListCategory.Location = new System.Drawing.Point(359, 312);
            this.lblListCategory.Name = "lblListCategory";
            this.lblListCategory.Size = new System.Drawing.Size(290, 38);
            this.lblListCategory.TabIndex = 65;
            this.lblListCategory.Text = "Danh sách danh mục";
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCategory.ForeColor = System.Drawing.Color.Black;
            this.txtSearchCategory.Location = new System.Drawing.Point(578, 262);
            this.txtSearchCategory.Multiline = true;
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.Size = new System.Drawing.Size(268, 40);
            this.txtSearchCategory.TabIndex = 63;
            this.txtSearchCategory.Text = "Nhập tên danh mục...";
            // 
            // lblTitlePage
            // 
            this.lblTitlePage.AutoSize = true;
            this.lblTitlePage.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitlePage.Location = new System.Drawing.Point(317, 9);
            this.lblTitlePage.Name = "lblTitlePage";
            this.lblTitlePage.Size = new System.Drawing.Size(391, 38);
            this.lblTitlePage.TabIndex = 59;
            this.lblTitlePage.Text = "Quản lý danh mục sản phẩm";
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
            this.btnSave.TabIndex = 67;
            this.btnSave.Text = "   Ghi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(150)))));
            this.btnSearchCategory.FlatAppearance.BorderSize = 0;
            this.btnSearchCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCategory.ForeColor = System.Drawing.Color.White;
            this.btnSearchCategory.Image = global::GUI.Properties.Resources.icons8_Search_26px;
            this.btnSearchCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCategory.Location = new System.Drawing.Point(852, 262);
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Size = new System.Drawing.Size(151, 40);
            this.btnSearchCategory.TabIndex = 64;
            this.btnSearchCategory.Text = "     Tìm kiếm";
            this.btnSearchCategory.UseVisualStyleBackColor = false;
            this.btnSearchCategory.Click += new System.EventHandler(this.btnSearchCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.Red;
            this.btnDeleteCategory.FlatAppearance.BorderSize = 0;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Image = global::GUI.Properties.Resources.icons8_Trash_Can_26px;
            this.btnDeleteCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCategory.Location = new System.Drawing.Point(298, 262);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(134, 40);
            this.btnDeleteCategory.TabIndex = 62;
            this.btnDeleteCategory.Text = "   Xóa";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Image = global::GUI.Properties.Resources.icons8_Plus_Math_26px;
            this.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.Location = new System.Drawing.Point(18, 262);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(134, 40);
            this.btnAddCategory.TabIndex = 60;
            this.btnAddCategory.Text = "   Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Location = new System.Drawing.Point(18, 358);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowTemplate.Height = 24;
            this.dgvCategories.Size = new System.Drawing.Size(985, 313);
            this.dgvCategories.TabIndex = 68;
            this.dgvCategories.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategories_RowEnter);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.BackColor = System.Drawing.Color.Gold;
            this.btnEditCategory.FlatAppearance.BorderSize = 0;
            this.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCategory.ForeColor = System.Drawing.Color.Black;
            this.btnEditCategory.Image = global::GUI.Properties.Resources.icons8_Edit_26px;
            this.btnEditCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCategory.Location = new System.Drawing.Point(158, 262);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(134, 40);
            this.btnEditCategory.TabIndex = 69;
            this.btnEditCategory.Text = "   Sửa";
            this.btnEditCategory.UseVisualStyleBackColor = false;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // CategoryManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnEditCategory);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbInfoCategory);
            this.Controls.Add(this.lblListCategory);
            this.Controls.Add(this.btnSearchCategory);
            this.Controls.Add(this.txtSearchCategory);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.lblTitlePage);
            this.Name = "CategoryManagementPage";
            this.Size = new System.Drawing.Size(1020, 684);
            this.Load += new System.EventHandler(this.CategoryManagementPage_Load);
            this.grbInfoCategory.ResumeLayout(false);
            this.grbInfoCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grbInfoCategory;
        private System.Windows.Forms.Label lblListCategory;
        private System.Windows.Forms.Button btnSearchCategory;
        private System.Windows.Forms.TextBox txtSearchCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label lblTitlePage;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
    }
}
