using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using DTO;

namespace GUI
{
    public partial class frmCustomer : Form
    {
        UsersDTO user;
        public frmCustomer(UsersDTO user)
        {
            InitializeComponent();

            this.user = user;

        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            picAvatar.ImageLocation = user.Avatar;
            lblNameCustomer.Text = user.FullName;
            homePage.Visible = true;
            softwarePage.Visible = false;
            computerPage.Visible = false;
            laptopPage.Visible = false;
            accessoriesPage.Visible = false;
            componentsPage.Visible = false;
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            homePage.Visible = true;
            softwarePage.Visible = false;
            computerPage.Visible = false;
            laptopPage.Visible = false;
            accessoriesPage.Visible = false;
            componentsPage.Visible = false;
        }

        private void btnSoftwarePage_Click(object sender, EventArgs e)
        {
            softwarePage.Visible = true;
            homePage.Visible = false;
            computerPage.Visible = false;
            laptopPage.Visible = false;
            accessoriesPage.Visible = false;
            componentsPage.Visible = false;
        }

        private void btnComputerPage_Click(object sender, EventArgs e)
        {
            computerPage.Visible = true;
            softwarePage.Visible = false;
            homePage.Visible = false;
            laptopPage.Visible = false;
            accessoriesPage.Visible = false;
            componentsPage.Visible = false;

        }

        private void btnLaptopPage_Click(object sender, EventArgs e)
        {
            laptopPage.Visible = true;
            computerPage.Visible = false;
            softwarePage.Visible = false;
            homePage.Visible = false;
            accessoriesPage.Visible = false;
            componentsPage.Visible = false;
        }

        private void btnAccessoriesPage_Click(object sender, EventArgs e)
        {
            accessoriesPage.Visible = true;
            laptopPage.Visible = false;
            computerPage.Visible = false;
            softwarePage.Visible = false;
            homePage.Visible = false;
            componentsPage.Visible = false;
        }

        private void btnComponentsPage_Click(object sender, EventArgs e)
        {
            componentsPage.Visible = true;
            accessoriesPage.Visible = false;
            laptopPage.Visible = false;
            computerPage.Visible = false;
            softwarePage.Visible = false;
            homePage.Visible = false;

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

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

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
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
