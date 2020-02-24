using NUnit.Framework;

namespace Acme.Customer.Management.Tests
{
    public class CustomerTest
    {

        [Test]
        public void FullNameFormat()
        {
            //arrange
            var customer = new Customer
            {
                FirstName = "Hari",
                LastName = "Nike"
            };

            var expected = "Nike, Hari";

            //act
            var actual = customer.Name;

            //assertion
            Assert.AreEqual(expected, actual, "Full name format is not correct.");
        }

        [Test]
        public void LastNameWithoutValue() {

            var customer = new Customer
            {
                FirstName = "Hari"
            };

            var expected = "Hari";

            var actual = customer.Name;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FirstNameWithoutValue()
        {
            var customer = new Customer
            {
                LastName = "Nike"
            };

            var expected = "Nike";

            var actual = customer.Name;

            Assert.AreEqual(expected, actual);
        }

        [Test, Order(1)]
        public void IncrementInstanceCount() 
        {
            var c1 = new Customer();
            var c2 = new Customer();

            var expected = 2;

            var actual = Customer.InstanceCount;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Validate_EmailNotSet() {
            var customer = new Customer {
                LastName = "Nike"
            };

            var isValid = customer.Validate();

            Assert.False(isValid, "Validate function was true");
        }

        [Test]
        public void Validate_LastNameNotSet()
        {
            var customer = new Customer
            {
                EmailAddress = "hari@gmail.com"
            };

            var isValid = customer.Validate();

            Assert.False(isValid, "Validate function was true");
        }

        [Test]
        public void Validate_EmailAndLastNameAreSet()
        {
            var customer = new Customer
            {
                EmailAddress = "hari@gmail.com",
                LastName = "Nike"
            };

            var isValid = customer.Validate();

            Assert.True(isValid, "Validate function was false");
        }
    }
}