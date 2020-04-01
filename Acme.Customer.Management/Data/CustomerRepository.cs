using System.Collections.Generic;
using System.Linq;

namespace Acme.Customer.Management.Data
{
    public class CustomerRepository // Good examples of collaborative relationship
    {
        private AddressRepository _addressRepository;

        public CustomerRepository()
        {
            _addressRepository = new AddressRepository();
        }

        public Customer Get(int customerId) // This uses the customer id to get a customer from data store.
        {
            if(customerId == 1) {
                return MockCustomer;
            }
            return new Customer();
        }

        private Customer MockCustomer => new Customer(1)
        {
            FirstName = "Hari",
            LastName = "Nike",
            EmailAddress = "something@hotmail.com", 
            AddressList = _addressRepository.GetByCustomerId(1).ToList() 
            // The above establishes a collaboration relationship between the customer repo and address repo class
        };

        public bool Save(Customer customer) // Takes a customer object to save to data store.
        {
            return true;
        }
    }
}