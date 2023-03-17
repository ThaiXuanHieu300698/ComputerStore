using DTO;

namespace GUI
{
    partial class frmAdmin
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
        private void InitializeComponent(UsersDTO user)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.pnlWrap = new System.Windows.Forms.Panel();
            this.Separator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.Separator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.Separator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pnlLeft = new System.Windows.Forms.Panel();

            this.userPage = new GUI.UserPage(user);
            this.categoryManagementPage = new GUI.CategoryManagementPage();
            this.ordersManagementPage = new GUI.OrdersManagementPage();
            this.productManagementPage = new GUI.ProductManagementPage();
            this.customerManagementPage = new GUI.CustomerManagementPage();
            this.supplierManagementPage = new GUI.SupplierManagementPage();
            this.warehouseManagementPage = new GUI.WarehouseManagementPage();

            this.btnWarehouseManagementPage = new System.Windows.Forms.Button();
            this.btnSupplierManagementPage = new System.Windows.Forms.Button();
            this.btnCustomerManagementPage = new System.Windows.Forms.Button();
            this.btnCategoryManagementPage = new System.Windows.Forms.Button();
            this.btnProductManagementPage = new System.Windows.Forms.Button();
            this.btnCreateOrdersPage = new System.Windows.Forms.Button();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.pnlBottom.Controls.Add(this.lblCopyright);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(317, 730);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1020, 43);
            this.pnlBottom.TabIndex = 5;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.White;
            this.lblCopyright.Location = new System.Drawing.Point(438, 6);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(183, 28);
            this.lblCopyright.TabIndex = 0;
            this.lblCopyright.Text = "Designed by XTeam";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.pnlTop.Controls.Add(this.btnMenu);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1337, 46);
            this.pnlTop.TabIndex = 3;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(12, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(55, 40);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 3;
            this.btnMenu.TabStop = false;
            // userPage
            this.userPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPage.Location = new System.Drawing.Point(0, 0);
            this.userPage.Name = "userPage";
            this.userPage.Size = new System.Drawing.Size(1020, 684);
            this.userPage.TabIndex = 1;
            // 
            // ordersManagementPage
            // 
            this.ordersManagementPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersManagementPage.Location = new System.Drawing.Point(0, 0);
            this.ordersManagementPage.Name = "ordersManagementPage";
            this.ordersManagementPage.Size = new System.Drawing.Size(1020, 684);
            this.ordersManagementPage.TabIndex = 2;
            // productManagementPage
            this.productManagementPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productManagementPage.Location = new System.Drawing.Point(0, 0);
            this.productManagementPage.Name = "productManagementPage";
            this.productManagementPage.Size = new System.Drawing.Size(1020, 684);
            this.productManagementPage.TabIndex = 3;
            // customerManagementPage
            this.customerManagementPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerManagementPage.Location = new System.Drawing.Point(0, 0);
            this.customerManagementPage.Name = "customerManagementPage";
            this.customerManagementPage.Size = new System.Drawing.Size(1020, 684);
            this.customerManagementPage.TabIndex = 5;
            // supplierManagementPage
            this.supplierManagementPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierManagementPage.Location = new System.Drawing.Point(0, 0);
            this.supplierManagementPage.Name = "supplierManagementPage";
            this.supplierManagementPage.Size = new System.Drawing.Size(1020, 684);
            this.supplierManagementPage.TabIndex = 6;
            // warehouseManagementPage
            this.warehouseManagementPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warehouseManagementPage.Location = new System.Drawing.Point(0, 0);
            this.warehouseManagementPage.Name = "warehouseManagementPage";
            this.warehouseManagementPage.Size = new System.Drawing.Size(1020, 684);
            this.warehouseManagementPage.TabIndex = 7;
            // 
            // categoryManagementPage
            // 
            this.categoryManagementPage.Location = new System.Drawing.Point(0, 0);
            this.categoryManagementPage.Name = "categoryManagementPage";
            this.categoryManagementPage.Size = new System.Drawing.Size(1020, 684);
            this.categoryManagementPage.TabIndex = 4;


            // 
            // pnlWrap
            // 
            this.pnlWrap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWrap.Location = new System.Drawing.Point(317, 46);
            this.pnlWrap.Name = "pnlWrap";
            this.pnlWrap.Size = new System.Drawing.Size(1020, 684);
            this.pnlWrap.TabIndex = 0;

            this.pnlWrap.Controls.Add(this.userPage);
            this.pnlWrap.Controls.Add(this.categoryManagementPage);
            this.pnlWrap.Controls.Add(this.ordersManagementPage);
            this.pnlWrap.Controls.Add(this.productManagementPage);
            this.pnlWrap.Controls.Add(this.customerManagementPage);
            this.pnlWrap.Controls.Add(this.supplierManagementPage);
            this.pnlWrap.Controls.Add(this.warehouseManagementPage);

            // 
            // Separator1
            // 
            this.Separator1.BackColor = System.Drawing.Color.Transparent;
            this.Separator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Separator1.LineThickness = 1;
            this.Separator1.Location = new System.Drawing.Point(10, 68);
            this.Separator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(297, 43);
            this.Separator1.TabIndex = 0;
            this.Separator1.Transparency = 255;
            this.Separator1.Vertical = false;
            // 
            // Separator2
            // 
            this.Separator2.BackColor = System.Drawing.Color.Transparent;
            this.Separator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Separator2.LineThickness = 1;
            this.Separator2.Location = new System.Drawing.Point(10, 671);
            this.Separator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(297, 43);
            this.Separator2.TabIndex = 1;
            this.Separator2.Transparency = 255;
            this.Separator2.Vertical = false;
            // 
            // picAvatar
            // 
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(13, 6);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(63, 55);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 2;
            this.picAvatar.TabStop = false;
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUser.ForeColor = System.Drawing.Color.Black;
            this.lblNameUser.Location = new System.Drawing.Point(82, 16);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(206, 38);
            this.lblNameUser.TabIndex = 3;
            this.lblNameUser.Text = "Thái Xuân Hiếu";
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(10, 104);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(140, 40);
            this.btnProfile.TabIndex = 9;
            this.btnProfile.Text = "Hồ sơ";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(165, 104);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(140, 40);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Separator3
            // 
            this.Separator3.BackColor = System.Drawing.Color.Transparent;
            this.Separator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Separator3.LineThickness = 1;
            this.Separator3.Location = new System.Drawing.Point(8, 151);
            this.Separator3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Separator3.Name = "Separator3";
            this.Separator3.Size = new System.Drawing.Size(297, 43);
            this.Separator3.TabIndex = 12;
            this.Separator3.Transparency = 255;
            this.Separator3.Vertical = false;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.btnWarehouseManagementPage);
            this.pnlLeft.Controls.Add(this.btnSupplierManagementPage);
            this.pnlLeft.Controls.Add(this.btnCustomerManagementPage);
            this.pnlLeft.Controls.Add(this.btnCategoryManagementPage);
            this.pnlLeft.Controls.Add(this.btnProductManagementPage);
            this.pnlLeft.Controls.Add(this.btnCreateOrdersPage);
            this.pnlLeft.Controls.Add(this.Separator3);
            this.pnlLeft.Controls.Add(this.btnLogout);
            this.pnlLeft.Controls.Add(this.btnProfile);
            this.pnlLeft.Controls.Add(this.lblNameUser);
            this.pnlLeft.Controls.Add(this.picAvatar);
            this.pnlLeft.Controls.Add(this.Separator2);
            this.pnlLeft.Controls.Add(this.Separator1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 46);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(317, 727);
            this.pnlLeft.TabIndex = 4;
            // 
            // btnWarehouseManagementPage
            // 
            this.btnWarehouseManagementPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnWarehouseManagementPage.FlatAppearance.BorderSize = 0;
            this.btnWarehouseManagementPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarehouseManagementPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWarehouseManagementPage.ForeColor = System.Drawing.Color.White;
            this.btnWarehouseManagementPage.Location = new System.Drawing.Point(10, 487);
            this.btnWarehouseManagementPage.Name = "btnWarehouseManagementPage";
            this.btnWarehouseManagementPage.Size = new System.Drawing.Size(295, 61);
            this.btnWarehouseManagementPage.TabIndex = 13;
            this.btnWarehouseManagementPage.Text = "Quản lý Kho";
            this.btnWarehouseManagementPage.UseVisualStyleBackColor = false;
            this.btnWarehouseManagementPage.Click += new System.EventHandler(this.btnWarehouseManagementPage_Click);
            // 
            // btnSupplierManagementPage
            // 
            this.btnSupplierManagementPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnSupplierManagementPage.FlatAppearance.BorderSize = 0;
            this.btnSupplierManagementPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplierManagementPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierManagementPage.ForeColor = System.Drawing.Color.White;
            this.btnSupplierManagementPage.Location = new System.Drawing.Point(10, 430);
            this.btnSupplierManagementPage.Name = "btnSupplierManagementPage";
            this.btnSupplierManagementPage.Size = new System.Drawing.Size(295, 61);
            this.btnSupplierManagementPage.TabIndex = 13;
            this.btnSupplierManagementPage.Text = "Quản lý Nhà cung cấp";
            this.btnSupplierManagementPage.UseVisualStyleBackColor = false;
            this.btnSupplierManagementPage.Click += new System.EventHandler(this.btnSupplierManagementPage_Click);
            // 
            // btnCustomerManagementPage
            // 
            this.btnCustomerManagementPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnCustomerManagementPage.FlatAppearance.BorderSize = 0;
            this.btnCustomerManagementPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerManagementPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerManagementPage.ForeColor = System.Drawing.Color.White;
            this.btnCustomerManagementPage.Location = new System.Drawing.Point(10, 372);
            this.btnCustomerManagementPage.Name = "btnCustomerManagementPage";
            this.btnCustomerManagementPage.Size = new System.Drawing.Size(295, 61);
            this.btnCustomerManagementPage.TabIndex = 13;
            this.btnCustomerManagementPage.Text = "Quản lý Khách hàng";
            this.btnCustomerManagementPage.UseVisualStyleBackColor = false;
            this.btnCustomerManagementPage.Click += new System.EventHandler(this.btnCustomerManagementPage_Click);
            // 
            // btnCategoryManagementPage
            // 
            this.btnCategoryManagementPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnCategoryManagementPage.FlatAppearance.BorderSize = 0;
            this.btnCategoryManagementPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryManagementPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryManagementPage.ForeColor = System.Drawing.Color.White;
            this.btnCategoryManagementPage.Location = new System.Drawing.Point(10, 315);
            this.btnCategoryManagementPage.Name = "btnCategoryManagementPage";
            this.btnCategoryManagementPage.Size = new System.Drawing.Size(295, 61);
            this.btnCategoryManagementPage.TabIndex = 13;
            this.btnCategoryManagementPage.Text = "Quản lý Danh mục SP";
            this.btnCategoryManagementPage.UseVisualStyleBackColor = false;
            this.btnCategoryManagementPage.Click += new System.EventHandler(this.btnCategoryManagementPage_Click);
            // 
            // btnProductManagementPage
            // 
            this.btnProductManagementPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnProductManagementPage.FlatAppearance.BorderSize = 0;
            this.btnProductManagementPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductManagementPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductManagementPage.ForeColor = System.Drawing.Color.White;
            this.btnProductManagementPage.Location = new System.Drawing.Point(10, 258);
            this.btnProductManagementPage.Name = "btnProductManagementPage";
            this.btnProductManagementPage.Size = new System.Drawing.Size(295, 61);
            this.btnProductManagementPage.TabIndex = 13;
            this.btnProductManagementPage.Text = "Quản lý Sản phẩm";
            this.btnProductManagementPage.UseVisualStyleBackColor = false;
            this.btnProductManagementPage.Click += new System.EventHandler(this.btnProductManagementPage_Click);
            // 
            // btnCreateOrdersPage
            // 
            this.btnCreateOrdersPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnCreateOrdersPage.FlatAppearance.BorderSize = 0;
            this.btnCreateOrdersPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateOrdersPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrdersPage.ForeColor = System.Drawing.Color.White;
            this.btnCreateOrdersPage.Location = new System.Drawing.Point(10, 201);
            this.btnCreateOrdersPage.Name = "btnCreateOrdersPage";
            this.btnCreateOrdersPage.Size = new System.Drawing.Size(295, 61);
            this.btnCreateOrdersPage.TabIndex = 13;
            this.btnCreateOrdersPage.Text = "Quản lý Hóa Đơn";
            this.btnCreateOrdersPage.UseVisualStyleBackColor = false;
            this.btnCreateOrdersPage.Click += new System.EventHandler(this.btnCreateOrdersPage_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 773);
            this.Controls.Add(this.pnlWrap);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Store";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel pnlWrap;
        private Bunifu.Framework.UI.BunifuSeparator Separator1;
        private Bunifu.Framework.UI.BunifuSeparator Separator2;
        private Bunifu.Framework.UI.BunifuSeparator Separator3;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnCreateOrdersPage;
        private System.Windows.Forms.Button btnWarehouseManagementPage;
        private System.Windows.Forms.Button btnSupplierManagementPage;
        private System.Windows.Forms.Button btnCustomerManagementPage;
        private System.Windows.Forms.Button btnCategoryManagementPage;
        private System.Windows.Forms.Button btnProductManagementPage;
        private UserPage userPage;
        private WarehouseManagementPage warehouseManagementPage;
        private SupplierManagementPage supplierManagementPage;
        private ProductManagementPage productManagementPage;
        private OrdersManagementPage ordersManagementPage;
        private CustomerManagementPage customerManagementPage;
        private CategoryManagementPage categoryManagementPage;

    }
}