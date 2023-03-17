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
using Common;
namespace GUI
{
    public partial class CustomerManagementPage : UserControl
    {
        private bool isNew = false;

        public CustomerManagementPage()
        {
            InitializeComponent();
        }

        private void CustomerManagementPage_Load(object sender, EventArgs e)
        {
            DisplayData();
            isEnabled(false);
        }

        public void DisplayData()
        {
            // Load Data
            dgvCustomers.DataSource = CustomersBLL.Instance.GetAll();
        }

        private void isEnabled(bool enabled)
        {
            // Có hay Không cho phép nhập
            txtLastName.Enabled = enabled;
            txtFirstName.Enabled = enabled;
            txtAddress.Enabled = enabled;
            txtEmail.Enabled = enabled;
            txtPhone.Enabled = enabled;


            // Có hay Không cho phép nhấn
            btnAddCustomer.Enabled = !enabled;
            btnDeleteCustomer.Enabled = !enabled;
            btnEditCustomer.Enabled = !enabled;
            btnSave.Enabled = enabled;
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            // Select with SearchString
            if(!PhoneNumberValidation.IsValid(txtSearchCustomer.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvCustomers.DataSource = CustomersBLL.Instance.GetCustomerByPhone(txtSearchCustomer.Text);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            isEnabled(true);
            isNew = true;

            txtLastName.Clear();
            txtFirstName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtLastName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ cho khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên cho khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ cho khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!EmailValidation.IsValid(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!PhoneNumberValidation.IsValid(txtPhone.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (isNew == true)
            {
                CustomersBLL.Instance.Insert(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text);
            }
            else
            {
                int row = dgvCustomers.CurrentRow.Index;
                int customerID = Convert.ToInt32(dgvCustomers.Rows[row].Cells[0].Value.ToString());
                CustomersBLL.Instance.Update(customerID, txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text);
            }


            DisplayData();
            isEnabled(false);
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            // Delete
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Chắc chắn xóa khách hàng đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == System.Windows.Forms.DialogResult.No) return;

            int row = dgvCustomers.CurrentRow.Index;
            int customerID = Convert.ToInt32(dgvCustomers.Rows[row].Cells[0].Value.ToString());
            CustomersBLL.Instance.DeleteByCustomerID(Convert.ToInt32(customerID));

            DisplayData();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            isEnabled(true);
            txtLastName.Focus();
            isNew = false;
        }

        private void dgvCustomers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtLastName.Text = dgvCustomers.Rows[row].Cells[2].Value.ToString();
            txtFirstName.Text = dgvCustomers.Rows[row].Cells[1].Value.ToString();
            txtAddress.Text = dgvCustomers.Rows[row].Cells[3].Value.ToString();
            txtPhone.Text = dgvCustomers.Rows[row].Cells[4].Value.ToString();
            txtEmail.Text = dgvCustomers.Rows[row].Cells[5].Value.ToString();
        }
    }
}
