using System;

namespace Acme.Customer.Management
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }

        public bool Validate() {
            return Product != null && Quantity > 0;
        }

        public OrderItem Get() {
            throw new NotImplementedException();
        }

        public void Save() {
            throw new NotImplementedException();
        }
    }
}