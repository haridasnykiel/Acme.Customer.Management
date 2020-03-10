using NUnit.Framework;

namespace Acme.Customer.Management.Tests
{
    public class OrderItemTests
    {
        [Test]
        public void Validate_OrderItemHasValidDetails() {
            var orderItem  = new OrderItem {
                ProductId = 1,
                Quantity = 1,
                PurchasePrice = 2M
            };

            var isValid = orderItem.Validate();

            Assert.True(isValid);
        }


        [Test]
        public void Validate_ProductIdIsZero()
        {
            var orderItem = new OrderItem
            {
                Quantity = 1,
                PurchasePrice = 2M
            };

            var isValid = orderItem.Validate();

            Assert.False(isValid);
        }

        [Test]
        public void Validate_QuantityIsZero()
        {
            var orderItem = new OrderItem
            {
                ProductId = 1,
                PurchasePrice = 2M
            };

            var isValid = orderItem.Validate();

            Assert.False(isValid);
        }

        [Test]
        public void Validate_PurchasePriceIsNull()
        {
            var orderItem = new OrderItem
            {
                ProductId = 1,
                Quantity = 1
            };

            var isValid = orderItem.Validate();

            Assert.False(isValid);
        }
    }
}