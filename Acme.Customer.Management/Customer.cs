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
        public Address WorkAddress { get; set; }
        public Address HomeAddress { get; set; }
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
