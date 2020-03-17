using System;

namespace Acme.Customer.Management
{
    public class OrderItem
    {

        public OrderItem()
        {
            
        }

        public OrderItem(int orderItemId) {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        public bool Validate() {
            return ProductId > 0 && Quantity > 0 && PurchasePrice != null;
        }
    }
}