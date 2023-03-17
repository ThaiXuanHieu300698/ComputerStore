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
    public class OrdersBLL
    {
        private static OrdersBLL instance;

        public OrdersBLL()
        {

        }

        public static OrdersBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrdersBLL();
                }
                return instance;
            }
        }

        public DataTable GetAll()
        {
            return OrdersDAL.Instance.Select();
        }

        public OrdersDTO GetFirstOrders()
        {
            DataTable dataTable = OrdersDAL.Instance.SelectFirstOrders();
            OrdersDTO orders = new OrdersDTO();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                orders.OrderID = Convert.ToInt32(dataRow["OrderID"].ToString());
            }
            return orders;
        }

        public DataTable GetOrdersSearchString(string _searchString)
        {
            return OrderDetailsDAL.Instance.SelectBySearchString(_searchString);
        }

        public OrdersDTO GetByOrderID(int _orderID)
        {
            DataTable dataTable = OrdersDAL.Instance.SelectByOrderID(_orderID);
            OrdersDTO orders = new OrdersDTO();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                orders.CustomerID = Convert.ToInt32(dataRow["CustomerID"].ToString());
                orders.OrderID = Convert.ToInt32(dataRow["OrderID"].ToString());
                orders.OrderDate = (DateTime)(dataRow["OrderDate"]);
                orders.TotalAmount = Convert.ToDouble(dataRow["TotalAmount"].ToString());

            }
            return orders;
        }

        public void Insert(int? _customerID, DateTime _orderDate, double _totalAmount)
        {
            OrdersDAL.Instance.Insert(_customerID, _orderDate, _totalAmount);
        }

        public void Update(int _customerID, int _orderID, DateTime _orderDate, double _totalAmount)
        {
            OrdersDAL.Instance.Update(_customerID, _orderID, _orderDate, _totalAmount);
        }

        public void DeleteByOrderID(int _orderID)
        {
            OrdersDAL.Instance.DeleteByOrderID(_orderID);
        }

        public DataTable Statistical()
        {
            return OrdersDAL.Instance.Statistical();
        }
    }
}
