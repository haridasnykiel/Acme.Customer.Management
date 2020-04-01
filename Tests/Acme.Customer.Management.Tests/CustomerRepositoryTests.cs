using System.Collections.Generic;
using System.Linq;
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

        [Test]
        public void Get_CustomerHasAddressList() 
        {
            var customerRepo = new CustomerRepository();
            var addressRepo = new AddressRepository();
            
            Customer expectedCustomer = new Customer(1)
            {
                FirstName = "Hari",
                LastName = "Nike",
                EmailAddress = "something@hotmail.com",
                AddressList = GetTestAddresses()
            };

            var actualCustomer = customerRepo.Get(1);

            Assert.True(actualCustomer.AddressList != null);
            Assert.AreEqual(
                expectedCustomer.AddressList[0].AddressId, 
                actualCustomer.AddressList[0].AddressId);

            Assert.AreEqual(
                expectedCustomer.AddressList[1].AddressId,
                actualCustomer.AddressList[1].AddressId);
        }

        private List<Address> GetTestAddresses() {

            var addressOne = new Address(1)
            {
                AddressType = 1,
                StreetLineOne = "place1",
                Postcode = "LS11",
                City = "Leeds",
                Country = "UK"
            };

            var addressTwo = new Address(2)
            {
                AddressType = 3,
                StreetLineOne = "place2",
                Postcode = "LS11",
                City = "Leeds",
                Country = "UK"
            };

            var addresses = new List<Address>();
            addresses.Add(addressOne);
            addresses.Add(addressTwo);

            return addresses;
        }
    }
}