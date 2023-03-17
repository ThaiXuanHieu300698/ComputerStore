using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class ProductsBLL
    {
        private static ProductsBLL instance;

        public static ProductsBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductsBLL();
                }
                return instance;
            }
        }

        public ProductsBLL()
        {

        }

        public DataTable GetAll()
        {
            return ProductsDAL.Instance.Select();
        }

        public DataTable GetColumn()
        {
            return ProductsDAL.Instance.SelectColumn();
        }

        public DataTable GetColumnProductBySearchString(string _searchString)
        {
            return ProductsDAL.Instance.SelectColumn(_searchString);
        }

        public List<ProductsDTO> GetProducts()
        {
            DataTable dataTable = ProductsDAL.Instance.Select();
            List<ProductsDTO> products = new List<ProductsDTO>();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                ProductsDTO product = new ProductsDTO();

                product.ProductID = Convert.ToInt32(dataRow["ProductID"].ToString());
                

                products.Add(product);
            }

            return products;
        }

        public ProductsDTO GetByProductID(int _productID)
        {
            DataTable dataTable = ProductsDAL.Instance.SelectByProductID(_productID);
            ProductsDTO product = new ProductsDTO();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                product.ProductID = Convert.ToInt32(dataRow["ProductID"].ToString());
            }

            return product;
        }

        

        public DataTable GetProductBySearchString(string _searchString)
        {
            return ProductsDAL.Instance.SelectBySearchString(_searchString);
        }

        public void Insert(int _categoryID, int _supplierID, string _productName, string _productImage, string _unit, double _price, string _description)
        {
            ProductsDAL.Instance.Insert(_categoryID, _supplierID, _productName, _productImage, _unit, _price, _description);
        }

        public void Update(int _categoryID, int _supplierID, int _productID, string _productName, string _productImage, string _unit, double _price, string _description)
        {
            ProductsDAL.Instance.Update(_categoryID, _supplierID, _productID, _productName, _productImage, _unit, _price, _description);
        }

        public void DeleteByProductID(int _productID)
        {
            ProductsDAL.Instance.DeleteByProductID(_productID);
        }
    }
}
