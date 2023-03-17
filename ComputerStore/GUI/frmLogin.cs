using BLL;
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
using Common;
using System.Net.Mail;
using System.Net;

namespace GUI
{
    public partial class frmLogin : Form
    {
        bool hidden;    // Biến này kiểm tra xem pnl có ẩn hay ko. 
        bool hidden1;
        public frmLogin()
        {
            InitializeComponent();
            hidden = true; //Bản đầu nó ẩn
            hidden1 = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                pnlSignup.Width = pnlSignup.Width + 10;
                if (pnlSignup.Width >= 395)
                {
                    Timer.Stop();
                    hidden = false;
                    this.Refresh();
                }

            }
            else
            {
                pnlSignup.Width = pnlSignup.Width - 10;
                if (pnlSignup.Width <= 10)
                {
                    Timer.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        private void llbBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer.Start();
        }

        private void llbSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer.Start();
        }

        private void llbBack1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer1.Start();
        }

        // LinkLabel Quên mật khẩu được nhấn
        private void llbForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer1.Start(); // Bắt đầu chạy luồng
            btnGenNewPassword.Enabled = true;
        }

        // Sự kiện này sau thời gian bao nhiều ml giây sẽ quay lại thực hiện
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (hidden1)
            {
                pnlRight.Width = pnlRight.Width + 10;
                if (pnlRight.Width >= 280)
                {
                    Timer1.Stop();
                    hidden1 = false;
                    this.Refresh();
                }

            }
            else
            {
                pnlRight.Width = pnlRight.Width - 10;
                if (pnlRight.Width <= 10)
                {
                    Timer1.Stop();
                    hidden1 = true;
                    this.Refresh();
                }
            }
        }
        // Chuyện gì sẽ xảy ra khi nút Đăng nhập được nhấn
        private void btnSignin_Click(object sender, EventArgs e)
        {
            DataTable dtUsers = UsersBLL.Instance.GetByUerNameAndPassword(txtUsername.Text, Encryption.MD5Hash(txtPassword.Text));
            if (dtUsers.Rows.Count != 0)    // Kiểm tra xem có tồn tại bản ghi không
            {
                int userID = dtUsers.Rows[0].Field<int>("UserID"); // Lấy dữ liệu theo tên cột
                UsersDTO user = UsersBLL.Instance.GetUserByUserID(userID); // Lấy ra đối tượng User đã set dữ liệu ở UsersBLL
                DataTable dtUserRoleRelationship = UserRoleRelationshipBLL.Instance.GetByUserID(userID);
                int roleID = dtUserRoleRelationship.Rows[0].Field<int>("RoleID");
                if(roleID == 1)
                {
                    this.Hide();
                    frmAdmin admin = new frmAdmin(user);
                    admin.ShowDialog();
                }
                else if(roleID == 2)
                {
                    this.Hide();
                    frmAdmin admin = new frmAdmin(user);
                    admin.ShowDialog();
                }
                else
                {
                    this.Hide();
                    frmCustomer customer = new frmCustomer(user);
                    customer.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("TÀI KHOẢN NÀY KHÔNG TỒN TẠI", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Chuyện gì sẽ xảy ra khi nút Đăng ký được nhấn
        private void btnSignup_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtUsernameNew.Text) || String.IsNullOrEmpty(txtPasswordNew.Text) || String.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("BẠN PHẢI NHẬP ĐẨY ĐỦ THÔNG TIN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable dtUser = UsersBLL.Instance.GetUserByUserName(txtUsernameNew.Text);
            if (dtUser.Rows.Count != 0) // Kiểm tra có tồn tại bản ghi không
            {
                MessageBox.Show("TÀI KHOẢN NÀY ĐÃ TỒN TÀI", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!txtPasswordNew.Text.Equals(txtReEnterPassword.Text))
            {
                MessageBox.Show("MẬT KHẨU KHÔNG KHỚP", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Sau khi kiểm tra xem đầu vào đã hợp lệ
            // Thực hiện thêm vào db
            UsersBLL.Instance.Insert(txtFullName.Text, txtUsernameNew.Text, Encryption.MD5Hash(txtPasswordNew.Text));
            MessageBox.Show("ĐĂNG KÝ THÀNH CÔNG", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        // Sự kiện nhấn nút WindowsClose
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("BẠN CHẮC CHẮN ĐÓNG ỨNG DỤNG KHÔNG?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            Application.ExitThread();
        }

        // Hàm lấy lại mật khẩu
        private void btnGenNewPassword_Click(object sender, EventArgs e)
        {
            if(!EmailValidation.IsValid(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable dtUsers = UsersBLL.Instance.GetByEmail(txtEmail.Text);
            if(dtUsers.Rows.Count != 0)// Nếu tồn tại bản ghi
            {
                // Phát sinh ngẫu nhiên mật khẩu mới
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var stringChars = new char[8];
                var random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                string newPassword = new String(stringChars);
                // Không cho phép tạo mật khẩu mới nhiều lần
                btnGenNewPassword.Enabled = false;

                try
                {
                    // Gửi mật khẩu về Gmail
                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress("likeafternoonqp@gmail.com");
                    msg.To.Add(txtEmail.Text);
                    msg.Subject = "Thông báo Bảo mật quan trọng";
                    msg.Body = "Mật khẩu mới của bạn : " + newPassword;

                    SmtpClient smt = new SmtpClient();
                    smt.Host = "smtp.gmail.com";
                    System.Net.NetworkCredential ntcd = new NetworkCredential();
                    ntcd.UserName = "likeafternoonqp@gmail.com";
                    ntcd.Password = "Matkhauqp1";
                    smt.Credentials = ntcd;
                    smt.EnableSsl = true;
                    smt.Port = 587;
                    smt.Send(msg);

                    MessageBox.Show("Mật khẩu mới của bạn được gửi về Email của bạn");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Cập nhật lại mật khẩu cho người dùng
                int userID = dtUsers.Rows[0].Field<int>("UserID");
                UsersBLL.Instance.UpdatePassword(userID, Encryption.MD5Hash(newPassword));
                
            }
            else
            {
                MessageBox.Show("EMAIL NÀY KHÔNG TỒN TẠI", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
