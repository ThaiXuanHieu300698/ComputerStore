using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class WarehouseDTO
    {
        private int productID;
        private int stock;

        public int ProductID { get => productID; set => productID = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
