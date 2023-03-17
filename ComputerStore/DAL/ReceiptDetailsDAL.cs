using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReceiptDetailsDAL
    {
        private static ReceiptDetailsDAL instance;
        private DBConnection dbConnection;

        public ReceiptDetailsDAL()
        {
            dbConnection = new DBConnection();
        }

        public static ReceiptDetailsDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReceiptDetailsDAL();
                }
                return instance;
            }
        }

        public DataTable SelectByReceiptID(int _receiptID)
        {
            string query = "SELECT * FROM ReceiptDetails WHERE ReceiptID = @ReceiptID";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@ReceiptID", SqlDbType.Int);
            parameters[0].Value = _receiptID;

            return dbConnection.ExecuteSelectQuery(query, parameters);
        }

        public void Insert(int _receiptID, int _productID, int _quantity, double _price, double _amount)
        {
            string query = "INSERT INTO ReceiptDetails VALUES (@ReceiptID, @ProductID, @Quantity, @Price, @Amount)";

            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@ReceiptID", SqlDbType.Int);
            parameters[0].Value = _receiptID;
            parameters[1] = new SqlParameter("@ProductID", SqlDbType.Int);
            parameters[1].Value = _productID;
            parameters[2] = new SqlParameter("Quantity", SqlDbType.Int);
            parameters[2].Value = _quantity;
            parameters[3] = new SqlParameter("@Price", SqlDbType.Money);
            parameters[3].Value = _price;
            parameters[4] = new SqlParameter("@Amount", SqlDbType.Money);
            parameters[4].Value = _amount;

            dbConnection.ExecuteInsertQuery(query, parameters);

        }

        public void Update(int _productID, int _quantity, double _price, double _amount)
        {
            string query = "UPDATE ReceiptDetails SET Quantity = @Quantity, Price = @Price, Amount = @Amount" +
                " WHERE ProductID = @ProductID";

            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@Quantity", SqlDbType.Int);
            parameters[0].Value = _quantity;
            parameters[1] = new SqlParameter("@Price", SqlDbType.Money);
            parameters[1].Value = _price;
            parameters[2] = new SqlParameter("Amount", SqlDbType.Money);
            parameters[2].Value = _amount;
            parameters[3] = new SqlParameter("@ProductID", SqlDbType.Int);
            parameters[3].Value = _productID;

            dbConnection.ExecuteUpdateQuery(query, parameters);

        }

        public void Delete(int _productID)
        {
            string query = "DELETE FROM ReceiptDetails WHERE ProductID = @ProductID";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@ProductID", SqlDbType.Int);
            parameters[0].Value = _productID;

            dbConnection.ExecuteDeleteQuery(query, parameters);
        }
    }
}
