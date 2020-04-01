using System.Collections.Generic;

namespace Acme.Customer.Management.Data
{
    public class AddressRepository
    {
        public Address Get(int addressId) 
        {
            if(addressId == 1) {
                return MockAddressOne();
            }

            return new Address();
        } 
        

        public IEnumerable<Address> GetAddressesByCustomerId(int customerId) 
        {
            var addresses = new List<Address>();
            
            if(customerId == 1) {
                var homeAddress = MockAddressOne();
                var workAddress = MockAddressTwo();

                addresses.Add(homeAddress);
                addresses.Add(workAddress);
            }

            return addresses;
        }

        private Address MockAddressOne() 
        {
            return new Address(1) {
                AddressType = 2,
                StreetLineOne = "place1",
                Postcode = "LS11",
                City = "Leeds",
                Country = "UK"
            };            
        }

        private Address MockAddressTwo()
        {
            return new Address(2)
            {
                AddressType = 3,
                StreetLineOne = "place2",
                Postcode = "LS11",
                City = "Leeds",
                Country = "UK"
            };
        }

        public bool Save(Address address) 
        {
            return true;
        }
    }
}