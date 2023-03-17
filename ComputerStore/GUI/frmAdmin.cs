using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmAdmin : Form
    {
        private StatisticalPage statisticalPage;
        private UsersManagementPage usersManagementPage;

        public frmAdmin(UsersDTO user)
        {
            
            InitializeComponent(user);
            
            // Load Họ và Tên và Ảnh của người dùng
            lblNameUser.Text = user.FullName;

            if(user.Avatar == null)
            {
                picAvatar.ImageLocation = null;
            }
            picAvatar.ImageLocation = user.Avatar;

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            AddStatisticalUC();
            AddUsersManagementlUC();
            ordersManagementPage.Visible = true;
            productManagementPage.Visible = false;
            categoryManagementPage.Visible = false;
            warehouseManagementPage.Visible = false;
            customerManagementPage.Visible = false;
            supplierManagementPage.Visible = false;
            usersManagementPage.Visible = false;
            userPage.Visible = false;
        }

        // Thêm UserControl Thống kê
        public void AddStatisticalUC()
        {
            statisticalPage = new GUI.StatisticalPage()
            {
                Dock = System.Windows.Forms.DockStyle.Fill,
                Name = "statisticalPage",
                Visible = false
            };
            pnlWrap.Controls.Add(statisticalPage);
            Button btnStatisticalPage = new Button()
            {
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68))))),
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                //FlatAppearance.BorderSize = 0,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(7, 443),
                Size = new System.Drawing.Size(223, 50),
                Text = "Thống kê",
                UseVisualStyleBackColor = false
            };

            pnlLeft.Controls.Add(btnStatisticalPage);
            btnStatisticalPage.Click += BtnStatisticalPage_Click;
        }
        // Thêm UserControl Quản lý người dùng
        public void AddUsersManagementlUC()
        {
            usersManagementPage = new GUI.UsersManagementPage()
            {
                Dock = System.Windows.Forms.DockStyle.Fill,
                Name = "usersManagementPage",
                Visible = false
            };
            pnlWrap.Controls.Add(usersManagementPage);
            Button btnUsersManagementPage = new Button()
            {
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68))))),
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                //FlatAppearance.BorderSize = 0,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(7, 493),
                Size = new System.Drawing.Size(223, 50),
                Text = "Quản lý người dùng",
                UseVisualStyleBackColor = false
            };

            pnlLeft.Controls.Add(btnUsersManagementPage);
            btnUsersManagementPage.Click += BtnUsersManagementPage_Click;
        }

        private void BtnUsersManagementPage_Click(object sender, EventArgs e)
        {
            usersManagementPage.Visible = true;
            statisticalPage.Visible = false;
            ordersManagementPage.Visible = false;
            supplierManagementPage.Visible = false;
            productManagementPage.Visible = false;
            categoryManagementPage.Visible = false;
            warehouseManagementPage.Visible = false;
            customerManagementPage.Visible = false;
            userPage.Visible = false;
        }

        private void BtnStatisticalPage_Click(object sender, EventArgs e)
        {
            statisticalPage.Visible = true;
            usersManagementPage.Visible = false;
            ordersManagementPage.Visible = false;
            supplierManagementPage.Visible = false;
            productManagementPage.Visible = false;
            categoryManagementPage.Visible = false;
            warehouseManagementPage.Visible = false;
            customerManagementPage.Visible = false;
            userPage.Visible = false;

        }

        private void btnCreateOrdersPage_Click(object sender, EventArgs e)
        {
            ordersManagementPage.Visible = true;
            usersManagementPage.Visible = false;
            supplierManagementPage.Visible = false;
            productManagementPage.Visible = false;
            categoryManagementPage.Visible = false;
            warehouseManagementPage.Visible = false;
            customerManagementPage.Visible = false;
            userPage.Visible = false;
        }

        private void btnProductManagementPage_Click(object sender, EventArgs e)
        {
            productManagementPage.Visible = true;
            usersManagementPage.Visible = false;
            ordersManagementPage.Visible = false;
            categoryManagementPage.Visible = false;
            warehouseManagementPage.Visible = false;
            customerManagementPage.Visible = false;
            supplierManagementPage.Visible = false;
            userPage.Visible = false;
        }

        private void btnCategoryManagementPage_Click(object sender, EventArgs e)
        {
            categoryManagementPage.Visible = true;
            usersManagementPage.Visible = false;
            ordersManagementPage.Visible = false;
            productManagementPage.Visible = false;
            warehouseManagementPage.Visible = false;
            customerManagementPage.Visible = false;
            supplierManagementPage.Visible = false;
            userPage.Visible = false;
        }

        private void btnWarehouseManagementPage_Click(object sender, EventArgs e)
        {
            warehouseManagementPage.Visible = true;
            usersManagementPage.Visible = false;
            ordersManagementPage.Visible = false;
            categoryManagementPage.Visible = false;
            productManagementPage.Visible = false;
            customerManagementPage.Visible = false;
            supplierManagementPage.Visible = false;
            userPage.Visible = false;
        }

        private void btnCustomerManagementPage_Click(object sender, EventArgs e)
        {
            customerManagementPage.Visible = true;
            usersManagementPage.Visible = false;
            ordersManagementPage.Visible = false;
            productManagementPage.Visible = false;
            categoryManagementPage.Visible = false;
            warehouseManagementPage.Visible = false;
            supplierManagementPage.Visible = false;
            userPage.Visible = false;
        }

        private void btnSupplierManagementPage_Click(object sender, EventArgs e)
        {
            supplierManagementPage.Visible = true;
            usersManagementPage.Visible = false;
            ordersManagementPage.Visible = false;
            productManagementPage.Visible = false;
            categoryManagementPage.Visible = false;
            warehouseManagementPage.Visible = false;
            customerManagementPage.Visible = false;
            userPage.Visible = false;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            
            userPage.Visible = true;
            usersManagementPage.Visible = false;
            ordersManagementPage.Visible = false;
            supplierManagementPage.Visible = false;
            productManagementPage.Visible = false;
            categoryManagementPage.Visible = false;
            warehouseManagementPage.Visible = false;
            customerManagementPage.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("BẠN CHẮC CHẮN MUỐN ĐĂNG XUẤT KHÔNG?", "Thông báo",
            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.ShowDialog();
                
            }
            else
            {
                return;
            }
            
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("BẠN CHẮC CHẮN ĐÓNG ỨNG DỤNG KHÔNG?", "Thông báo",
            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.ShowDialog();
                
            }
            else
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
