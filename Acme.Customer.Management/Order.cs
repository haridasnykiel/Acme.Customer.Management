using System;
using System.Collections.Generic;
using Acme.Common.Interfaces;
using Acme.Customer.Management.Base;

namespace Acme.Customer.Management {

    public class Order : EntityBase, ILoggable
    {

        public Order() : this(0)
        {
            
        }

        public Order(int orderId) 
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int OrderId { get; set; }
        public DateTimeOffset? OrderDate { get; set; } 
        public int CustomerId { get; set; } // Composite relationship
        public int ShippingAddressId { get; set; } // Composite relationship
        public List<OrderItem> OrderItems { get; set; } // Composite relationships

        public override string ToString() => $"({OrderId}) {OrderDate.Value.ToString()}"; // example of polymorphism

        public override bool Validate()
        {
            return OrderDate != null;
        }

        public string Log() =>
            $"{nameof(Order)} - ID: {OrderId} - {OrderDate} - customerId: {CustomerId}";
        
    }
}