using System;
using Acme.Customer.Management.Base;

namespace Acme.Customer.Management
{
    public class OrderItem : EntityBase
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

        public override bool Validate() {
            return ProductId > 0 && Quantity > 0 && PurchasePrice != null;
        }
    }
}