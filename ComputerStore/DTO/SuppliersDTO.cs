using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SuppliersDTO
    {
        private int supplierID;
        private string companyName;
        private string contactName;
        private string address;
        private string phone;
        private string email;

        public int SupplierID
        {
            get { return supplierID; }
            set { supplierID = value; }
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public string ContactName
        {
            get { return contactName; }
            set { contactName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
