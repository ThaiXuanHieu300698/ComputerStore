using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WarehouseDAL
    {
        private static WarehouseDAL instance;
        private DBConnection dbConnection;

        public WarehouseDAL()
        {
            dbConnection = new DBConnection();
        }

        public static WarehouseDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WarehouseDAL();
                }
                return instance;
            }
        }

        public DataTable SelectAll()
        {
            string query = "SELECT s.SupplierID, s.CompanyName, p.ProductID, p.Price, w.Stock FROM Products AS p INNER JOIN Warehouse AS w" +
                " ON p.ProductID = w.ProductID INNER JOIN Suppliers AS s ON s.SupplierID = p.SupplierID ORDER BY s.CompanyName";
            return dbConnection.ExecuteSelectQuery(query);
        }

        public DataTable SelectByProductID(int _productID)
        {
            string query = "SELECT * FROM Warehouse WHERE ProductID = @ProductID";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@ProductID", SqlDbType.Int);
            parameters[0].Value = _productID;
            return dbConnection.ExecuteSelectQuery(query, parameters);
        }

        public DataTable SelectBySupplierID(int _supplierID)
        {
            string query = "SELECT s.SupplierID, s.CompanyName, p.ProductID, p.Price, w.Stock FROM Products AS p INNER JOIN Warehouse AS w" +
                " ON p.ProductID = w.ProductID INNER JOIN Suppliers AS s ON s.SupplierID = p.SupplierID" +
                " WHERE s.SupplierID = @SupplierID";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@SupplierID", SqlDbType.Int);
            parameters[0].Value = _supplierID;

            return dbConnection.ExecuteSelectQuery(query, parameters);
        }

        public DataTable SelectProductBySearchString(string _searchString)
        {
            string query = "SELECT s.SupplierID, s.CompanyName, p.ProductID, p.Price, w.Stock FROM Products AS p INNER JOIN Warehouse AS w" +
                " ON p.ProductID = w.ProductID INNER JOIN Suppliers AS s ON s.SupplierID = p.SupplierID" +
                " WHERE p.ProductName LIKE N'%" + _searchString + "%'";
            return dbConnection.ExecuteSelectQuery(query);
        }

        public void Insert(int _productID, int _stock)
        {
            string query = "INSERT INTO Warehouse VALUES(@ProductID, @Stock)";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@ProductID", SqlDbType.Int);
            parameters[0].Value = _productID;
            parameters[1] = new SqlParameter("@Stock", SqlDbType.Int);
            parameters[1].Value = _stock;

            dbConnection.ExecuteInsertQuery(query, parameters);
        }

        public void Update(int _productID, int _stock)
        {
            string query = "UPDATE Warehouse SET Stock = @Stock WHERE ProductID = @ProductID";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@Stock", SqlDbType.Int);
            parameters[0].Value = _stock;
            parameters[1] = new SqlParameter("@ProductID", SqlDbType.Int);
            parameters[1].Value = _productID;

            dbConnection.ExecuteUpdateQuery(query, parameters);
        }

        public void Delete(int _productID)
        {
            string query = "DELETE FROM Warehouse WHERE ProductID = @ProductID";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@ProductID", SqlDbType.Int);
            parameters[0].Value = _productID;

            dbConnection.ExecuteDeleteQuery(query, parameters);
        }
    }
}
