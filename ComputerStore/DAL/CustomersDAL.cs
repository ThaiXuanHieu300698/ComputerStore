using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomersDAL
    {
        private static CustomersDAL instance;
        private DBConnection dbConnection;

        public CustomersDAL()
        {
            dbConnection = new DBConnection();
        }

        public static CustomersDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomersDAL();
                }
                return instance;
            }

        }

        public DataTable Select()
        {
            string query = "SELECT * FROM Customers";
            return dbConnection.ExecuteSelectQuery(query);
        }

        public DataTable SelectByPhone(string _searchString)
        {
            string query = "SELECT * FROM Customers WHERE Phone LIKE N'%" + _searchString + "%'";
            return dbConnection.ExecuteSelectQuery(query);
        }

        public DataTable SelectFirstCustomer()
        {
            string query = "SELECT TOP 1 CustomerID FROM Customers ORDER BY CustomerID DESC";
            return dbConnection.ExecuteSelectQuery(query);
        }

        public DataTable SelectByCustomerID(int _customerID)
        {
            string query = "SELECT * FROM Customers WHERE CustomerID = @CustomerID";
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@CustomerID", SqlDbType.Int);
            parameters[0].Value = _customerID;
            return dbConnection.ExecuteSelectQuery(query, parameters);
        }

        public void Insert(string _firstName, string _lastName, string _address, string _phone, string _email)
        {
            string query = "INSERT INTO Customers VALUES (@FirstName, @LastName, @Address, @Phone, @Email)";

            SqlParameter[] parameters = new SqlParameter[5];

            parameters[0] = new SqlParameter("@FirstName", SqlDbType.NVarChar);
            parameters[0].Value = _firstName;
            parameters[1] = new SqlParameter("@LastName", SqlDbType.NVarChar);
            parameters[1].Value = _lastName;
            parameters[2] = new SqlParameter("@Address", SqlDbType.NVarChar);
            parameters[2].Value = _address;
            parameters[3] = new SqlParameter("@Phone", SqlDbType.NVarChar);
            parameters[3].Value = _phone;
            parameters[4] = new SqlParameter("@Email", SqlDbType.NVarChar);
            parameters[4].Value = _email;

            dbConnection.ExecuteInsertQuery(query, parameters);

        }

        public void Update(int _customerID, string _firstName, string _lastName, string _address, string _phone, string _email)
        {
            string query = "UPDATE Customers SET FirstName = @FirstName, LastName = @LastName, Address = @Address" +
                ", Phone = @Phone, Email = @Email WHERE CustomerID = @CustomerID";

            SqlParameter[] parameters = new SqlParameter[6];

            parameters[0] = new SqlParameter("@FirstName", SqlDbType.NVarChar);
            parameters[0].Value = _firstName;
            parameters[1] = new SqlParameter("@LastName", SqlDbType.NVarChar);
            parameters[1].Value = _lastName;
            parameters[2] = new SqlParameter("@Address", SqlDbType.NVarChar);
            parameters[2].Value = _address;
            parameters[3] = new SqlParameter("@Phone", SqlDbType.NVarChar);
            parameters[3].Value = _phone;
            parameters[4] = new SqlParameter("@Email", SqlDbType.NVarChar);
            parameters[4].Value = _email;
            parameters[5] = new SqlParameter("@CustomerID", SqlDbType.NVarChar);
            parameters[5].Value = _customerID;


            dbConnection.ExecuteUpdateQuery(query, parameters);
        }

        public void DeleteByCustomerID(int _customerID)
        {
            string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@CustomerID", SqlDbType.Int);
            parameters[0].Value = _customerID;

            dbConnection.ExecuteDeleteQuery(query, parameters);
        }
    }
}
