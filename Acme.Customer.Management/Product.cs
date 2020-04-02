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
            
            if(string.IsNullOrEmpty(ProductName) || CurrentPrice == null || CurrentPrice < 0) {
                return false;
            }
            
            return true;
        }
    }
}