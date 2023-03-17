namespace GUI
{
    partial class ProductManagementPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.lblTitlePage = new System.Windows.Forms.Label();
            this.grbInfoProduct = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.picImageProduct = new System.Windows.Forms.PictureBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lblListProduct = new System.Windows.Forms.Label();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.grbInfoProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.ForeColor = System.Drawing.Color.Black;
            this.txtSearchProduct.Location = new System.Drawing.Point(578, 262);
            this.txtSearchProduct.Multiline = true;
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(268, 40);
            this.txtSearchProduct.TabIndex = 43;
            this.txtSearchProduct.Text = "Nhập tên sản phẩm...";
            // 
            // lblTitlePage
            // 
            this.lblTitlePage.AutoSize = true;
            this.lblTitlePage.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitlePage.Location = new System.Drawing.Point(379, 9);
            this.lblTitlePage.Name = "lblTitlePage";
            this.lblTitlePage.Size = new System.Drawing.Size(253, 38);
            this.lblTitlePage.TabIndex = 39;
            this.lblTitlePage.Text = "Quản lý sản phẩm";
            // 
            // grbInfoProduct
            // 
            this.grbInfoProduct.Controls.Add(this.lblDescription);
            this.grbInfoProduct.Controls.Add(this.btnChangeImage);
            this.grbInfoProduct.Controls.Add(this.picImageProduct);
            this.grbInfoProduct.Controls.Add(this.lbl);
            this.grbInfoProduct.Controls.Add(this.txtUnit);
            this.grbInfoProduct.Controls.Add(this.lblUnit);
            this.grbInfoProduct.Controls.Add(this.txtDescription);
            this.grbInfoProduct.Controls.Add(this.txtPrice);
            this.grbInfoProduct.Controls.Add(this.lblPrice);
            this.grbInfoProduct.Controls.Add(this.cbSupplier);
            this.grbInfoProduct.Controls.Add(this.lblSupplier);
            this.grbInfoProduct.Controls.Add(this.cbCategories);
            this.grbInfoProduct.Controls.Add(this.lblCategories);
            this.grbInfoProduct.Controls.Add(this.txtProductName);
            this.grbInfoProduct.Controls.Add(this.lblProductName);
            this.grbInfoProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfoProduct.Location = new System.Drawing.Point(18, 66);
            this.grbInfoProduct.Name = "grbInfoProduct";
            this.grbInfoProduct.Size = new System.Drawing.Size(985, 178);
            this.grbInfoProduct.TabIndex = 48;
            this.grbInfoProduct.TabStop = false;
            this.grbInfoProduct.Text = "Thông tin sản phẩm";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(414, 46);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(90, 32);
            this.lblDescription.TabIndex = 71;
            this.lblDescription.Text = "Mô tả :";
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeImage.ForeColor = System.Drawing.Color.Black;
            this.btnChangeImage.Image = global::GUI.Properties.Resources.icons8_Edit_26px;
            this.btnChangeImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeImage.Location = new System.Drawing.Point(762, 132);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(45, 38);
            this.btnChangeImage.TabIndex = 70;
            this.btnChangeImage.UseVisualStyleBackColor = false;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeIamge_Click);
            // 
            // picImageProduct
            // 
            this.picImageProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImageProduct.Location = new System.Drawing.Point(760, 18);
            this.picImageProduct.Name = "picImageProduct";
            this.picImageProduct.Size = new System.Drawing.Size(219, 154);
            this.picImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageProduct.TabIndex = 68;
            this.picImageProduct.TabStop = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(677, 89);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(65, 32);
            this.lbl.TabIndex = 66;
            this.lbl.Text = "VND";
            // 
            // txtUnit
            // 
            this.txtUnit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.Location = new System.Drawing.Point(535, 131);
            this.txtUnit.Multiline = true;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(136, 34);
            this.txtUnit.TabIndex = 65;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(414, 132);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(108, 32);
            this.lblUnit.TabIndex = 64;
            this.lblUnit.Text = "ĐV tính :";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(535, 46);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(207, 34);
            this.txtDescription.TabIndex = 63;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(535, 89);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(136, 34);
            this.txtPrice.TabIndex = 63;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(414, 90);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(61, 32);
            this.lblPrice.TabIndex = 62;
            this.lblPrice.Text = "Giá :";
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(188, 128);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(207, 36);
            this.cbSupplier.TabIndex = 61;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(6, 132);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(175, 32);
            this.lblSupplier.TabIndex = 60;
            this.lblSupplier.Text = "Nhà cung cấp :";
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(188, 86);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(207, 36);
            this.cbCategories.TabIndex = 59;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.Location = new System.Drawing.Point(6, 87);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(137, 32);
            this.lblCategories.TabIndex = 57;
            this.lblCategories.Text = "Danh mục :";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(188, 45);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(207, 34);
            this.txtProductName.TabIndex = 56;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(6, 47);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(176, 32);
            this.lblProductName.TabIndex = 55;
            this.lblProductName.Text = "Tên sản phẩm :";
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
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "   Ghi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(150)))));
            this.btnSearchProduct.FlatAppearance.BorderSize = 0;
            this.btnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProduct.ForeColor = System.Drawing.Color.White;
            this.btnSearchProduct.Image = global::GUI.Properties.Resources.icons8_Search_26px;
            this.btnSearchProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchProduct.Location = new System.Drawing.Point(852, 262);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(151, 40);
            this.btnSearchProduct.TabIndex = 44;
            this.btnSearchProduct.Text = "     Tìm kiếm";
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Red;
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Image = global::GUI.Properties.Resources.icons8_Trash_Can_26px;
            this.btnDeleteProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProduct.Location = new System.Drawing.Point(298, 262);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(134, 40);
            this.btnDeleteProduct.TabIndex = 42;
            this.btnDeleteProduct.Text = "   Xóa";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Image = global::GUI.Properties.Resources.icons8_Plus_Math_26px;
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.Location = new System.Drawing.Point(18, 262);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(134, 40);
            this.btnAddProduct.TabIndex = 40;
            this.btnAddProduct.Text = "   Thêm";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(18, 358);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(985, 313);
            this.dgvProducts.TabIndex = 51;
            this.dgvProducts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_RowEnter);
            // 
            // lblListProduct
            // 
            this.lblListProduct.AutoSize = true;
            this.lblListProduct.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblListProduct.Location = new System.Drawing.Point(359, 312);
            this.lblListProduct.Name = "lblListProduct";
            this.lblListProduct.Size = new System.Drawing.Size(287, 38);
            this.lblListProduct.TabIndex = 45;
            this.lblListProduct.Text = "Danh sách sản phẩm";
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.Gold;
            this.btnEditProduct.FlatAppearance.BorderSize = 0;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.ForeColor = System.Drawing.Color.Black;
            this.btnEditProduct.Image = global::GUI.Properties.Resources.icons8_Edit_26px;
            this.btnEditProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProduct.Location = new System.Drawing.Point(158, 262);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(134, 40);
            this.btnEditProduct.TabIndex = 41;
            this.btnEditProduct.Text = "   Sửa";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // ProductManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbInfoProduct);
            this.Controls.Add(this.lblListProduct);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lblTitlePage);
            this.Name = "ProductManagementPage";
            this.Size = new System.Drawing.Size(1020, 684);
            this.Load += new System.EventHandler(this.ProductManagementPage_Load);
            this.grbInfoProduct.ResumeLayout(false);
            this.grbInfoProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblTitlePage;
        private System.Windows.Forms.GroupBox grbInfoProduct;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picImageProduct;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnChangeImage;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblListProduct;
        private System.Windows.Forms.Button btnEditProduct;
    }
}
