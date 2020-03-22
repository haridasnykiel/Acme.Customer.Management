using Acme.Customer.Management.Data;
using NUnit.Framework;

namespace Acme.Customer.Management.Tests
{
    public class ProductRepositoryTests
    {
        [Test]
        public void Get_ValidProduct() {
            var productRepo = new ProductRepository(); 
            Product expectedProduct = new Product(1)
            {
                ProductName = "metal",
                CurrentPrice = 45M
            };

            var actualProduct = productRepo.Get(1);

            Assert.AreEqual(expectedProduct.ProductId, actualProduct.ProductId);
            Assert.AreEqual(expectedProduct.ProductName, actualProduct.ProductName);
            Assert.AreEqual(expectedProduct.CurrentPrice, actualProduct.CurrentPrice);
        }
    }
}