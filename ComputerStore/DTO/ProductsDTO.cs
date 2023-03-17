using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductsDTO
    {
        private int categoryID;
        private int supplierID;
        private int productID;
        private string productName;
        private string productImage;
        private string unit;
        private int price;
        private string description;

        public ProductsDTO()
        {

        }

        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        public int SupplierID
        {
            get { return supplierID; }
            set { supplierID = value; }
        }
        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public string ProductImage
        {
            get { return productImage; }
            set { productImage = value; }
        }

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
