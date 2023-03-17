namespace GUI
{
    partial class OrdersManagementPage
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
            this.grbInfoOrders = new System.Windows.Forms.GroupBox();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lblListProduct = new System.Windows.Forms.Label();
            this.llbListOrders = new System.Windows.Forms.LinkLabel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnPrinter = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.pnlListOrders = new System.Windows.Forms.Panel();
            this.btnSearchOrders = new System.Windows.Forms.Button();
            this.txtSearchOrders = new System.Windows.Forms.TextBox();
            this.btnDeleteOrders = new System.Windows.Forms.Button();
            this.btnAddOrders = new System.Windows.Forms.Button();
            this.dgvListOrders = new System.Windows.Forms.DataGridView();
            this.llbBack = new System.Windows.Forms.LinkLabel();
            this.lblListOrders = new System.Windows.Forms.Label();
            this.btnCreateOrders = new System.Windows.Forms.Button();
            this.grbInfoOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.pnlListOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlePage
            // 
            this.lblTitlePage.AutoSize = true;
            this.lblTitlePage.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitlePage.Location = new System.Drawing.Point(414, 9);
            this.lblTitlePage.Name = "lblTitlePage";
            this.lblTitlePage.Size = new System.Drawing.Size(183, 38);
            this.lblTitlePage.TabIndex = 40;
            this.lblTitlePage.Text = "Tạo hóa đơn";
            // 
            // grbInfoOrders
            // 
            this.grbInfoOrders.Controls.Add(this.cbProducts);
            this.grbInfoOrders.Controls.Add(this.btnSearchCustomer);
            this.grbInfoOrders.Controls.Add(this.lbl1);
            this.grbInfoOrders.Controls.Add(this.txtQuantity);
            this.grbInfoOrders.Controls.Add(this.txtPrice);
            this.grbInfoOrders.Controls.Add(this.lblQuantity);
            this.grbInfoOrders.Controls.Add(this.lblPrice);
            this.grbInfoOrders.Controls.Add(this.txtPhone);
            this.grbInfoOrders.Controls.Add(this.txtAddress);
            this.grbInfoOrders.Controls.Add(this.txtFullName);
            this.grbInfoOrders.Controls.Add(this.label2);
            this.grbInfoOrders.Controls.Add(this.label1);
            this.grbInfoOrders.Controls.Add(this.lblAddress);
            this.grbInfoOrders.Controls.Add(this.lblProductName);
            this.grbInfoOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfoOrders.Location = new System.Drawing.Point(18, 66);
            this.grbInfoOrders.Name = "grbInfoOrders";
            this.grbInfoOrders.Size = new System.Drawing.Size(985, 178);
            this.grbInfoOrders.TabIndex = 49;
            this.grbInfoOrders.TabStop = false;
            this.grbInfoOrders.Text = "Thông tin hóa đơn";
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(189, 44);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(263, 36);
            this.cbProducts.TabIndex = 67;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnSearchCustomer.FlatAppearance.BorderSize = 0;
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.ForeColor = System.Drawing.Color.White;
            this.btnSearchCustomer.Image = global::GUI.Properties.Resources.icons8_Search_26px;
            this.btnSearchCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomer.Location = new System.Drawing.Point(931, 130);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(48, 34);
            this.btnSearchCustomer.TabIndex = 6;
            this.btnSearchCustomer.UseVisualStyleBackColor = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
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
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(618, 130);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(307, 34);
            this.txtPhone.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(617, 86);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(308, 34);
            this.txtAddress.TabIndex = 4;
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(617, 44);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(308, 34);
            this.txtFullName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 32);
            this.label2.TabIndex = 55;
            this.label2.Text = "SĐT :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(477, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 55;
            this.label1.Text = "Họ và Tên :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(477, 87);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 32);
            this.lblAddress.TabIndex = 55;
            this.lblAddress.Text = "Địa chỉ :";
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
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToAddRows = false;
            this.dgvOrderDetails.AllowUserToDeleteRows = false;
            this.dgvOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Location = new System.Drawing.Point(16, 350);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderDetails.RowTemplate.Height = 24;
            this.dgvOrderDetails.Size = new System.Drawing.Size(490, 286);
            this.dgvOrderDetails.TabIndex = 59;
            this.dgvOrderDetails.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetails_RowEnter);
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOrderDetails.Location = new System.Drawing.Point(151, 309);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(230, 38);
            this.lblOrderDetails.TabIndex = 57;
            this.lblOrderDetails.Text = "Chi tiết hóa đơn";
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.ForeColor = System.Drawing.Color.Black;
            this.txtSearchProduct.Location = new System.Drawing.Point(578, 262);
            this.txtSearchProduct.Multiline = true;
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(268, 40);
            this.txtSearchProduct.TabIndex = 55;
            this.txtSearchProduct.Text = "Nhập tên sản phẩm...";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(513, 350);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(490, 286);
            this.dgvProducts.TabIndex = 59;
            this.dgvProducts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_RowEnter);
            // 
            // lblListProduct
            // 
            this.lblListProduct.AutoSize = true;
            this.lblListProduct.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblListProduct.Location = new System.Drawing.Point(624, 309);
            this.lblListProduct.Name = "lblListProduct";
            this.lblListProduct.Size = new System.Drawing.Size(287, 38);
            this.lblListProduct.TabIndex = 60;
            this.lblListProduct.Text = "Danh sách sản phẩm";
            // 
            // llbListOrders
            // 
            this.llbListOrders.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llbListOrders.AutoSize = true;
            this.llbListOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbListOrders.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llbListOrders.Location = new System.Drawing.Point(13, 9);
            this.llbListOrders.Name = "llbListOrders";
            this.llbListOrders.Size = new System.Drawing.Size(225, 25);
            this.llbListOrders.TabIndex = 62;
            this.llbListOrders.TabStop = true;
            this.llbListOrders.Text = "Xem danh sách hóa đơn";
            this.llbListOrders.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llbListOrders.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbListOrders_LinkClicked);
            // 
            // Timer
            // 
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(215, 644);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(130, 32);
            this.lblTotalAmount.TabIndex = 66;
            this.lblTotalAmount.Text = "Tổng tiền :";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(351, 644);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 32);
            this.lblAmount.TabIndex = 67;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(504, 644);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(65, 32);
            this.lbl2.TabIndex = 66;
            this.lbl2.Text = "VND";
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
            this.btnPrinter.TabIndex = 13;
            this.btnPrinter.Text = "      In hóa đơn";
            this.btnPrinter.UseVisualStyleBackColor = false;
            this.btnPrinter.Click += new System.EventHandler(this.btnPrinter_Click);
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
            this.btnPay.TabIndex = 12;
            this.btnPay.Text = "      Thanh Toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
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
            this.btnSave.TabIndex = 10;
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
            this.btnSearchProduct.TabIndex = 11;
            this.btnSearchProduct.Text = "     Tìm kiếm";
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
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
            this.btnDeleteOrder.TabIndex = 9;
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
            this.btnEditOrder.TabIndex = 8;
            this.btnEditOrder.Text = "   Sửa";
            this.btnEditOrder.UseVisualStyleBackColor = false;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
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
            this.btnAddOrder.TabIndex = 7;
            this.btnAddOrder.Text = "   Thêm";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // pnlListOrders
            // 
            this.pnlListOrders.Controls.Add(this.btnSearchOrders);
            this.pnlListOrders.Controls.Add(this.txtSearchOrders);
            this.pnlListOrders.Controls.Add(this.btnDeleteOrders);
            this.pnlListOrders.Controls.Add(this.btnAddOrders);
            this.pnlListOrders.Controls.Add(this.dgvListOrders);
            this.pnlListOrders.Controls.Add(this.llbBack);
            this.pnlListOrders.Controls.Add(this.lblListOrders);
            this.pnlListOrders.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlListOrders.Location = new System.Drawing.Point(0, 0);
            this.pnlListOrders.Name = "pnlListOrders";
            this.pnlListOrders.Size = new System.Drawing.Size(10, 684);
            this.pnlListOrders.TabIndex = 70;
            // 
            // btnSearchOrders
            // 
            this.btnSearchOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(150)))));
            this.btnSearchOrders.FlatAppearance.BorderSize = 0;
            this.btnSearchOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOrders.ForeColor = System.Drawing.Color.White;
            this.btnSearchOrders.Image = global::GUI.Properties.Resources.icons8_Search_26px;
            this.btnSearchOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchOrders.Location = new System.Drawing.Point(852, 111);
            this.btnSearchOrders.Name = "btnSearchOrders";
            this.btnSearchOrders.Size = new System.Drawing.Size(151, 40);
            this.btnSearchOrders.TabIndex = 64;
            this.btnSearchOrders.Text = "     Tìm kiếm";
            this.btnSearchOrders.UseVisualStyleBackColor = false;
            this.btnSearchOrders.Click += new System.EventHandler(this.btnSearchOrders_Click);
            // 
            // txtSearchOrders
            // 
            this.txtSearchOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchOrders.ForeColor = System.Drawing.Color.Black;
            this.txtSearchOrders.Location = new System.Drawing.Point(578, 111);
            this.txtSearchOrders.Multiline = true;
            this.txtSearchOrders.Name = "txtSearchOrders";
            this.txtSearchOrders.Size = new System.Drawing.Size(268, 40);
            this.txtSearchOrders.TabIndex = 63;
            this.txtSearchOrders.Text = "Nhập tên khách hàng...";
            // 
            // btnDeleteOrders
            // 
            this.btnDeleteOrders.BackColor = System.Drawing.Color.Red;
            this.btnDeleteOrders.FlatAppearance.BorderSize = 0;
            this.btnDeleteOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrders.ForeColor = System.Drawing.Color.White;
            this.btnDeleteOrders.Image = global::GUI.Properties.Resources.icons8_Trash_Can_26px;
            this.btnDeleteOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteOrders.Location = new System.Drawing.Point(158, 111);
            this.btnDeleteOrders.Name = "btnDeleteOrders";
            this.btnDeleteOrders.Size = new System.Drawing.Size(134, 40);
            this.btnDeleteOrders.TabIndex = 0;
            this.btnDeleteOrders.Text = "   Xóa";
            this.btnDeleteOrders.UseVisualStyleBackColor = false;
            this.btnDeleteOrders.Click += new System.EventHandler(this.btnDeleteOrders_Click);
            // 
            // btnAddOrders
            // 
            this.btnAddOrders.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddOrders.FlatAppearance.BorderSize = 0;
            this.btnAddOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrders.ForeColor = System.Drawing.Color.White;
            this.btnAddOrders.Image = global::GUI.Properties.Resources.icons8_Plus_Math_26px;
            this.btnAddOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddOrders.Location = new System.Drawing.Point(18, 111);
            this.btnAddOrders.Name = "btnAddOrders";
            this.btnAddOrders.Size = new System.Drawing.Size(134, 40);
            this.btnAddOrders.TabIndex = 60;
            this.btnAddOrders.Text = "   Thêm";
            this.btnAddOrders.UseVisualStyleBackColor = false;
            this.btnAddOrders.Click += new System.EventHandler(this.btnAddOrders_Click);
            // 
            // dgvListOrders
            // 
            this.dgvListOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOrders.Location = new System.Drawing.Point(18, 187);
            this.dgvListOrders.Name = "dgvListOrders";
            this.dgvListOrders.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListOrders.RowTemplate.Height = 24;
            this.dgvListOrders.Size = new System.Drawing.Size(985, 484);
            this.dgvListOrders.TabIndex = 52;
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
            this.llbBack.TabIndex = 42;
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
            this.lblListOrders.Location = new System.Drawing.Point(373, 9);
            this.lblListOrders.Name = "lblListOrders";
            this.lblListOrders.Size = new System.Drawing.Size(270, 38);
            this.lblListOrders.TabIndex = 41;
            this.lblListOrders.Text = "Danh sách hóa đơn";
            // 
            // btnCreateOrders
            // 
            this.btnCreateOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnCreateOrders.FlatAppearance.BorderSize = 0;
            this.btnCreateOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrders.ForeColor = System.Drawing.Color.White;
            this.btnCreateOrders.Image = global::GUI.Properties.Resources.icons8_Purchase_Order_26px;
            this.btnCreateOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateOrders.Location = new System.Drawing.Point(810, 20);
            this.btnCreateOrders.Name = "btnCreateOrders";
            this.btnCreateOrders.Size = new System.Drawing.Size(193, 40);
            this.btnCreateOrders.TabIndex = 52;
            this.btnCreateOrders.Text = "      Tạo hóa đơn";
            this.btnCreateOrders.UseVisualStyleBackColor = false;
            this.btnCreateOrders.Click += new System.EventHandler(this.btnCreateOrders_Click);
            // 
            // OrdersManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlListOrders);
            this.Controls.Add(this.btnPrinter);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.llbListOrders);
            this.Controls.Add(this.lblListProduct);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvOrderDetails);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblOrderDetails);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.btnCreateOrders);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.grbInfoOrders);
            this.Controls.Add(this.lblTitlePage);
            this.Name = "OrdersManagementPage";
            this.Size = new System.Drawing.Size(1020, 684);
            this.Load += new System.EventHandler(this.OrdersManagementPage_Load);
            this.grbInfoOrders.ResumeLayout(false);
            this.grbInfoOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.pnlListOrders.ResumeLayout(false);
            this.pnlListOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlePage;
        private System.Windows.Forms.GroupBox grbInfoOrders;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblOrderDetails;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblListProduct;
        private System.Windows.Forms.LinkLabel llbListOrders;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnPrinter;
        private System.Windows.Forms.Panel pnlListOrders;
        private System.Windows.Forms.Button btnSearchOrders;
        private System.Windows.Forms.TextBox txtSearchOrders;
        private System.Windows.Forms.Button btnDeleteOrders;
        private System.Windows.Forms.Button btnAddOrders;
        private System.Windows.Forms.DataGridView dgvListOrders;
        private System.Windows.Forms.LinkLabel llbBack;
        private System.Windows.Forms.Label lblListOrders;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnCreateOrders;
        private System.Windows.Forms.ComboBox cbProducts;
    }
}
