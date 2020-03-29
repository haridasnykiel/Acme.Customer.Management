using System;
using System.Collections.Generic;

namespace Acme.Customer.Management
{
    public class Customer
    {

        public Customer() : this(0) // This will use the other constructor everytime. This is called constructor chaining.  
        {
        }

        public Customer(int customerId) 
        {
            InstanceCount++;
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public List<Address> AddressList { get; set; } // Composite relationship 
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

            if (string.IsNullOrEmpty(name) && 
            (!string.IsNullOrEmpty(LastName) && !string.IsNullOrEmpty(FirstName)))
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
    }
}
