using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UsersDTO
    {
        private int userID;
        private string fullName;
        private string userName;
        private string password;
        private string gender;
        private string email;
        private string phone;
        private string avatar;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        
    }
}
