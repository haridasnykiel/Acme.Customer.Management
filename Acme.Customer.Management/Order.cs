using System;

namespace Acme.Customer.Management {
    public class Order {

        public Order()
        {
            
        }

        public Order(int orderId) {
            OrderId = orderId;
        }

        public int OrderId { get; set; }
        public DateTimeOffset? OrderDate { get; set; } //nullable

        public bool Validate () {
            return OrderDate != null;
        }

        public Order Get (int orderId) {
            return new Order();
        }

        public bool Save () {
            return true;
        }
    }
}