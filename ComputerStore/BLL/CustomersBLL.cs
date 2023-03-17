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
    public class CustomersBLL
    {
        private static CustomersBLL instance;

        public CustomersBLL()
        {

        }

        public static CustomersBLL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new CustomersBLL();
                }
                return instance;
            }

        }

        public DataTable GetAll()
        {
            return CustomersDAL.Instance.Select();
        }

        public CustomersDTO GetFirstCustomer()
        {
            DataTable dataTable = CustomersDAL.Instance.SelectFirstCustomer();
            CustomersDTO customer = new CustomersDTO();
            foreach(DataRow dataRow in dataTable.Rows)
            {
                customer.CustomerID = Convert.ToInt32(dataRow["CustomerID"].ToString());
            }
            return customer;
        }

        public CustomersDTO GetByCustomerID(int _customerID)
        {
            DataTable dataTable = CustomersDAL.Instance.SelectByCustomerID(_customerID);
            CustomersDTO customer = new CustomersDTO();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                customer.CustomerID = Convert.ToInt32(dataRow["CustomerID"].ToString());
                customer.FirstName = dataRow["FirstName"].ToString();
                customer.LastName = dataRow["LastName"].ToString();
                customer.Address = dataRow["Address"].ToString();
                customer.Phone = dataRow["Phone"].ToString();
                customer.Email = dataRow["Email"].ToString();
            }
            return customer;
        }

        public DataTable GetCustomerByPhone(string _searchString)
        {
            return CustomersDAL.Instance.SelectByPhone(_searchString);
        }

        public void Insert(string _firstName, string _lastName, string _address, string _phone, string _email)
        {
            CustomersDAL.Instance.Insert(_firstName, _lastName, _address, _phone, _email);
        }

        public void Update(int _customerID, string _firstName, string _lastName, string _address, string _phone, string _email)
        {
            CustomersDAL.Instance.Update(_customerID, _firstName, _lastName, _address, _phone, _email);
        }

        public void DeleteByCustomerID(int _customerID)
        {
            CustomersDAL.Instance.DeleteByCustomerID(_customerID);
        }
    }
}
