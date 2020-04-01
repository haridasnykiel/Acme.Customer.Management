using System.Collections.Generic;
using System.Linq;
using Acme.Customer.Management.Data;
using NUnit.Framework;

namespace Acme.Customer.Management.Tests
{
    public class AddressRepositoryTests
    {
        [Test]
        public void Get_ValidAddress() 
        {

            var addressRepo = new AddressRepository();
            var expectedAddress = new Address(1)
            {
                AddressType = 2,
                StreetLineOne = "place1",
                Postcode = "LS11",
                City = "Leeds",
                Country = "UK"
            };

            var actualAddress = addressRepo.Get(1);

            Assert.AreEqual(expectedAddress.AddressId, actualAddress.AddressId);
            Assert.AreEqual(expectedAddress.AddressType, actualAddress.AddressType);
            Assert.AreEqual(expectedAddress.StreetLineOne, actualAddress.StreetLineOne);
            Assert.AreEqual(expectedAddress.City, actualAddress.City);
            Assert.AreEqual(expectedAddress.Country, actualAddress.Country);
        }

        [Test]
        public void Get_InvalidAddress() 
        {
            var addressRepo = new AddressRepository();

            var actualAddress = addressRepo.Get(0);

            Assert.True(actualAddress.AddressId == 0);
            Assert.True(actualAddress.AddressType == 0);
            Assert.True(string.IsNullOrEmpty(actualAddress.StreetLineOne));
            Assert.True(string.IsNullOrEmpty(actualAddress.City));
            Assert.True(string.IsNullOrEmpty(actualAddress.Country));
        }

        [Test]
        public void GetByCustomerId_ValidCustomer() 
        {
            var addressRepo = new AddressRepository();
            var expectedAddresses = GetTestAddresses();

            var actualAddresses = addressRepo.GetByCustomerId(1).ToList();

            Assert.AreEqual(expectedAddresses[0].AddressId, actualAddresses[0].AddressId);
            Assert.AreEqual(expectedAddresses[1].AddressId, actualAddresses[1].AddressId);
        }

        [Test]
        public void GetByCustomerId_InvalidCustomer()
        {
            var addressRepo = new AddressRepository();
            var expectedAddresses = GetTestAddresses();

            var actualAddresses = addressRepo.GetByCustomerId(0).ToList();

            Assert.True(actualAddresses != null);
            Assert.IsEmpty(actualAddresses);
        }

        private List<Address> GetTestAddresses()
        {

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