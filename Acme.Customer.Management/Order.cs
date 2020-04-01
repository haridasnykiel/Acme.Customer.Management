using System;
using System.Collections.Generic;

namespace Acme.Customer.Management {
    public class Order {

        public Order() : this(0)
        {
            
        }

        public Order(int orderId) {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int OrderId { get; set; }
        public DateTimeOffset? OrderDate { get; set; } 
        public int CustomerId { get; set; } // Composite relationship
        public int ShippingAddressId { get; set; } // Composite relationship
        public List<OrderItem> OrderItems { get; set; } // Composite relationships
        
        public bool Validate () {
            return OrderDate != null;
        }
    }
}