using System.Collections.Generic;

namespace Acme.Customer.Management.Data
{
    public class CustomerRepository // Good examples of collaborative relationship
    {
        public Customer Get(int customerId) // This uses the customer id to get a customer from data store.
        {
            if(customerId == 1) {
                return MockCustomer;
            }
            return new Customer();
        }

        private Customer MockCustomer = new Customer(1)
        {
            FirstName = "Hari",
            LastName = "Nike",
            EmailAddress = "something@hotmail.com"
        };

        public bool Save(Customer customer) // Takes a customer object to save to data store.
        {
            return true;
        }
    }
}