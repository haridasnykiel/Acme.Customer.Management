using Acme.Customer.Management.Data;
using NUnit.Framework;

namespace Acme.Customer.Management.Tests
{
    public class ProductRepositoryTests
    {
        [Test]
        public void Get_ValidProduct() 
        {
            var productRepo = new ProductRepository(); 
            Product expectedProduct = new Product(1)
            {
                ProductName = "MetalSpoon",
                CurrentPrice = 45M
            };

            var actualProduct = productRepo.Get(1);

            Assert.AreEqual(expectedProduct.ProductId, actualProduct.ProductId);
            Assert.AreEqual(expectedProduct.ProductName, actualProduct.ProductName);
            Assert.AreEqual(expectedProduct.CurrentPrice, actualProduct.CurrentPrice);
        }

        [Test]
        public void Get_NameWillIncludeSpaceBeforeCapital() 
        {
            var productRepo = new ProductRepository();
            var expectedName = "Metal Spoon";

            var actualProduct = productRepo.Get(1);

            Assert.AreEqual(actualProduct.ProductName, expectedName);
        }

        [Test]
        public void Save_ValidProduct() 
        {
            var productRepo = new ProductRepository();
            var validProduct = new Product(1) 
            {
                ProductName = "rocket",
                CurrentPrice = 1M, 
                HasChanged = true
            };

            var isSaved = productRepo.Save(validProduct);

            Assert.True(isSaved);
        }

        [Test]
        public void Save_InvalidProduct()
        {
            var productRepo = new ProductRepository();
            var validProduct = new Product(1)
            {
                ProductName = "chips",
                CurrentPrice = -1,
                HasChanged = true
            };

            var isSaved = productRepo.Save(validProduct);

            Assert.False(isSaved);
        }
    }
}