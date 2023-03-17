using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderDetailsDAL
    {
        private static OrderDetailsDAL instance;
        private DBConnection dbConnection;

        public OrderDetailsDAL()
        {
            dbConnection = new DBConnection();
        }

        public static OrderDetailsDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDetailsDAL();
                }
                return instance;
            }
        }

        public DataTable SelectByOrderID(int _orderID)
        {
            string query = "SELECT * FROM OrderDetails WHERE OrderID = @OrderID";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@OrderID", SqlDbType.Int);
            parameters[0].Value = _orderID;
            return dbConnection.ExecuteSelectQuery(query, parameters);
        }

        public DataTable SelectBySearchString(string _searchString)
        {
            string query = "SELECT * FROM OrderDetails WHERE CustomerName LIKE N'%" + _searchString + "%'";
            return dbConnection.ExecuteSelectQuery(query);
        }

        public void Insert(int _orderID, int _productID, int _quantity, double _price, double _amount)
        {
            string query = "INSERT INTO OrderDetails VALUES (@OrderID, @ProductID, @Quantity, @Price, @Amount)";

            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@OrderID", SqlDbType.Int);
            parameters[0].Value = _orderID;
            parameters[1] = new SqlParameter("@ProductID", SqlDbType.Int);
            parameters[1].Value = _productID;
            parameters[2] = new SqlParameter("@Quantity", SqlDbType.Int);
            parameters[2].Value = _quantity;
            parameters[3] = new SqlParameter("@Price", SqlDbType.Money);
            parameters[3].Value = _price;
            parameters[4] = new SqlParameter("@Amount", SqlDbType.Money);
            parameters[4].Value = _amount;
            dbConnection.ExecuteInsertQuery(query, parameters);

        }

        public void Update(int _productID, int _quantity, double _price, double _amount)
        {
            string query = "UPDATE OrderDetails SET Quantity = @Quantity, Price = @Price, Amount = @Amount" +
                " WHERE ProductID = @ProductID";

            SqlParameter[] parameters = new SqlParameter[4];

            parameters[0] = new SqlParameter("@ProductID", SqlDbType.Int);
            parameters[0].Value = _productID;
            parameters[1] = new SqlParameter("@Quantity", SqlDbType.Int);
            parameters[1].Value = _quantity;
            parameters[2] = new SqlParameter("@Price", SqlDbType.Money);
            parameters[2].Value = _price;
            parameters[3] = new SqlParameter("@Amount", SqlDbType.Money);
            parameters[3].Value = _amount;

            dbConnection.ExecuteUpdateQuery(query, parameters);
        }

        public void DeleteByProductID(int _productID)
        {
            string query = "DELETE FROM OrderDetails WHERE ProductID = @ProductID";

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@ProductID", SqlDbType.Int);
            parameters[0].Value = _productID;

            dbConnection.ExecuteDeleteQuery(query, parameters);

        }
        
    }
}
