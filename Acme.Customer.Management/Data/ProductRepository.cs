namespace Acme.Customer.Management.Data
{
    public class ProductRepository
    {
        public Product Get(int productId)
        {
            if(productId == 1) {
                return MockProduct;
            }
            return new Product();
        }

        public bool Save()
        {
            return true;
        }

        private Product MockProduct = new Product(1) {
            ProductName = "metal",
            CurrentPrice = 45M
        };
    }
}