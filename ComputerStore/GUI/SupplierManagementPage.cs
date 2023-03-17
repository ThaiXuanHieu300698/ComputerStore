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
    public partial class SupplierManagementPage : UserControl
    {
        private bool isNew = false;

        public SupplierManagementPage()
        {
            InitializeComponent();
        }

        public void DisplayData()
        {
            // Hiển thị data lên datagridview
            dgvSuppliers.DataSource = SuppliersBLL.Instance.GetAll(); 
        }

        private void isEnabled(bool enabled)
        {
            // Có hay Không cho phép nhập
            txtCompanyName.Enabled = enabled;
            txtContactName.Enabled = enabled;
            txtAddress.Enabled = enabled;
            txtEmail.Enabled = enabled;
            txtPhone.Enabled = enabled;


            // Có hay Không cho phép nhấn
            btnAddSupplier.Enabled = !enabled;
            btnDeleteSupplier.Enabled = !enabled;
            btnEditSupplier.Enabled = !enabled;
            btnSave.Enabled = enabled;
        }

        private void SupplierManagementPage_Load(object sender, EventArgs e)
        {
            DisplayData();
            isEnabled(false);
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            isEnabled(true);
            isNew = true;

            txtCompanyName.Clear();
            txtContactName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtCompanyName.Focus();
        }

        

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            // Delete
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Chắc chắn xóa nhà cung cấp đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == System.Windows.Forms.DialogResult.No) return;

            int row = dgvSuppliers.CurrentRow.Index;
            int supplierID = Convert.ToInt32(dgvSuppliers.Rows[row].Cells[0].Value.ToString());
            SuppliersBLL.Instance.DeleteBySupplierID(supplierID); // Xóa theo supplierID

            DisplayData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCompanyName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên công ty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtContactName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên liên hệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ cho công ty", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (isNew == true)// Nút thêm được nhấn
            {
                // Insert vào db
                SuppliersBLL.Instance.Insert(txtCompanyName.Text, txtContactName.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text);
            }
            else
            {
                int row = dgvSuppliers.CurrentRow.Index;
                int supplierID = Convert.ToInt32(dgvSuppliers.Rows[row].Cells[0].Value.ToString());
                // Update với supplierID
                SuppliersBLL.Instance.Update(supplierID, txtCompanyName.Text, txtContactName.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text);
            }
            // Load lại data
            DisplayData();
            isEnabled(false);
        }

        private void btnSearchSupplier_Click(object sender, EventArgs e)
        {
            // Tìm kiếm và hiển thị data lên datagridview
            dgvSuppliers.DataSource = SuppliersBLL.Instance.GetSupplierBySearchString(txtSearchSupplier.Text);
        }

        private void dgvSuppliers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            txtCompanyName.Text = dgvSuppliers.Rows[row].Cells[1].Value.ToString();
            txtContactName.Text = dgvSuppliers.Rows[row].Cells[2].Value.ToString();
            txtAddress.Text = dgvSuppliers.Rows[row].Cells[3].Value.ToString();
            txtPhone.Text = dgvSuppliers.Rows[row].Cells[4].Value.ToString();
            txtEmail.Text = dgvSuppliers.Rows[row].Cells[5].Value.ToString();
        }
        // Nút Edit được nhấn
        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            isEnabled(true);
            txtCompanyName.Focus();
            isNew = false;
        }
    }
}
