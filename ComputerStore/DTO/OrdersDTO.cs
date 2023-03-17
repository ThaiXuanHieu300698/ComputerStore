using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrdersDTO
    {
        private int customerID;
        private int orderID;
        private DateTime orderDate;
        private double totalAmount;

        public int CustomerID { get => customerID; set => customerID = value; }
        public int OrderID { get => orderID; set => orderID = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public double TotalAmount { get => totalAmount; set => totalAmount = value; }
    }
}
