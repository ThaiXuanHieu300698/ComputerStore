using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class UsersDAL
    {
        private DBConnection dbConnection;
        private static UsersDAL instance;

        public UsersDAL()
        {
            dbConnection = new DBConnection();
        }

        public static UsersDAL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new UsersDAL();
                }
                return instance;
            }
        }


        public DataTable Select()
        {
            string query = "SELECT * FROM Users";

            return dbConnection.ExecuteSelectQuery(query);
        }

        public DataTable Select(string _userName, string _password)
        {
            string query = "SELECT * FROM Users WHERE UserName = @userName AND Password = @password";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@userName", SqlDbType.VarChar);
            parameters[0].Value = _userName;
            parameters[1] = new SqlParameter("@password", SqlDbType.VarChar);
            parameters[1].Value = _password;

            return dbConnection.ExecuteSelectQuery(query, parameters);
        }

        public DataTable SelectByUserName(string _userName)
        {
            string query = "SELECT UserName FROM Users WHERE UserName = @userName";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@userName", SqlDbType.VarChar);
            parameters[0].Value = _userName;

            return dbConnection.ExecuteSelectQuery(query, parameters);
        }

        public DataTable SelectByEmail(string _email)
        {
            string query = "SELECT * FROM Users WHERE Email = @Email";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Email", SqlDbType.VarChar);
            parameters[0].Value = _email;

            return dbConnection.ExecuteSelectQuery(query, parameters);
        }

        public DataTable SelectByUserID(int _userID)
        {
            string query = "SELECT * FROM Users WHERE UserID = @UserID";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@UserID", SqlDbType.Int);
            parameters[0].Value = _userID;

            return dbConnection.ExecuteSelectQuery(query, parameters);
        }

        public void Insert(string _fullName, string _userName, string _password, string _gender, string _email, string _phone, string _avatar)
        {
            string query = "INSERT INTO Users VALUES (@fullName, @userName, @password, @gender, @email, @phone, @avatar)";
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@fullName", SqlDbType.NVarChar);
            parameters[0].Value = _fullName;
            parameters[1] = new SqlParameter("@userName", SqlDbType.VarChar);
            parameters[1].Value = _userName;
            parameters[2] = new SqlParameter("@password", SqlDbType.VarChar);
            parameters[2].Value = _password;
            parameters[3] = new SqlParameter("@gender", SqlDbType.NVarChar);
            parameters[3].Value = _gender;
            parameters[4] = new SqlParameter("@email", SqlDbType.VarChar);
            parameters[4].Value = _email;
            parameters[5] = new SqlParameter("@phone", SqlDbType.VarChar);
            parameters[5].Value = _phone;
            parameters[6] = new SqlParameter("@avatar", SqlDbType.NVarChar);
            parameters[6].Value = _avatar;

            dbConnection.ExecuteInsertQuery(query, parameters);
        }

        public void Insert(string _fullName, string _userName, string _password)
        {
            string query = "INSERT INTO Users VALUES (@fullName, @userName, @password)";
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@fullName", SqlDbType.NVarChar);
            parameters[0].Value = _fullName;
            parameters[1] = new SqlParameter("@userName", SqlDbType.VarChar);
            parameters[1].Value = _userName;
            parameters[2] = new SqlParameter("@password", SqlDbType.VarChar);
            parameters[2].Value = _password;

            dbConnection.ExecuteInsertQuery(query, parameters);
        }

            public void UpdateProfile(int _userID, string _fullName, string _userName, string _gender, string _email, string _phone, string _avatar)
        {
            string query = "UPDATE Users SET FullName = @fullName, UserName = @userName" +
                ", Gender = @gender, Email = @email, Phone = @phone, Avatar = @avatar WHERE UserID = @userID";
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@fullName", SqlDbType.NVarChar);
            parameters[0].Value = _fullName;
            parameters[1] = new SqlParameter("@userName", SqlDbType.VarChar);
            parameters[1].Value = _userName;
            parameters[2] = new SqlParameter("@gender", SqlDbType.NVarChar);
            parameters[2].Value = _gender;
            parameters[3] = new SqlParameter("@email", SqlDbType.VarChar);
            parameters[3].Value = _email;
            parameters[4] = new SqlParameter("@phone", SqlDbType.VarChar);
            parameters[4].Value = _phone;
            parameters[5] = new SqlParameter("@avatar", SqlDbType.NVarChar);
            parameters[5].Value = _avatar;
            parameters[6] = new SqlParameter("@userID", SqlDbType.Int);
            parameters[6].Value = _userID;

            dbConnection.ExecuteUpdateQuery(query, parameters);
        }

        public void UpdatePassword(int _userID, string _newPassword)
        {
            string query = "UPDATE Users SET Password = @newPassword WHERE UserID = @userID";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@newPassword", SqlDbType.NVarChar);
            parameters[0].Value = _newPassword;
            parameters[1] = new SqlParameter("@userID", SqlDbType.Int);
            parameters[1].Value = _userID;

            dbConnection.ExecuteUpdateQuery(query, parameters);
        }

        public void Delete(int _userID)
        {
            string query = "DELETE FROM Users WHERE UserID = @userID";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("userID", SqlDbType.Int);
            parameters[0].Value = _userID;

            dbConnection.ExecuteDeleteQuery(query, parameters);
        }
    }
}
