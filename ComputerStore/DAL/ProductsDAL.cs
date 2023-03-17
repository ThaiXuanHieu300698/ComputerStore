using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ProductsDAL
    {
        private DBConnection dbConnection;
        private static ProductsDAL instance;

        public static ProductsDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductsDAL();
                }
                return instance;
            }
        }

        public ProductsDAL()
        {
            dbConnection = new DBConnection();
        }



        public DataTable Select()
        {
            string query = "SELECT * FROM Products";
            return dbConnection.ExecuteSelectQuery(query);
        }

        public DataTable SelectByProductID(int _productID)
        {
            string query = "SELECT * FROM Products WHERE ProductID = @ProductID";
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@ProductID", SqlDbType.Int);
            parameters[0].Value = _productID;
            return dbConnection.ExecuteSelectQuery(query, parameters);
        }

        public DataTable SelectColumn()
        {
            string query = "SELECT ProductID, ProductName, Unit, Price FROM Products";
            return dbConnection.ExecuteSelectQuery(query);
        }

        public DataTable SelectColumn(string _searchString)
        {
            string query = "SELECT ProductID, ProductName, Unit, Price FROM Products WHERE ProductName LIKE N'%" + _searchString + "%'";
            return dbConnection.ExecuteSelectQuery(query);
        }

        public DataTable SelectBySearchString(string _searchString)
        {
            string query = "SELECT * FROM Products WHERE ProductName LIKE N'%" + _searchString + "%'";


            return dbConnection.ExecuteSelectQuery(query);
        }

        public void Insert(int _categoryID, int _supplierID, string _productName, string _productImage, string _unit, double _price, string _description)
        {
            string query = "INSERT INTO Products VALUES (@CategoryID, @SupplierID, @ProductName, " +
                "@ProductImage, @Unit, @Price, @Description)";

            SqlParameter[] parameters = new SqlParameter[7];

            parameters[0] = new SqlParameter("@CategoryID", SqlDbType.Int);
            parameters[0].Value = _categoryID;
            parameters[1] = new SqlParameter("@SupplierID", SqlDbType.Int);
            parameters[1].Value = _supplierID;
            parameters[2] = new SqlParameter("@ProductName", SqlDbType.NVarChar);
            parameters[2].Value = _productName;
            parameters[3] = new SqlParameter("@ProductImage", SqlDbType.NVarChar);
            parameters[3].Value = _productImage;
            parameters[4] = new SqlParameter("@Unit", SqlDbType.NVarChar);
            parameters[4].Value = _unit;
            parameters[5] = new SqlParameter("@Price", SqlDbType.Money);
            parameters[5].Value = _price;
            parameters[6] = new SqlParameter("@Description", SqlDbType.NVarChar);
            parameters[6].Value = _description;
            dbConnection.ExecuteInsertQuery(query, parameters);

        }

        public void Update(int _categoryID, int _supplierID, int _productID, string _productName, string _productImage, string _unit, double _price, string _description)
        {
            string query = "UPDATE Products SET CategoryID = @CategoryID, SupplierID = @SupplierID, ProductName = @ProductName" +
                ", ProductImage = @ProductImage, Unit = @Unit, Price = @Price, Description = @Description" +
                " WHERE ProductID = @ProductID";

            SqlParameter[] parameters = new SqlParameter[8];

            parameters[0] = new SqlParameter("@CategoryID", SqlDbType.Int);
            parameters[0].Value = _categoryID;
            parameters[1] = new SqlParameter("@SupplierID", SqlDbType.Int);
            parameters[1].Value = _supplierID;
            parameters[2] = new SqlParameter("@ProductName", SqlDbType.NVarChar);
            parameters[2].Value = _productName;
            parameters[3] = new SqlParameter("@ProductImage", SqlDbType.NVarChar);
            parameters[3].Value = _productImage;
            parameters[4] = new SqlParameter("@Unit", SqlDbType.NVarChar);
            parameters[4].Value = _unit;
            parameters[5] = new SqlParameter("@Price", SqlDbType.Money);
            parameters[5].Value = _price;
            parameters[6] = new SqlParameter("@Description", SqlDbType.NVarChar);
            parameters[6].Value = _description;
            parameters[7] = new SqlParameter("@ProductID", SqlDbType.Int);
            parameters[7].Value = _productID;

            dbConnection.ExecuteUpdateQuery(query, parameters);
        }

        public void DeleteByProductID(int _productID)
        {
            string query = "DELETE FROM Products WHERE ProductID = @ProductID";

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@ProductID", SqlDbType.Int);
            parameters[0].Value = _productID;

            dbConnection.ExecuteDeleteQuery(query, parameters);
        }
    }
}
