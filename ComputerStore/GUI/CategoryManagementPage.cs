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

namespace GUI
{
    public partial class CategoryManagementPage : UserControl
    {
        private bool isNew = false; // Biến này dùng để kiểm tra thêm mới hay sửa

        public CategoryManagementPage()
        {
            InitializeComponent();
        }
           
        // Chuyện gì sẽ xảy ra khi Page được Load lên
        private void CategoryManagementPage_Load(object sender, EventArgs e)
        {
            DisplayData();  // Hiển thị dữ liệu
            isEnabled(false);   // Điều khiển component
        }

        public void DisplayData()
        {
            // Load Data
            dgvCategories.DataSource = CategoriesBLL.Instance.GetAll(); // Đổ dữ liệu vào datagridview
        }
        // Hàm điều khiển component
        private void isEnabled(bool enabled)
        {
            // Có hay Không cho phép nhập
            txtCategoryName.Enabled = enabled;
            txtDescription.Enabled = enabled;

            // Có hay Không cho phép nhấn
            btnAddCategory.Enabled = !enabled;
            btnDeleteCategory.Enabled = !enabled;
            btnEditCategory.Enabled = !enabled;
            btnSave.Enabled = enabled;
        }
        // Hàm thêm một Danh mục
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            isEnabled(true);
            isNew = true;

            txtCategoryName.Clear();
            txtDescription.Clear();
            txtCategoryName.Focus();
        }
        // Hàm chỉnh sửa Danh mục
        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            isEnabled(true);
            txtCategoryName.Focus();
            isNew = false;
        }
        // Hàm xóa một Danh mục
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            // Delete
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Chắc chắn xóa danh mục đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == System.Windows.Forms.DialogResult.No) return;

            int row = dgvCategories.CurrentRow.Index; // Lấy row đang được selector
            int productID = Convert.ToInt32(dgvCategories.Rows[row].Cells[0].Value.ToString());
            CategoriesBLL.Instance.DeleteByCategoryID(Convert.ToInt32(productID));  // Thực hiện xóa

            DisplayData(); // Hiện thị lại dữ liệu
        }

        // Hàm lưu dữ liệu
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "") // Kiểm tra textbox rỗng hay ko
            {
                MessageBox.Show("Vui lòng nhập tên cho danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (isNew == true)  // Nếu nhấn nút Thêm
            {
                CategoriesBLL.Instance.Insert(txtCategoryName.Text, txtDescription.Text);   // Add vào database
            }
            else // Nếu nhấn nút Sửa
            {
                int row = dgvCategories.CurrentRow.Index;
                int categoryID = Convert.ToInt32(dgvCategories.Rows[row].Cells[0].Value.ToString());
                CategoriesBLL.Instance.Update(categoryID, txtCategoryName.Text, txtDescription.Text); // Thực hiện cập nhật
            }


            DisplayData();  // Hiển thị lại dữ liệu 
            isEnabled(false);
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            // Thực hiện tìm kiếm và hiển thị trên datagridview
            dgvCategories.DataSource = CategoriesBLL.Instance.GetCategoryBySearchString(txtSearchCategory.Text);
        }

        private void dgvCategories_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            txtCategoryName.Text = dgvCategories.Rows[row].Cells[1].Value.ToString();
            txtDescription.Text = dgvCategories.Rows[row].Cells[2].Value.ToString();
        }
    }
}
