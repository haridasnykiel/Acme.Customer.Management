using System;
using System.Collections.Generic;

namespace Acme.Customer.Management
{
    public class Customer
    {

        public Customer()
        {
            InstanceCount++;
        }

        public Customer(int customerId) 
        {
            InstanceCount++;
            CustomerId = customerId;
        }

        public int CustomerId { get; private set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string Name => GetFullName();

        public static int InstanceCount { get; set; }

        private string GetFullName() {

            string name = "";

            if (string.IsNullOrEmpty(LastName))
            {
                name = $"{FirstName}";
            }

            if (string.IsNullOrEmpty(FirstName))
            {
                name = $"{LastName}";
            }

            if (string.IsNullOrEmpty(name))
            {
                name = $"{LastName}, {FirstName}";
            }

            return name;
        }

        public bool Validate() {

            var isValid = true;
            
            if ( string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(EmailAddress) ) {
                isValid = false;
            }

            return isValid;
        }

        public Customer Get(int customerId) {
            return new Customer();
        }

        public List<Customer> Get() {
            return new List<Customer>();
        }

        public bool Save() {
            return true;
        }
    }
}
