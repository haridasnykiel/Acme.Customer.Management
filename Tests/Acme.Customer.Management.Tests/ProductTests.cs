using NUnit.Framework;

namespace Acme.Customer.Management.Tests
{
    public class ProductTests
    {
        [Test]
        public void Validate_PrductNameAndPriceIsSet() {
            
            var product = new Product {
                ProductName = "Hat", 
                Price = 45M
            };

            var isValid = product.Validate();

            Assert.True(isValid);
        }

        [Test]
        public void Validate_PrductNameNotSet()
        {

            var product = new Product
            {
                Price = 45M
            };

            var isValid = product.Validate();

            Assert.False(isValid);
        }

        [Test]
        public void Validate_PriceIsZero()
        {

            var product = new Product
            {
                ProductName = "Hat",
                Price = 0
            };

            var isValid = product.Validate();

            Assert.False(isValid);
        }

        [Test]
        public void Validate_PriceIsLessThanZero()
        {

            var product = new Product
            {
                ProductName = "Hat",
                Price = -1
            };

            var isValid = product.Validate();

            Assert.False(isValid);
        }
    }
}