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
    public partial class ProductManagementPage : UserControl
    {
        private bool isNew = false;
        string imageLocation = "";

        public ProductManagementPage()
        {
            InitializeComponent();
            
        }

        private void ProductManagementPage_Load(object sender, EventArgs e)
        {
            DisplayData();
            isEnabled(false);
        }

        public void DisplayData()
        {
            // Load Data vào dgvProducts
            dgvProducts.DataSource = ProductsBLL.Instance.GetAll();
        }

        private void LoadData()
        {
            // Load data ComboBox Categories
            DataTable dtCategories = CategoriesBLL.Instance.GetAll(); 
            cbCategories.DataSource = dtCategories;
            cbCategories.DisplayMember = "CategoryName";
            cbCategories.ValueMember = "CategoryID";

            // Load data ComboBox Supplier

            DataTable dtSuppliers = SuppliersBLL.Instance.GetAll();
            cbSupplier.DataSource = dtSuppliers;
            cbSupplier.DisplayMember = "CompanyName";
            cbSupplier.ValueMember = "SupplierID";
        }

        private void isEnabled(bool enabled)
        {
            // Có hay Không cho phép nhập
            txtProductName.Enabled = enabled;
            txtPrice.Enabled = enabled;
            txtUnit.Enabled = enabled;
            txtDescription.Enabled = enabled;
            cbCategories.Enabled = enabled;
            cbSupplier.Enabled = enabled;

            // Có hay Không cho phép nhấn
            btnAddProduct.Enabled = !enabled;
            btnDeleteProduct.Enabled = !enabled;
            btnEditProduct.Enabled = !enabled;
            btnSave.Enabled = enabled;
            btnChangeImage.Enabled = enabled;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            isEnabled(true);
            isNew = true;

            txtProductName.Clear();
            txtPrice.Clear();
            txtUnit.Clear();
            txtSearchProduct.Clear();
            txtDescription.Clear();
            picImageProduct.Image = null;
            picImageProduct.ImageLocation = "";
            txtProductName.Focus();

            LoadData();

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            // Select with SearchString
            dgvProducts.DataSource = ProductsBLL.Instance.GetProductBySearchString(txtSearchProduct.Text);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Insert
            if (txtProductName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtUnit.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (picImageProduct.ImageLocation == "")
            {
                MessageBox.Show("Vui lòng chọn ảnh cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (isNew == true)
            {
                string productImage = picImageProduct.ImageLocation;
                //string nameImage = imgPath.Substring(imgPath.LastIndexOf('\\') + 1);
                ProductsBLL.Instance.Insert(Convert.ToInt32(cbCategories.SelectedValue.ToString()), Convert.ToInt32(cbSupplier.SelectedValue.ToString()), txtProductName.Text, productImage, txtUnit.Text, Convert.ToDouble(txtPrice.Text), txtDescription.Text);
            }
            else
            {
                int row = dgvProducts.CurrentRow.Index;
                int productID = Convert.ToInt32(dgvProducts.Rows[row].Cells[2].Value.ToString());
                ProductsBLL.Instance.Update(Convert.ToInt32(cbCategories.SelectedValue.ToString()), Convert.ToInt32(cbSupplier.SelectedValue.ToString()), productID, txtProductName.Text, imageLocation, txtUnit.Text, Convert.ToDouble(txtPrice.Text), txtDescription.Text);
            }
            

            DisplayData();
            isEnabled(false);
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            isEnabled(true);
            txtProductName.Focus();
            isNew = false;
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            // Delete
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Chắc chắn xóa sản phẩm đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == System.Windows.Forms.DialogResult.No) return;

            int row = dgvProducts.CurrentRow.Index;
            int productID = Convert.ToInt32(dgvProducts.Rows[row].Cells[2].Value.ToString());
            ProductsBLL.Instance.DeleteByProductID(productID);

            DisplayData();
        }

        private void dgvProducts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            LoadData();
            int row = e.RowIndex;

            cbCategories.SelectedValue = dgvProducts.Rows[row].Cells[0].Value.ToString();
            cbSupplier.SelectedValue = dgvProducts.Rows[row].Cells[1].Value.ToString();
            txtProductName.Text = dgvProducts.Rows[row].Cells[3].Value.ToString();
            imageLocation = dgvProducts.Rows[row].Cells[4].Value.ToString();
            picImageProduct.ImageLocation = imageLocation;
            txtUnit.Text = dgvProducts.Rows[row].Cells[5].Value.ToString();
            txtPrice.Text = dgvProducts.Rows[row].Cells[6].Value.ToString();
            txtDescription.Text = dgvProducts.Rows[row].Cells[7].Value.ToString();

            
        }

        private void btnChangeIamge_Click(object sender, EventArgs e)
        {
            imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;..."; ;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    picImageProduct.ImageLocation = imageLocation;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi! Không thể tải ảnh lên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
