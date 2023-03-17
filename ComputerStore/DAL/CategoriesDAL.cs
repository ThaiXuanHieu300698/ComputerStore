using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoriesDAL
    {
        private static CategoriesDAL instance;
        private DBConnection dbConnection;

        public CategoriesDAL()
        {
            dbConnection = new DBConnection();
        }

        public static CategoriesDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CategoriesDAL();
                }
                return instance;
            }
        }



        public DataTable Select()
        {
            string query = "SELECT * FROM Categories";
            return dbConnection.ExecuteSelectQuery(query);
        }

        public DataTable Select(string _searchString)
        {
            string query = "SELECT * FROM Categories WHERE CategoryName LIKE N'%" + _searchString + "%'";


            return dbConnection.ExecuteSelectQuery(query);
        }

        public DataTable SelectByCategoryID(int _categoryID)
        {
            string query = "SELECT * FROM Categories WHERE CategoryID = @CategoryID";
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@CategoryID", SqlDbType.NVarChar);
            parameters[0].Value = _categoryID;

            return dbConnection.ExecuteSelectQuery(query, parameters);
        }

        public void Insert(string _categoryName, string _description)
        {
            string query = "INSERT INTO Categories VALUES (@CategoryName, @Description)";

            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@CategoryName", SqlDbType.NVarChar);
            parameters[0].Value = _categoryName;
            parameters[1] = new SqlParameter("@Description", SqlDbType.NVarChar);
            parameters[1].Value = _description;

            dbConnection.ExecuteInsertQuery(query, parameters);

        }

        public void Update(int _categoryID, string _categoryName, string _description)
        {
            string query = "UPDATE Categories SET CategoryName = @CategoryName, Description = @Description" +
                " WHERE CategoryID = @CategoryID";

            SqlParameter[] parameters = new SqlParameter[3];

            parameters[0] = new SqlParameter("@CategoryID", SqlDbType.Int);
            parameters[0].Value = _categoryID;
            parameters[1] = new SqlParameter("@CategoryName", SqlDbType.NVarChar);
            parameters[1].Value = _categoryName;
            parameters[2] = new SqlParameter("@Description", SqlDbType.NVarChar);
            parameters[2].Value = _description;


            dbConnection.ExecuteUpdateQuery(query, parameters);
        }

        public void DeleteByCategoryID(int _categoryID)
        {
            string query = "DELETE FROM Categories WHERE CategoryID = @CategoryID";

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@CategoryID", SqlDbType.Int);
            parameters[0].Value = _categoryID;

            dbConnection.ExecuteDeleteQuery(query, parameters);
        }
    }
}
