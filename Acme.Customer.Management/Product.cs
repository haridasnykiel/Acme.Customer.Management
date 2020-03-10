using System;
using System.Collections.Generic;

namespace Acme.Customer.Management
{
    public class Product
    {

        public Product()
        {
            
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductName { get; set; } 
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; } //nullable
        
        public bool Validate() {
            
            if(string.IsNullOrEmpty(ProductName) || CurrentPrice == null) {
                return false;
            }
            
            return true;
        }

        public Product Get(int productId) {
            return new Product();
        }

        public List<Product> GetAll()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            return true;
        }
    }
}