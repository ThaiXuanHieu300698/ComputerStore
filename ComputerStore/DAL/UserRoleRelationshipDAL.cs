using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRoleRelationshipDAL
    {
        private static UserRoleRelationshipDAL instance;
        private DBConnection dbConnection;

        public UserRoleRelationshipDAL()
        {
            dbConnection = new DBConnection();
        }

        public static UserRoleRelationshipDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserRoleRelationshipDAL();
                }
                return instance;
            }
        }

        public DataTable Select()
        {
            string query = "SELECT u.UserID, u.UserName, r.RoleName FROM Users AS u INNER JOIN UserRoleRelationship AS ur ON ur.UserID = u.UserID" +
                " LEFT JOIN Roles AS r ON r.RoleID = ur.RoleID";
            return dbConnection.ExecuteSelectQuery(query);
        }

        public DataTable SelectByUserID(int _userID)
        {
            string query = "SELECT UserID, RoleID FROM UserRoleRelationship WHERE UserID = @UserID";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@UserID", SqlDbType.Int);
            parameters[0].Value = _userID;
            return dbConnection.ExecuteSelectQuery(query, parameters);
        }

        public void Update(int _userID, int _roleID)
        {
            string query = "UPDATE UserRoleRelationship SET RoleID = @RoleID WHERE UserID = @UserID";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@RoleID", SqlDbType.Int);
            parameters[0].Value = _roleID;
            parameters[1] = new SqlParameter("@UserID", SqlDbType.Int);
            parameters[1].Value = _userID;

            dbConnection.ExecuteUpdateQuery(query, parameters);
        }
    }
}
