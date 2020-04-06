using Acme.Customer.Management.Base;

namespace Acme.Customer.Management
{
    public class Address : EntityBase
    {

        public Address()
        {
            
        }

        public Address(int addressId) 
        {
            AddressId = addressId;
        }

        public int AddressId { get; set; }
        public int AddressType { get; set; }
        public string StreetLineOne { get; set; }
        public string StreetLineTwo { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }

        public override bool Validate() {
            return 
            !string.IsNullOrEmpty(StreetLineOne) && 
            !string.IsNullOrEmpty(City) && 
            !string.IsNullOrEmpty(Postcode) &&
            !string.IsNullOrEmpty(Country);
        }
    }
}