using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReceiptsDAL
    {
        private static ReceiptsDAL instance;
        private DBConnection dbConnection;

        public ReceiptsDAL()
        {
            dbConnection = new DBConnection();
        }

        public static ReceiptsDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReceiptsDAL();
                }
                return instance;
            }
        }

        public DataTable SelectAll()
        {
            string query = "SELECT * FROM Receipts";
            return dbConnection.ExecuteSelectQuery(query);
        }

        public DataTable SelectFirstReceipts()
        {
            string query = "SELECT TOP 1 * FROM Receipts ORDER BY ReceiptID DESC";
            return dbConnection.ExecuteSelectQuery(query);
        }

        public void Insert(int _supplierID, DateTime _receiptDate, double _totalAmount)
        {
            string query = "INSERT INTO Receipts VALUES(@SupplierID, @ReceiptDate, @TotalAmount)";
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@SupplierID", SqlDbType.Int);
            parameters[0].Value = _supplierID;
            parameters[1] = new SqlParameter("@ReceiptDate", SqlDbType.DateTime);
            parameters[1].Value = _receiptDate;
            parameters[2] = new SqlParameter("@TotalAmount", SqlDbType.Money);
            parameters[2].Value = _totalAmount;

            dbConnection.ExecuteInsertQuery(query, parameters);
        }

        public void Update(int _receiptID, DateTime _receiptDate, double _totalAmount)
        {
            string query = "UPDATE Receipts SET ReceiptDate = @ReceiptDate, TotalAmount = @TotalAmount" +
                " WHERE ReceiptID = @ReceiptID";

            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@ReceiptDate", SqlDbType.DateTime);
            parameters[0].Value = _receiptDate;
            parameters[1] = new SqlParameter("TotalAmount", SqlDbType.Money);
            parameters[1].Value = _totalAmount;
            parameters[2] = new SqlParameter("ReceiptID", SqlDbType.Int);
            parameters[2].Value = _receiptID;

            dbConnection.ExecuteUpdateQuery(query, parameters);
        }

        public void Delete(int _receiptID)
        {
            string query = "DELETE FROM Receipts WHERE ReceiptID = @ReceiptID";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@ReceiptID", SqlDbType.Int);
            parameters[0].Value = _receiptID;

            dbConnection.ExecuteDeleteQuery(query, parameters);
        }

        // Thống kê
        public DataTable Statistical()
        {
            string query = "SELECT MONTH(ReceiptDate) AS 'Month', SUM(TotalAmount) AS 'Tổng tiền' FROM Receipts GROUP BY MONTH(ReceiptDate)";
            return dbConnection.ExecuteSelectQuery(query);
        }
    }
}
