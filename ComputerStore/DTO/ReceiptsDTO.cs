using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ReceiptsDTO
    {
        private int receiptID;
        private int supplierID;
        private DateTime receiptDate;
        private double totalAmount;

        public int ReceiptID { get => receiptID; set => receiptID = value; }
        public int SupplierID { get => supplierID; set => supplierID = value; }
        public DateTime ReceiptDate { get => receiptDate; set => receiptDate = value; }
        public double TotalAmount { get => totalAmount; set => totalAmount = value; }
    }
}
