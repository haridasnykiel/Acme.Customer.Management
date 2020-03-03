using System;

namespace Acme.Customer.Management {
    public class Order {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        public bool Validate () {
            return IsOrderDateNotSet();
        }

        private bool IsOrderDateNotSet () {
            return OrderDate != DateTime.MinValue;
        }

        public Order Get (int orderId) {
            throw new NotImplementedException ();
        }

        public bool Save () {
            throw new NotImplementedException ();
        }
    }
}