using System.Collections.Generic;

namespace Acme.Customer.Management.Data
{
    public class CustomerRepository
    {
        public Customer Get(int customerId)
        {
            if(customerId == 1) {
                return MockCustomer;
            }
            return new Customer();
        }

        public bool Save()
        {
            return true;
        }

        private Customer MockCustomer = new Customer(1) {
            FirstName = "Hari",
            LastName = "Nike",
            EmailAddress = "something@hotmail.com"
        };
    }
}