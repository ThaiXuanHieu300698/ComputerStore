using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrdersDAL
    {
        private static OrdersDAL instance;
        private DBConnection dbConnection;

        public OrdersDAL()
        {
            dbConnection = new DBConnection();
        }

        public static OrdersDAL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new OrdersDAL();
                }
                return instance;
            }
        }

        public DataTable Select()
        {
            string query = "SELECT * FROM Orders";
            return dbConnection.ExecuteSelectQuery(query);
        }

        public DataTable Select(string _searchString)
        {
            string query = "SELECT * FROM Orders WHERE CustomerName LIKE N'%" + _searchString + "%'";
            return dbConnection.ExecuteSelectQuery(query);
        }

        public DataTable SelectFirstOrders()
        {
            string query = "SELECT TOP 1 OrderID FROM Orders ORDER BY OrderID DESC";
            return dbConnection.ExecuteSelectQuery(query);
        }

        public DataTable SelectByOrderID(int _orderID)
        {
            string query = "SELECT * FROM Orders WHERE OrderID = @OrderID";
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@OrderID", SqlDbType.Int);
            return dbConnection.ExecuteSelectQuery(query, parameters);
        }

        public void Insert(int? _customerID, DateTime _orderDate, double _totalAmount)
        {
            string query = "INSERT INTO Orders VALUES (@CustomerID, @OrderDate, @TotalAmount)";

            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@CustomerID", SqlDbType.Int);
            parameters[0].Value = _customerID;
            parameters[1] = new SqlParameter("@OrderDate", SqlDbType.DateTime);
            parameters[1].Value = DateTime.Now;
            parameters[2] = new SqlParameter("@TotalAmount", SqlDbType.Money);
            parameters[2].Value = _totalAmount;
            dbConnection.ExecuteInsertQuery(query, parameters);

        }

        public void Update(int _customerID, int _orderID, DateTime _orderDate, double _totalAmount)
        {
            string query = "UPDATE Orders SET CustomerID = @CustomerID, OrderDate = @OrderDate, TotalAmount = @TotalAmount" +
                " WHERE OrderID = @OrderID";

            SqlParameter[] parameters = new SqlParameter[4];

            parameters[0] = new SqlParameter("@CustomerID", SqlDbType.Int);
            parameters[0].Value = _customerID;
            parameters[1] = new SqlParameter("@OrderDate", SqlDbType.DateTime);
            parameters[1].Value = DateTime.Now;
            parameters[2] = new SqlParameter("@TotalAmount", SqlDbType.Money);
            parameters[2].Value = _totalAmount;
            parameters[3] = new SqlParameter("@OrderID", SqlDbType.Int);
            parameters[3].Value = _orderID;

            dbConnection.ExecuteUpdateQuery(query, parameters);
        }

        public void DeleteByOrderID(int _orderID)
        {
            string query = "DELETE FROM Orders WHERE OrderID = @OrderID";

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@OrderID", SqlDbType.Int);
            parameters[0].Value = _orderID;

            dbConnection.ExecuteDeleteQuery(query, parameters);

        }
        // Thông kê
        public DataTable Statistical()
        {
            string query = "SELECT MONTH(OrderDate) AS 'Month', SUM(TotalAmount) AS 'Tổng tiền' FROM Orders GROUP BY MONTH(OrderDate)";
            return dbConnection.ExecuteSelectQuery(query);
        }
    }
}
