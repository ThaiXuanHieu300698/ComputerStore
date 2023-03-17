using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDetailsDTO
    {
        private int orderID;
        private int productID;
        private int quantity;
        private double price;
        private double amount;

        public int OrderID { get => orderID; set => orderID = value; }
        public int ProductID { get => productID; set => productID = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Price { get => price; set => price = value; }
        public double Amount { get => amount; set => amount = value; }
    }
}
