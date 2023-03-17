using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SuppliersDAL
    {
        private static SuppliersDAL instance;
        private DBConnection dbConnection;

        public SuppliersDAL()
        {
            dbConnection = new DBConnection();
        }

        public static SuppliersDAL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new SuppliersDAL();
                }
                return instance;
            }
        }

        public DataTable Select()
        {
            string query = "SELECT * FROM Suppliers";
            return dbConnection.ExecuteSelectQuery(query);
        }

        public DataTable SelectBySearchString(string _searchString)
        {
            string query = "SELECT * FROM Suppliers WHERE CompanyName LIKE N'%" + _searchString + "%'";
            return dbConnection.ExecuteSelectQuery(query);
        }

        public DataTable SelectBySupplier(int _supplierID)
        {
            string query = "SELECT * FROM Suppliers WHERE SupplierID = @SupplierID";
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@SupplierID", SqlDbType.Int);
            parameters[0].Value = _supplierID;
            return dbConnection.ExecuteSelectQuery(query, parameters);
        }

        public void Insert(string _companyName, string _contactName, string _address, string _phone, string _email)
        {
            string query = "INSERT INTO Suppliers VALUES (@CompanyName, @ContactName, @Address, @Phone, @Email)";

            SqlParameter[] parameters = new SqlParameter[5];

            parameters[0] = new SqlParameter("@CompanyName", SqlDbType.NVarChar);
            parameters[0].Value = _companyName;
            parameters[1] = new SqlParameter("@ContactName", SqlDbType.NVarChar);
            parameters[1].Value = _contactName;
            parameters[2] = new SqlParameter("@Address", SqlDbType.NVarChar);
            parameters[2].Value = _address;
            parameters[3] = new SqlParameter("@Phone", SqlDbType.NVarChar);
            parameters[3].Value = _phone;
            parameters[4] = new SqlParameter("@Email", SqlDbType.NVarChar);
            parameters[4].Value = _email;

            dbConnection.ExecuteInsertQuery(query, parameters);

        }

        public void Update(int _supplierID, string _companyName, string _contactName, string _address, string _phone, string _email)
        {
            string query = "UPDATE Suppliers SET CompanyName = @CompanyName, ContactName = @ContactName, Address = @Address" +
                ", Phone = @Phone, Email = @Email WHERE SupplierID = @SupplierID";

            SqlParameter[] parameters = new SqlParameter[6];

            parameters[0] = new SqlParameter("@CompanyName", SqlDbType.NVarChar);
            parameters[0].Value = _companyName;
            parameters[1] = new SqlParameter("@ContactName", SqlDbType.NVarChar);
            parameters[1].Value = _contactName;
            parameters[2] = new SqlParameter("@Address", SqlDbType.NVarChar);
            parameters[2].Value = _address;
            parameters[3] = new SqlParameter("@Phone", SqlDbType.NVarChar);
            parameters[3].Value = _phone;
            parameters[4] = new SqlParameter("@Email", SqlDbType.NVarChar);
            parameters[4].Value = _email;
            parameters[5] = new SqlParameter("@SupplierID", SqlDbType.NVarChar);
            parameters[5].Value = _supplierID;


            dbConnection.ExecuteUpdateQuery(query, parameters);
        }

        public void DeleteBySupplierID(int _supplierID)
        {
            string query = "DELETE FROM Suppliers WHERE SupplierID = @SupplierID";

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@SupplierID", SqlDbType.Int);
            parameters[0].Value = _supplierID;

            dbConnection.ExecuteDeleteQuery(query, parameters);
        }
    }
}
