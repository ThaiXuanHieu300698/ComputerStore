using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ReceiptsBLL
    {
        private static ReceiptsBLL instance;

        public ReceiptsBLL()
        {

        }

        public static ReceiptsBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReceiptsBLL();
                }
                return instance;
            }
        }

        public DataTable GetAll()
        {
            return ReceiptsDAL.Instance.SelectAll();
        }

        public ReceiptsDTO GetFirstReceipts()
        {
            DataTable dataTable = ReceiptsDAL.Instance.SelectFirstReceipts();
            ReceiptsDTO receipts = new ReceiptsDTO();

            foreach(DataRow dataRow in dataTable.Rows)
            {
                receipts.ReceiptID = Convert.ToInt32(dataRow["ReceiptID"].ToString());
                receipts.SupplierID = Convert.ToInt32(dataRow["SupplierID"].ToString());
                receipts.ReceiptDate = (DateTime)(dataRow["ReceiptDate"]);
                receipts.TotalAmount = Convert.ToDouble(dataRow["TotalAmount"].ToString());
            }
            return receipts;
        }

        public void Insert(int _supplierID, DateTime _receiptDate, double _totalAmount)
        {
            ReceiptsDAL.Instance.Insert(_supplierID, _receiptDate, _totalAmount);
        }

        public void Update(int _receiptID, DateTime _receiptDate, double _totalAmount)
        {
            ReceiptsDAL.Instance.Update(_receiptID, _receiptDate, _totalAmount);
        }

        public void Delete(int _receiptID)
        {
            ReceiptsDAL.Instance.Delete(_receiptID);
        }

        public DataTable Statistical()
        {
            return ReceiptsDAL.Instance.Statistical();
        }
    }
}
