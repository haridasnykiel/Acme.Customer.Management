using System;
using System.Collections.Generic;

namespace Acme.Customer.Management {
    public class Order {

        public Order()
        {
            
        }

        public Order(int orderId) {
            OrderId = orderId;
        }

        public int OrderId { get; set; }
        public DateTimeOffset? OrderDate { get; set; } 
        public Address ShippingAddress { get; set; } // Composite relationship
        public List<OrderItem> OrderItems { get; set; } // Composite relationships
        
        public bool Validate () {
            return OrderDate != null;
        }
    }
}