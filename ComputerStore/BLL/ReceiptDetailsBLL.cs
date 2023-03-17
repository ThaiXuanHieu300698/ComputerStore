using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ReceiptDetailsBLL
    {
        private static ReceiptDetailsBLL instance;
        private DBConnection dbConnection;

        public ReceiptDetailsBLL()
        {
            dbConnection = new DBConnection();
        }

        public static ReceiptDetailsBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReceiptDetailsBLL();
                }
                return instance;
            }
        }

        public DataTable GetByReceiptID(int _receiptID)
        {
            return ReceiptDetailsDAL.Instance.SelectByReceiptID(_receiptID);
        }

        public void Insert(int _receiptID, int _productID, int _quantity, double _price, double _amount)
        {
            ReceiptDetailsDAL.Instance.Insert(_receiptID, _productID, _quantity, _price, _amount);
        }

        public void Update(int _productID, int _quantity, double _price, double _amount)
        {
            ReceiptDetailsDAL.Instance.Update(_productID, _quantity, _price, _amount);
        }

        public void Delete(int _productID)
        {
            ReceiptDetailsDAL.Instance.Delete(_productID);
        }
    }
}
