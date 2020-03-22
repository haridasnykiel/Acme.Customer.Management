using Acme.Customer.Management.Data;
using NUnit.Framework;

namespace Acme.Customer.Management.Tests
{
    public class CustomerRepositoryTests
    {
        [Test]
        public void Get_ValidCustomer() 
        {
            var customerRepo = new CustomerRepository();
            Customer expectedCustomer = new Customer(1)
            {
                FirstName = "Hari",
                LastName = "Nike",
                EmailAddress = "something@hotmail.com"
            };

            var actualCustomer = customerRepo.Get(1);

            Assert.AreEqual(expectedCustomer.CustomerId, actualCustomer.CustomerId);
            Assert.AreEqual(expectedCustomer.Name, actualCustomer.Name);
            Assert.AreEqual(expectedCustomer.EmailAddress, actualCustomer.EmailAddress);
        }
    }
}