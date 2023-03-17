using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsersBLL
    {
        private static UsersBLL instance;

        public UsersBLL()
        {

        }

        public static UsersBLL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new UsersBLL();
                }
                return instance;
            }
        }

        public DataTable GetAll()
        {
            return UsersDAL.Instance.Select();
        }

        public DataTable GetUserByUserName(string _userName)
        {
            return UsersDAL.Instance.SelectByUserName(_userName);
        }

        public DataTable GetByUerNameAndPassword(string _userName, string _password)
        {
            return UsersDAL.Instance.Select(_userName, _password);
        }

        public DataTable GetByEmail(string _email)
        {
            return UsersDAL.Instance.SelectByEmail(_email);
        }

        public UsersDTO GetUserByUserID(int _userID)
        {
            UsersDTO user = new UsersDTO();
            DataTable dataTable = new DataTable();
            dataTable = UsersDAL.Instance.SelectByUserID(_userID);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                user.UserID = Int32.Parse(dataRow["UserID"].ToString());
                user.FullName = dataRow["FullName"].ToString();
                user.UserName = dataRow["UserName"].ToString();
                user.Password = dataRow["Password"].ToString();
                user.Gender = dataRow["Gender"].ToString();
                user.Email = dataRow["Email"].ToString();
                user.Phone = dataRow["Phone"].ToString();
                user.Avatar = dataRow["Avatar"].ToString();
            }
            return user;
        }

        public void Insert(string _fullName, string _userName, string _password, string _gender, string _email, string _phone, string _avatar)
        {
            UsersDAL.Instance.Insert(_fullName, _userName, _password, _gender, _email, _phone, _avatar);
        }

        public void Insert(string _fullName, string _userName, string _password)
        {
            UsersDAL.Instance.Insert(_fullName, _userName, _password);
        }

        public void UpdateProfile(int _userID, string _fullName, string _userName, string _gender, string _email, string _phone, string _avatar)
        {
            UsersDAL.Instance.UpdateProfile(_userID, _fullName, _userName, _gender, _email, _phone, _avatar);
        }

        public void UpdatePassword(int _userID, string _newPassword)
        {
            UsersDAL.Instance.UpdatePassword(_userID, _newPassword);
        }

        public void DeleteByUserID(int _userID)
        {
            UsersDAL.Instance.Delete(_userID);
        }
    }
}
