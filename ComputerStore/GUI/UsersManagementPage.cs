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
using System.Data.SqlClient;

namespace GUI
{
    public partial class UsersManagementPage : UserControl
    {
        bool hidden;
        bool isNew = false;
        bool isNew1 = false;
        int roleID;

        string imageLocation = ""; // Lưu đường dẫn ảnh khi nhấn nút thay đổi hình ảnh

        public UsersManagementPage()
        {
            InitializeComponent();
            hidden = true;
        }

        private void UsersManagementPage_Load(object sender, EventArgs e)
        {

            DisplayData();
            isEnabled(false);
        }

        private void DisplayData()
        {
            // Hiển thị data
            dgvListUser.DataSource = UsersBLL.Instance.GetAll();
        }

        private void isEnabled(bool enabled)
        {
            txtFullName.Enabled = enabled;
            txtUserName.Enabled = enabled;
            txtPassword.Enabled = enabled;
            txtPhone.Enabled = enabled;
            txtEmail.Enabled = enabled;

            btnAddUser.Enabled = !enabled;
            btnEditUser.Enabled = !enabled;
            btnDeleteUser.Enabled = !enabled;
            btnSave.Enabled = enabled;
            btnChangeImage.Enabled = enabled;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            isEnabled(true);
            isNew = true;

            txtFullName.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            picAvatar.ImageLocation = "";
            txtFullName.Focus();
        }
        // Kiểm tra rd nào được Check
        private string IsChecked()
        {
            if (rdMale.Checked)
                return "Nam";
            else if (rdFemale.Checked)
                return "Nữ";
            else
                return "Khác";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtFullName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên cho người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if(txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cho tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (picAvatar.ImageLocation == "")
            {
                MessageBox.Show("Vui lòng chọn ảnh cho người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(isNew == true)   // Nếu nhấn nút Thêm
            {
                DataTable dtUser = UsersBLL.Instance.GetUserByUserName(txtUserName.Text);
                if (dtUser.Rows.Count != 0)
                {
                    MessageBox.Show("Tài khoản này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                UsersBLL.Instance.Insert(txtFullName.Text, txtUserName.Text, Encryption.MD5Hash(txtPassword.Text), IsChecked(), txtEmail.Text, txtPhone.Text, imageLocation);
            }
            else // Nếu nhấn nút Sửa
            {
                txtPassword.Enabled = false;
                int row = dgvListUser.CurrentRow.Index;
                int userID = Convert.ToInt32(dgvListUser.Rows[row].Cells[0].Value.ToString());
                UsersBLL.Instance.UpdateProfile(userID, txtFullName.Text, txtUserName.Text, IsChecked(), txtEmail.Text, txtPhone.Text, imageLocation);
            }

            DisplayData();
            isEnabled(false);
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            isEnabled(true);
            isNew = false;
            txtFullName.Focus();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Chắc chắn xóa người dùng đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == System.Windows.Forms.DialogResult.No) return;

            int row = dgvListUser.CurrentRow.Index;
            int userID = Convert.ToInt32(dgvListUser.Rows[row].Cells[0].Value.ToString());
            UsersBLL.Instance.DeleteByUserID(userID);

            DisplayData();
        }

        private void dgvListUser_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtFullName.Text = dgvListUser.Rows[row].Cells[1].Value.ToString();
            txtUserName.Text = dgvListUser.Rows[row].Cells[2].Value.ToString();
            txtPassword.Text = dgvListUser.Rows[row].Cells[3].Value.ToString();

            switch (dgvListUser.Rows[row].Cells[4].Value.ToString())
            {
                case "Nam":
                    rdMale.Checked = true;
                    break;
                case "Nữ":
                    rdFemale.Checked = true;
                    break;
                default:
                    rdOrther.Checked = true;
                    break;
            }
            txtEmail.Text = dgvListUser.Rows[row].Cells[5].Value.ToString();
            txtPhone.Text = dgvListUser.Rows[row].Cells[6].Value.ToString();
            imageLocation = dgvListUser.Rows[row].Cells[7].Value.ToString();
            picAvatar.ImageLocation = imageLocation;
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;..."; ;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    picAvatar.ImageLocation = imageLocation;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi! Không thể tải ảnh lên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void llbRoleManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataTable dtUser = UsersBLL.Instance.GetAll();
            cbFullName.DataSource = dtUser;
            cbFullName.DisplayMember = "FullName";
            cbFullName.ValueMember = "UserID";

            dgvRoleUsers.DataSource = UserRoleRelationshipBLL.Instance.GetAll();
            dgvRoles.DataSource = RolesBLL.Instance.GetRoles();

            Timer.Start();
        }

        private void llbBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                pnlRoleManagement.Width += 10;
                if (pnlRoleManagement.Width >= 1020)
                {
                    Timer.Stop();
                    hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlRoleManagement.Width -= 10;
                if (pnlRoleManagement.Width <= 10)
                {
                    Timer.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        
        private void btnAddRole_Click(object sender, EventArgs e)
        {
            isNew1 = true;
        }

        private void btnSaveRole_Click(object sender, EventArgs e)
        {
            if(txtRoleName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên cho quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(isNew1 == true)
            {
                RolesBLL.Instance.Insert(txtRoleName.Text);
            }
            else
            {
                RolesBLL.Instance.Update(roleID, txtRoleName.Text);
            }
            // Hiển thị lại data
            dgvRoles.DataSource = RolesBLL.Instance.GetRoles();
            dgvRoleUsers.DataSource = UserRoleRelationshipBLL.Instance.GetAll();
        }

        private void btnEditRole_Click(object sender, EventArgs e)
        {
            isNew1 = false;
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Chắc chắn xóa quyền đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == System.Windows.Forms.DialogResult.No) return;

            int row = dgvRoles.CurrentRow.Index;
            int roleID = Convert.ToInt32(dgvRoles.Rows[row].Cells[0].Value.ToString());
            RolesBLL.Instance.Delete(roleID);
            // Hiển thị lại data
            dgvRoles.DataSource = RolesBLL.Instance.GetRoles();
            dgvRoleUsers.DataSource = UserRoleRelationshipBLL.Instance.GetAll();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {

        }

        private void btnPermissionRole_Click(object sender, EventArgs e)
        {
            UserRoleRelationshipBLL.Instance.Update(Convert.ToInt32(cbFullName.SelectedValue.ToString()), roleID);
            dgvRoleUsers.DataSource = UserRoleRelationshipBLL.Instance.GetAll();
        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {

        }

        private void dgvRoles_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            roleID = Convert.ToInt32(dgvRoles.Rows[row].Cells[0].Value.ToString());
            txtRoleName.Text = dgvRoles.Rows[row].Cells[1].Value.ToString();
        }

        private void dgvRoleUsers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            cbFullName.SelectedValue = dgvRoleUsers.Rows[row].Cells[0].Value.ToString();
            txtRoleName.Text = dgvRoleUsers.Rows[row].Cells[2].Value.ToString();
        }

        
    }
}
