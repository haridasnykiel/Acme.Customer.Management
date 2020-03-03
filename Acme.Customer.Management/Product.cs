using System;
using System.Collections.Generic;

namespace Acme.Customer.Management
{
    public class Product
    {
        public int ProductId { get; private set; }
        public string ProductName { get; set; } 
        public string Description { get; set; }
        public decimal Price { get; set; }
        
        public bool Validate() {
            
            if(string.IsNullOrEmpty(ProductName) || Price <= 0) {
                return false;
            }
            
            return true;
        }

        public Product Get(int productId) {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}