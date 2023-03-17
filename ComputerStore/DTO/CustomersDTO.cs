using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomersDTO
    {
        private int customerID;
        private string firstName;
        private string lastName;
        private string address;
        private string phone;
        private string email;

        public int CustomerID { get => customerID; set => customerID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        
    }
}
