using System;
using NUnit.Framework;

namespace Acme.Customer.Management.Tests {
    public class OrderTests {
        
        [Test]
        public void Validate_OrderDateIsSet () {
            var order = new Order {
                OrderDate = DateTime.Today.AddDays (1)
            };

            var isValid = order.Validate ();

            Assert.True (isValid);
        }

        [Test]
        public void Validate_OrderDateNotSet () {
            var order = new Order();

            var isValid = order.Validate ();

            Assert.False (isValid);
        }
    }
}