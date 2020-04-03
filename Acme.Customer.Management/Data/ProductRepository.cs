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

        public bool Save(Product product)
        {
            var success = true;
            if(!product.HasChanged) 
            {
                return success;
            } 

            if(!product.IsValid) 
            {
                success = false;
                return success;
            }

            if(product.IsNew) 
            {
                // call insert sproc
            }
            else 
            {
                // call update sproc
            }

            return success;
        }

        private Product MockProduct = new Product(1) {
            ProductName = "MetalSpoon",
            CurrentPrice = 45M
        };
    }
}