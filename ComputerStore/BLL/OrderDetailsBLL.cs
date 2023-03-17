using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderDetailsBLL
    {
        private static OrderDetailsBLL instance;

        public OrderDetailsBLL()
        {

        }

        public static OrderDetailsBLL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new OrderDetailsBLL();
                }
                return instance;
            }
        }

        public DataTable GetByOrderID(int _orderID)
        {
            return OrderDetailsDAL.Instance.SelectByOrderID(_orderID);
        }
        

        public DataTable GetOrdersSearchString(string _searchString)
        {
            return OrderDetailsDAL.Instance.SelectBySearchString(_searchString);
        }

        public void Insert(int _orderID, int _productID, int _quantity, double _price, double _amount)
        {
            OrderDetailsDAL.Instance.Insert(_orderID, _productID, _quantity, _price, _amount);
        }

        public void Update(int _productID, int _quantity, double _price, double _amount)
        {
            OrderDetailsDAL.Instance.Update(_productID, _quantity, _price, _amount);
        }

        public void DeleteByProductID(int _productID)
        {
            OrderDetailsDAL.Instance.DeleteByProductID(_productID);
        }
    }
}
