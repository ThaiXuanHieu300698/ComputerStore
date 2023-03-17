namespace GUI
{
    partial class WarehouseManagementPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitlePage = new System.Windows.Forms.Label();
            this.btnPrinter = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.llbListReceipt = new System.Windows.Forms.LinkLabel();
            this.lblListProductInventory = new System.Windows.Forms.Label();
            this.dgvListProductInventory = new System.Windows.Forms.DataGridView();
            this.dgvReceiptDetails = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.btnCreateReceipts = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.grbInfoOrders = new System.Windows.Forms.GroupBox();
            this.cbCompanyName = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pnlListReceipt = new System.Windows.Forms.Panel();
            this.btnSearchReceipts = new System.Windows.Forms.Button();
            this.txtSearchOrders = new System.Windows.Forms.TextBox();
            this.btnDeleteReceipts = new System.Windows.Forms.Button();
            this.btnAddReceipts = new System.Windows.Forms.Button();
            this.dgvListReceipt = new System.Windows.Forms.DataGridView();
            this.llbBack = new System.Windows.Forms.LinkLabel();
            this.lblListOrders = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProductInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptDetails)).BeginInit();
            this.grbInfoOrders.SuspendLayout();
            this.pnlListReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListReceipt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlePage
            // 
            this.lblTitlePage.AutoSize = true;
            this.lblTitlePage.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitlePage.Location = new System.Drawing.Point(410, 9);
            this.lblTitlePage.Name = "lblTitlePage";
            this.lblTitlePage.Size = new System.Drawing.Size(223, 38);
            this.lblTitlePage.TabIndex = 31;
            this.lblTitlePage.Text = "Nhập sản phẩm";
            // 
            // btnPrinter
            // 
            this.btnPrinter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnPrinter.FlatAppearance.BorderSize = 0;
            this.btnPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrinter.ForeColor = System.Drawing.Color.White;
            this.btnPrinter.Image = global::GUI.Properties.Resources.icons8_Print_26px;
            this.btnPrinter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrinter.Location = new System.Drawing.Point(827, 641);
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.Size = new System.Drawing.Size(176, 40);
            this.btnPrinter.TabIndex = 74;
            this.btnPrinter.Text = "      In hóa đơn";
            this.btnPrinter.UseVisualStyleBackColor = false;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(353, 641);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 32);
            this.lblAmount.TabIndex = 86;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(215, 644);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(130, 32);
            this.lblTotalAmount.TabIndex = 85;
            this.lblTotalAmount.Text = "Tổng tiền :";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(504, 644);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(65, 32);
            this.lbl2.TabIndex = 84;
            this.lbl2.Text = "VND";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Image = global::GUI.Properties.Resources.icons8_Paper_Money_26px;
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(16, 641);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(193, 40);
            this.btnPay.TabIndex = 73;
            this.btnPay.Text = "      Thanh Toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // llbListReceipt
            // 
            this.llbListReceipt.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llbListReceipt.AutoSize = true;
            this.llbListReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbListReceipt.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llbListReceipt.Location = new System.Drawing.Point(13, 9);
            this.llbListReceipt.Name = "llbListReceipt";
            this.llbListReceipt.Size = new System.Drawing.Size(251, 25);
            this.llbListReceipt.TabIndex = 83;
            this.llbListReceipt.TabStop = true;
            this.llbListReceipt.Text = "Xem danh sách phiếu nhập";
            this.llbListReceipt.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llbListReceipt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbListReceipt_LinkClicked);
            // 
            // lblListProductInventory
            // 
            this.lblListProductInventory.AutoSize = true;
            this.lblListProductInventory.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListProductInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblListProductInventory.Location = new System.Drawing.Point(628, 309);
            this.lblListProductInventory.Name = "lblListProductInventory";
            this.lblListProductInventory.Size = new System.Drawing.Size(259, 38);
            this.lblListProductInventory.TabIndex = 82;
            this.lblListProductInventory.Text = "Sản phẩm tồn kho";
            // 
            // dgvListProductInventory
            // 
            this.dgvListProductInventory.AllowUserToAddRows = false;
            this.dgvListProductInventory.AllowUserToDeleteRows = false;
            this.dgvListProductInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListProductInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListProductInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProductInventory.Location = new System.Drawing.Point(513, 350);
            this.dgvListProductInventory.Name = "dgvListProductInventory";
            this.dgvListProductInventory.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListProductInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListProductInventory.RowTemplate.Height = 24;
            this.dgvListProductInventory.Size = new System.Drawing.Size(490, 286);
            this.dgvListProductInventory.TabIndex = 80;
            this.dgvListProductInventory.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListProductInventory_RowEnter);
            // 
            // dgvReceiptDetails
            // 
            this.dgvReceiptDetails.AllowUserToAddRows = false;
            this.dgvReceiptDetails.AllowUserToDeleteRows = false;
            this.dgvReceiptDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceiptDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReceiptDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiptDetails.Location = new System.Drawing.Point(16, 350);
            this.dgvReceiptDetails.Name = "dgvReceiptDetails";
            this.dgvReceiptDetails.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceiptDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReceiptDetails.RowTemplate.Height = 24;
            this.dgvReceiptDetails.Size = new System.Drawing.Size(490, 286);
            this.dgvReceiptDetails.TabIndex = 81;
            this.dgvReceiptDetails.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceiptDetails_RowEnter);
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
            this.btnSave.TabIndex = 71;
            this.btnSave.Text = "   Ghi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOrderDetails.Location = new System.Drawing.Point(140, 309);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(268, 38);
            this.lblOrderDetails.TabIndex = 79;
            this.lblOrderDetails.Text = "Chi tiết phiếu nhập";
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
            this.btnSearchProduct.TabIndex = 72;
            this.btnSearchProduct.Text = "     Tìm kiếm";
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.ForeColor = System.Drawing.Color.Black;
            this.txtSearchProduct.Location = new System.Drawing.Point(578, 262);
            this.txtSearchProduct.Multiline = true;
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(268, 40);
            this.txtSearchProduct.TabIndex = 78;
            this.txtSearchProduct.Text = "Nhập tên sản phẩm...";
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.Red;
            this.btnDeleteOrder.FlatAppearance.BorderSize = 0;
            this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.White;
            this.btnDeleteOrder.Image = global::GUI.Properties.Resources.icons8_Trash_Can_26px;
            this.btnDeleteOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteOrder.Location = new System.Drawing.Point(298, 262);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(134, 40);
            this.btnDeleteOrder.TabIndex = 70;
            this.btnDeleteOrder.Text = "   Xóa";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.BackColor = System.Drawing.Color.Gold;
            this.btnEditOrder.FlatAppearance.BorderSize = 0;
            this.btnEditOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOrder.ForeColor = System.Drawing.Color.Black;
            this.btnEditOrder.Image = global::GUI.Properties.Resources.icons8_Edit_26px;
            this.btnEditOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditOrder.Location = new System.Drawing.Point(158, 262);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(134, 40);
            this.btnEditOrder.TabIndex = 69;
            this.btnEditOrder.Text = "   Sửa";
            this.btnEditOrder.UseVisualStyleBackColor = false;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // btnCreateReceipts
            // 
            this.btnCreateReceipts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnCreateReceipts.FlatAppearance.BorderSize = 0;
            this.btnCreateReceipts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateReceipts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateReceipts.ForeColor = System.Drawing.Color.White;
            this.btnCreateReceipts.Image = global::GUI.Properties.Resources.icons8_Purchase_Order_26px;
            this.btnCreateReceipts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateReceipts.Location = new System.Drawing.Point(799, 20);
            this.btnCreateReceipts.Name = "btnCreateReceipts";
            this.btnCreateReceipts.Size = new System.Drawing.Size(204, 40);
            this.btnCreateReceipts.TabIndex = 77;
            this.btnCreateReceipts.Text = "      Tạo phiếu nhập";
            this.btnCreateReceipts.UseVisualStyleBackColor = false;
            this.btnCreateReceipts.Click += new System.EventHandler(this.btnCreateReceipts_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddOrder.FlatAppearance.BorderSize = 0;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.Image = global::GUI.Properties.Resources.icons8_Plus_Math_26px;
            this.btnAddOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddOrder.Location = new System.Drawing.Point(18, 262);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(134, 40);
            this.btnAddOrder.TabIndex = 68;
            this.btnAddOrder.Text = "   Thêm";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // grbInfoOrders
            // 
            this.grbInfoOrders.Controls.Add(this.cbCompanyName);
            this.grbInfoOrders.Controls.Add(this.lblAddress);
            this.grbInfoOrders.Controls.Add(this.lblPhone);
            this.grbInfoOrders.Controls.Add(this.lblCompanyName);
            this.grbInfoOrders.Controls.Add(this.cbProducts);
            this.grbInfoOrders.Controls.Add(this.txtAddress);
            this.grbInfoOrders.Controls.Add(this.lbl1);
            this.grbInfoOrders.Controls.Add(this.txtPhone);
            this.grbInfoOrders.Controls.Add(this.txtQuantity);
            this.grbInfoOrders.Controls.Add(this.txtPrice);
            this.grbInfoOrders.Controls.Add(this.lblQuantity);
            this.grbInfoOrders.Controls.Add(this.lblPrice);
            this.grbInfoOrders.Controls.Add(this.lblProductName);
            this.grbInfoOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfoOrders.Location = new System.Drawing.Point(18, 66);
            this.grbInfoOrders.Name = "grbInfoOrders";
            this.grbInfoOrders.Size = new System.Drawing.Size(985, 178);
            this.grbInfoOrders.TabIndex = 76;
            this.grbInfoOrders.TabStop = false;
            this.grbInfoOrders.Text = "Thông tin hóa đơn";
            // 
            // cbCompanyName
            // 
            this.cbCompanyName.FormattingEnabled = true;
            this.cbCompanyName.Location = new System.Drawing.Point(666, 46);
            this.cbCompanyName.Name = "cbCompanyName";
            this.cbCompanyName.Size = new System.Drawing.Size(259, 36);
            this.cbCompanyName.TabIndex = 70;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(508, 88);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 32);
            this.lblAddress.TabIndex = 69;
            this.lblAddress.Text = "Địa chỉ :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(508, 130);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(70, 32);
            this.lblPhone.TabIndex = 69;
            this.lblPhone.Text = "SĐT :";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(508, 47);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(152, 32);
            this.lblCompanyName.TabIndex = 69;
            this.lblCompanyName.Text = "Tên công ty :";
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(188, 46);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(226, 36);
            this.cbProducts.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(666, 88);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(259, 34);
            this.txtAddress.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(349, 133);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(65, 32);
            this.lbl1.TabIndex = 66;
            this.lbl1.Text = "VND";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(666, 130);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(259, 34);
            this.txtPhone.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(188, 89);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(136, 34);
            this.txtQuantity.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(188, 131);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(136, 34);
            this.txtPrice.TabIndex = 2;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(6, 91);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(123, 32);
            this.lblQuantity.TabIndex = 62;
            this.lblQuantity.Text = "Số lượng :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(6, 133);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(61, 32);
            this.lblPrice.TabIndex = 62;
            this.lblPrice.Text = "Giá :";
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
            // Timer
            // 
            this.Timer.Interval = 30;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // pnlListReceipt
            // 
            this.pnlListReceipt.Controls.Add(this.btnSearchReceipts);
            this.pnlListReceipt.Controls.Add(this.txtSearchOrders);
            this.pnlListReceipt.Controls.Add(this.btnDeleteReceipts);
            this.pnlListReceipt.Controls.Add(this.btnAddReceipts);
            this.pnlListReceipt.Controls.Add(this.dgvListReceipt);
            this.pnlListReceipt.Controls.Add(this.llbBack);
            this.pnlListReceipt.Controls.Add(this.lblListOrders);
            this.pnlListReceipt.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlListReceipt.Location = new System.Drawing.Point(0, 0);
            this.pnlListReceipt.Name = "pnlListReceipt";
            this.pnlListReceipt.Size = new System.Drawing.Size(10, 684);
            this.pnlListReceipt.TabIndex = 71;
            // 
            // btnSearchReceipts
            // 
            this.btnSearchReceipts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(150)))));
            this.btnSearchReceipts.FlatAppearance.BorderSize = 0;
            this.btnSearchReceipts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchReceipts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchReceipts.ForeColor = System.Drawing.Color.White;
            this.btnSearchReceipts.Image = global::GUI.Properties.Resources.icons8_Search_26px;
            this.btnSearchReceipts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchReceipts.Location = new System.Drawing.Point(850, 113);
            this.btnSearchReceipts.Name = "btnSearchReceipts";
            this.btnSearchReceipts.Size = new System.Drawing.Size(151, 40);
            this.btnSearchReceipts.TabIndex = 72;
            this.btnSearchReceipts.Text = "     Tìm kiếm";
            this.btnSearchReceipts.UseVisualStyleBackColor = false;
            // 
            // txtSearchOrders
            // 
            this.txtSearchOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchOrders.ForeColor = System.Drawing.Color.Black;
            this.txtSearchOrders.Location = new System.Drawing.Point(576, 113);
            this.txtSearchOrders.Multiline = true;
            this.txtSearchOrders.Name = "txtSearchOrders";
            this.txtSearchOrders.Size = new System.Drawing.Size(268, 40);
            this.txtSearchOrders.TabIndex = 71;
            this.txtSearchOrders.Text = "Nhập tên công ty...";
            // 
            // btnDeleteReceipts
            // 
            this.btnDeleteReceipts.BackColor = System.Drawing.Color.Red;
            this.btnDeleteReceipts.FlatAppearance.BorderSize = 0;
            this.btnDeleteReceipts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteReceipts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReceipts.ForeColor = System.Drawing.Color.White;
            this.btnDeleteReceipts.Image = global::GUI.Properties.Resources.icons8_Trash_Can_26px;
            this.btnDeleteReceipts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteReceipts.Location = new System.Drawing.Point(156, 113);
            this.btnDeleteReceipts.Name = "btnDeleteReceipts";
            this.btnDeleteReceipts.Size = new System.Drawing.Size(134, 40);
            this.btnDeleteReceipts.TabIndex = 65;
            this.btnDeleteReceipts.Text = "   Xóa";
            this.btnDeleteReceipts.UseVisualStyleBackColor = false;
            this.btnDeleteReceipts.Click += new System.EventHandler(this.btnDeleteReceipts_Click);
            // 
            // btnAddReceipts
            // 
            this.btnAddReceipts.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddReceipts.FlatAppearance.BorderSize = 0;
            this.btnAddReceipts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReceipts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReceipts.ForeColor = System.Drawing.Color.White;
            this.btnAddReceipts.Image = global::GUI.Properties.Resources.icons8_Plus_Math_26px;
            this.btnAddReceipts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddReceipts.Location = new System.Drawing.Point(16, 113);
            this.btnAddReceipts.Name = "btnAddReceipts";
            this.btnAddReceipts.Size = new System.Drawing.Size(134, 40);
            this.btnAddReceipts.TabIndex = 70;
            this.btnAddReceipts.Text = "   Thêm";
            this.btnAddReceipts.UseVisualStyleBackColor = false;
            // 
            // dgvListReceipt
            // 
            this.dgvListReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListReceipt.Location = new System.Drawing.Point(16, 189);
            this.dgvListReceipt.Name = "dgvListReceipt";
            this.dgvListReceipt.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListReceipt.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListReceipt.RowTemplate.Height = 24;
            this.dgvListReceipt.Size = new System.Drawing.Size(985, 484);
            this.dgvListReceipt.TabIndex = 69;
            // 
            // llbBack
            // 
            this.llbBack.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llbBack.AutoSize = true;
            this.llbBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbBack.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llbBack.Location = new System.Drawing.Point(933, 21);
            this.llbBack.Name = "llbBack";
            this.llbBack.Size = new System.Drawing.Size(68, 25);
            this.llbBack.TabIndex = 68;
            this.llbBack.TabStop = true;
            this.llbBack.Text = "Trở về";
            this.llbBack.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llbBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbBack_LinkClicked);
            // 
            // lblListOrders
            // 
            this.lblListOrders.AutoSize = true;
            this.lblListOrders.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblListOrders.Location = new System.Drawing.Point(370, 9);
            this.lblListOrders.Name = "lblListOrders";
            this.lblListOrders.Size = new System.Drawing.Size(308, 38);
            this.lblListOrders.TabIndex = 67;
            this.lblListOrders.Text = "Danh sách phiếu nhập";
            // 
            // WarehouseManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlListReceipt);
            this.Controls.Add(this.btnPrinter);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.llbListReceipt);
            this.Controls.Add(this.lblListProductInventory);
            this.Controls.Add(this.dgvListProductInventory);
            this.Controls.Add(this.dgvReceiptDetails);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblOrderDetails);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.btnCreateReceipts);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.grbInfoOrders);
            this.Controls.Add(this.lblTitlePage);
            this.Name = "WarehouseManagementPage";
            this.Size = new System.Drawing.Size(1020, 684);
            this.Load += new System.EventHandler(this.WarehouseManagementPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProductInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptDetails)).EndInit();
            this.grbInfoOrders.ResumeLayout(false);
            this.grbInfoOrders.PerformLayout();
            this.pnlListReceipt.ResumeLayout(false);
            this.pnlListReceipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListReceipt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitlePage;
        private System.Windows.Forms.Button btnPrinter;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.LinkLabel llbListReceipt;
        private System.Windows.Forms.Label lblListProductInventory;
        private System.Windows.Forms.DataGridView dgvListProductInventory;
        private System.Windows.Forms.DataGridView dgvReceiptDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblOrderDetails;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Button btnCreateReceipts;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.GroupBox grbInfoOrders;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.ComboBox cbCompanyName;
        private System.Windows.Forms.Panel pnlListReceipt;
        private System.Windows.Forms.Button btnSearchReceipts;
        private System.Windows.Forms.TextBox txtSearchOrders;
        private System.Windows.Forms.Button btnDeleteReceipts;
        private System.Windows.Forms.Button btnAddReceipts;
        private System.Windows.Forms.DataGridView dgvListReceipt;
        private System.Windows.Forms.LinkLabel llbBack;
        private System.Windows.Forms.Label lblListOrders;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
    }
}
