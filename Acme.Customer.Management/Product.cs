using System;
using System.Collections.Generic;
using Acme.Customer.Management.Base;

namespace Acme.Customer.Management
{
    public class Product : EntityBase 
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

        public override string ToString() => ProductName; // override Object.ToString(). Also an example of polymorphism.
        
        protected override bool Validate() {
            
            if(string.IsNullOrEmpty(ProductName) || CurrentPrice == null || CurrentPrice <= 0) {
                return false;
            }
            
            return true;
        }
    }
}