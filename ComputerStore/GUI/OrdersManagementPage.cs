using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class OrdersManagementPage : UserControl
    {
        private bool hidden;    // Biến này dùng cho Silding Panel

        private bool isNew = false; // Biến này dùng để kiểm tra thêm mới hay cập nhật

        OrdersDTO orders = new OrdersDTO(); // Biến này dùng để giữ đối tượng Order
                                            // trong cả quá trình tạo hóa đơn
        CustomersDTO customer = new CustomersDTO(); // Biến này dùng để giữ đối tượng Customer
                                                    // trong cả quá trình tạo hóa đơn

        bool isNewCustomer = true; // Biến này dùng để kiểm tra khách hàng mới hay cũ
        double amount = 0;
        double totalAmount = 0;

        public OrdersManagementPage()
        {
            InitializeComponent();
            hidden = true;
        }

        // Chuyện gì sẽ xảy ra khi Form được Load 
        private void OrdersManagementPage_Load(object sender, EventArgs e)
        {
            DisplayData();
            btnPay.Enabled = false;
            btnPrinter.Enabled = false;
            btnAddOrder.Enabled = false;
            btnEditOrder.Enabled = false;
            btnDeleteOrder.Enabled = false;
            btnSave.Enabled = false;
            cbProducts.Enabled = false;
            txtQuantity.Enabled = false;
            txtPrice.Enabled = false;
        }

        public void DisplayData()
        {
            // Load Data
            dgvProducts.DataSource = ProductsBLL.Instance.GetColumn();

            // Load Data to cbProducts

            DataTable dtProducts = ProductsBLL.Instance.GetAll();
            cbProducts.DataSource = dtProducts;
            cbProducts.DisplayMember = "ProductName";
            cbProducts.ValueMember = "ProductID";
        }

        private void isEnabled(bool enabled)
        {
            // Có hay Không cho phép nhập
            cbProducts.Enabled = enabled;
            txtQuantity.Enabled = enabled;
            txtPrice.Enabled = enabled;
            
            // Có hay Không cho phép nhấn
            btnAddOrder.Enabled = !enabled;
            btnDeleteOrder.Enabled = !enabled;
            btnEditOrder.Enabled = !enabled;
            btnSave.Enabled = enabled;
            
        }

        private void btnCreateOrders_Click(object sender, EventArgs e)
        {
            //
            if(txtPhone.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            isEnabled(true);
            isNew = true;
            btnPay.Enabled = true;
            btnPrinter.Enabled = true;
            lblAmount.Text = "";
            txtPhone.Enabled = false;
            txtAddress.Enabled = false;
            txtFullName.Enabled = false;
            dgvOrderDetails.DataSource = null;
 
        }

        private void llbBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer.Start();
        }

        private void llbListOrders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer.Start();
            dgvListOrders.DataSource = OrdersBLL.Instance.GetAll();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(hidden)
            {
                pnlListOrders.Width += 10;
                if(pnlListOrders.Width >= 1020)
                {
                    Timer.Stop();
                    hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlListOrders.Width -= 10;
                if(pnlListOrders.Width <= 10)
                {
                    Timer.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {

            isEnabled(true);
            isNew = true;

            txtQuantity.Clear();
            cbProducts.Focus();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable dtCustomers = CustomersBLL.Instance.GetCustomerByPhone(txtPhone.Text.Trim());
            if(dtCustomers.Rows.Count != 0) // Kiểm tra có tồn tại bản ghi không
            {
                // Load data to TextBox
                customer.CustomerID = dtCustomers.Rows[0].Field<int>("CustomerID");
                string firstName = dtCustomers.Rows[0].Field<string>("FirstName");
                string lastName = dtCustomers.Rows[0].Field<string>("LastName");
                txtFullName.Text = firstName + " " + lastName;
                txtAddress.Text = dtCustomers.Rows[0].Field<string>("Address");
                txtPhone.Text = dtCustomers.Rows[0].Field<string>("Phone");

                // Bây h khách hàng này là khách hàng cũ
                isNewCustomer = false;
                // Tạo hóa đơn với khách hàng cũ
                OrdersBLL.Instance.Insert(customer.CustomerID, DateTime.Now, 0);
                orders = OrdersBLL.Instance.GetFirstOrders();
            }
            else
            {
                isNewCustomer = true;
                
                MessageBox.Show("KHÁCH HÀNG NÀY CHƯA MUA HÀNG LẦN NÀO!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Tạo hóa đơn với khách hàng mới
                // Tách Họ và tên
                string[] strs = txtFullName.Text.Split(' ');
                string firstName = "";
                string lastName = strs[strs.Length - 1];
                for (int i = 0; i < strs.Length - 1; i++)
                {
                    firstName += strs[i] + " ";
                }
                // Thêm vào bảng Khách hàng
                CustomersBLL.Instance.Insert(firstName.Trim(), lastName.Trim(), txtAddress.Text, txtPhone.Text, "");
                // Lấy ra khách hàng vừa thêm
                customer = CustomersBLL.Instance.GetFirstCustomer();
                OrdersBLL.Instance.Insert(customer.CustomerID, DateTime.Now, 0);
                orders = OrdersBLL.Instance.GetFirstOrders();
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Thêm mới
            if (isNew == true)
            {
                amount = Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text);
                OrderDetailsBLL.Instance.Insert(orders.OrderID, Convert.ToInt32(cbProducts.SelectedValue.ToString()), Convert.ToInt32(txtQuantity.Text), Convert.ToDouble(txtPrice.Text), amount);
                dgvOrderDetails.DataSource = OrderDetailsBLL.Instance.GetByOrderID(orders.OrderID);
            }
            else
            {
                // Sửa và lưu
                int row = dgvOrderDetails.CurrentRow.Index;
                int productID = Convert.ToInt32(dgvOrderDetails.Rows[row].Cells[1].Value.ToString());
                amount = Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text);
                // Update By ProductID
                OrderDetailsBLL.Instance.Update(productID, Convert.ToInt32(txtQuantity.Text), Convert.ToDouble(txtPrice.Text), amount);
                dgvOrderDetails.DataSource = OrderDetailsBLL.Instance.GetByOrderID(orders.OrderID);
            }

            DisplayData();
            
            isEnabled(false);
        }

        // Thanh toán hóa đơn
        private void btnPay_Click(object sender, EventArgs e)
        {

            if (txtFullName.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Tính tổng tiền
            WarehouseDTO warehouse;
            for (var row = 0; row < dgvOrderDetails.Rows.Count; row++)
            {
                int quantity = Convert.ToInt32(dgvOrderDetails.Rows[row].Cells["Quantity"].Value.ToString());
                totalAmount += Convert.ToDouble(dgvOrderDetails.Rows[row].Cells["Amount"].Value.ToString());
                // Lấy ra Sản phẩm và số lượng tồn kho
                warehouse = WarehouseBLL.Instance.GetByProductID(Convert.ToInt32(dgvOrderDetails.Rows[row].Cells["ProductID"].Value.ToString()));
                // Cập nhật lại số lượng tồn kho sau khi bán sản phẩm
                WarehouseBLL.Instance.Update(warehouse.ProductID, warehouse.Stock - quantity);
            }
            lblAmount.Text = totalAmount.ToString();

            if(isNewCustomer == true)   // Nếu là khách hàng mới
            {
                
                // Cập nhật lại Hóa đơn với khách hàng mới
                OrdersBLL.Instance.Update(customer.CustomerID, orders.OrderID, DateTime.Now, totalAmount);
            }
            else
            {
                // Cập nhật lại Hóa đơn với khách hàng cũ
                OrdersBLL.Instance.Update(customer.CustomerID, orders.OrderID, DateTime.Now, totalAmount);
            }

            txtPhone.Enabled = true;
            txtAddress.Enabled = true;
            txtFullName.Enabled = true;
            
            isEnabled(true);
            btnSave.Enabled = false;
            btnPay.Enabled = false;
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            isEnabled(true);
            cbProducts.Focus();
            isNew = false;
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            // Delete với id
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Chắc chắn xóa bản ghi đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == System.Windows.Forms.DialogResult.No) return;

            int row = dgvOrderDetails.CurrentRow.Index;
            int productID = Convert.ToInt32(dgvOrderDetails.Rows[row].Cells[1].Value.ToString());
            OrderDetailsBLL.Instance.DeleteByProductID(productID);

            // Hiển thị dữ liệu
            dgvOrderDetails.DataSource = OrderDetailsBLL.Instance.GetByOrderID(orders.OrderID);
            DisplayData();
        }

        // Tìm kiếm sản phẩm
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = ProductsBLL.Instance.GetColumnProductBySearchString(txtSearchProduct.Text);
        }

        private void dgvProducts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            cbProducts.SelectedValue = dgvProducts.Rows[row].Cells[0].Value.ToString();
            txtPrice.Text = dgvProducts.Rows[row].Cells[3].Value.ToString();
        }

        private void dgvOrderDetails_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            cbProducts.SelectedValue = dgvOrderDetails.Rows[row].Cells[1].Value.ToString();
            txtQuantity.Text = dgvOrderDetails.Rows[row].Cells[2].Value.ToString();
            txtPrice.Text = dgvOrderDetails.Rows[row].Cells[3].Value.ToString();
        }


        //----------------Orders-----------------//
        private void btnAddOrders_Click(object sender, EventArgs e)
        {
            Timer.Start();
        }

        private void btnDeleteOrders_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Chắc chắn xóa bản ghi đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == System.Windows.Forms.DialogResult.No) return;
            int orderID = Convert.ToInt32(dgvListOrders.SelectedCells[0].OwningRow.Cells["OrderID"].Value.ToString());
            OrdersBLL.Instance.DeleteByOrderID(orderID);

            dgvListOrders.DataSource = OrdersBLL.Instance.GetAll();
        }

        private void btnSearchOrders_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPrinter_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog  = new PrintDialog();
            printDialog.ShowDialog();

            txtQuantity.Clear();
            txtFullName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }

        
    }
}
