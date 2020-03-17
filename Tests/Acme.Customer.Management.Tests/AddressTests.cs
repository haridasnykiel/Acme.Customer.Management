using NUnit.Framework;

namespace Acme.Customer.Management.Tests
{
    public class AddressTests
    {
        [Test]
        public void Validate_AllRequiedFieldsAreSet() {
            var address = new Address {
                StreetLineOne = "fsfwfe",
                Postcode = "LS11",
                City = "Leeds",
                Country = "UK"
            };

            var isValid = address.Validate();

            Assert.True(isValid);
        }


        [Test]
        public void Validate_CountryIsNull()
        {
            var address = new Address
            {
                StreetLineOne = "fsfwfe",
                Postcode = "LS11",
                City = "Leeds"
            };

            var isValid = address.Validate();

            Assert.False(isValid);
        }

        [Test]
        public void Validate_CityIsNull()
        {
            var address = new Address
            {
                StreetLineOne = "fsfwfe",
                Postcode = "LS11",
                Country = "UK"
            };

            var isValid = address.Validate();

            Assert.False(isValid);
        }

        [Test]
        public void Validate_PostcodeIsNull()
        {
            var address = new Address
            {
                StreetLineOne = "fsfwfe",
                City = "Leeds",
                Country = "UK"
            };

            var isValid = address.Validate();

            Assert.False(isValid);
        }

        [Test]
        public void Validate_StreetLineOneIsNull()
        {
            var address = new Address
            {
                Postcode = "LS11",
                City = "Leeds",
                Country = "UK"
            };

            var isValid = address.Validate();

            Assert.False(isValid);
        }
    }
}