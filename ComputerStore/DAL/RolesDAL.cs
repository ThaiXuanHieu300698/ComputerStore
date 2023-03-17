using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RolesDAL
    {
        private static RolesDAL instance;
        private DBConnection dbConnection;

        public RolesDAL()
        {
            dbConnection = new DBConnection();
        }

        public static RolesDAL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new RolesDAL();
                }
                return instance;
            }
        }

        public DataTable SelectRoles()
        {
            string query = "SELECT * FROM Roles";
            return dbConnection.ExecuteSelectQuery(query);
        }

        public void Insert(string _roleName)
        {
            string query = "INSERT INTO Roles VALUES(@RoleName)";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@RoleName", SqlDbType.NVarChar);
            parameters[0].Value = _roleName;

            dbConnection.ExecuteInsertQuery(query, parameters);
        }

        public void Update(int _roleID, string _roleName)
        {
            string query = "UPDATE Roles SET RoleName = @RoleName WHERE RoleID = @RoleID";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@RoleName", SqlDbType.NVarChar);
            parameters[0].Value = _roleName;
            parameters[1] = new SqlParameter("@RoleID", SqlDbType.Int);
            parameters[1].Value = _roleID;

            dbConnection.ExecuteUpdateQuery(query, parameters);
        }

        public void Delete(int _roleID)
        {
            string query = "DELETE FROM Roles WHERE RoleID = @RoleID";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@RoleID", SqlDbType.Int);
            parameters[0].Value = _roleID;

            dbConnection.ExecuteDeleteQuery(query, parameters);
        }
    }
}
