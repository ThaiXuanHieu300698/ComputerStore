using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ReceiptDetailsDTO
    {
        private int receiptID;
        private int productID;
        private int quantity;
        private double price;
        private double amount;

        public int ReceiptID { get => receiptID; set => receiptID = value; }
        public int ProductID { get => productID; set => productID = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Price { get => price; set => price = value; }
        public double Amount { get => amount; set => amount = value; }
    }
}
