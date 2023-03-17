using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Common;
using BLL;

namespace GUI
{
    public partial class UserPage : UserControl
    {
        private UsersDTO user;
        string imageLocation = "";

        public UserPage(UsersDTO user)
        {
            InitializeComponent();
            this.user = user;
        }

        // Sự kiện nút thay đổi hình ảnh được nhấn
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

        private void UserPage_Load(object sender, EventArgs e)
        {
            picAvatar.ImageLocation = user.Avatar;
            imageLocation = user.Avatar;
            txtFullName.Text = user.FullName;
            switch (user.Gender)
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
            txtPhone.Text = user.Phone;
            txtEmail.Text = user.Email;
            txtUsername.Text = user.UserName;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (!Encryption.MD5Hash(txtPassword.Text).Equals(user.Password))
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return;
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            
            if(!txtNewPassword.Text.Equals(txtReEnterPassword.Text))
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            UsersBLL.Instance.UpdatePassword(user.UserID, Encryption.MD5Hash(txtNewPassword.Text));
            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

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
            if(!EmailValidation.IsValid(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(!PhoneNumberValidation.IsValid(txtPhone.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            UsersBLL.Instance.UpdateProfile(user.UserID, txtFullName.Text, txtUsername.Text, IsChecked(), txtEmail.Text, txtPhone.Text, imageLocation);
            MessageBox.Show("Cập nhật hồ sơ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
