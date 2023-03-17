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
    public class WarehouseBLL
    {
        private static WarehouseBLL instance;

        public WarehouseBLL()
        {

        }

        public static WarehouseBLL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new WarehouseBLL();
                }
                return instance;
            }
        }

        public DataTable GetAll()
        {
            return WarehouseDAL.Instance.SelectAll();
        }

        public WarehouseDTO GetByProductID(int _productID)
        {
            WarehouseDTO warehouse = new WarehouseDTO();
            DataTable dtWarehouse = WarehouseDAL.Instance.SelectByProductID(_productID);

            foreach(DataRow row in dtWarehouse.Rows)
            {
                warehouse.ProductID = Convert.ToInt32(row["ProductID"].ToString());
                warehouse.Stock = Convert.ToInt32(row["Stock"].ToString());
            }
            return warehouse;

        }

        public DataTable GetBySupplierID(int _supplierID)
        {
            return WarehouseDAL.Instance.SelectBySupplierID(_supplierID);
        }

        public DataTable GetProductBySearchString(string _searchString)
        {
            return WarehouseDAL.Instance.SelectProductBySearchString(_searchString);
        }

        public void Insert(int _productID, int _stock)
        {
            WarehouseDAL.Instance.Insert(_productID, _stock);
        }

        public void Update(int _productID, int _stock)
        {
            WarehouseDAL.Instance.Update(_productID, _stock);
        }

        public void Delete(int _productID)
        {
            WarehouseDAL.Instance.Delete(_productID);
        }
    }
}
