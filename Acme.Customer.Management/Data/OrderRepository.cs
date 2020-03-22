using System;

namespace Acme.Customer.Management.Data
{
    public class OrderRepository
    {
        public Order Get(int orderId)
        {
            if(orderId == 1) {
                return MockOrder;
            }
            return new Order();
        }

        public bool Save()
        {
            return true;
        }

        private Order MockOrder = new Order(1) {
            OrderDate = DateTime.Now.AddDays(1)
        };
    }
}