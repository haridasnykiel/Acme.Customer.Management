using Acme.Common.Extensions;
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

        private string _productName;

        public int ProductId { get; private set; }
        public string ProductName 
        { 
            get { return _productName.SplitName(); } 
            set { _productName = value; } 
        } 
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