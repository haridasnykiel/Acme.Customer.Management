using System;
using Acme.Customer.Management.Data;
using NUnit.Framework;

namespace Acme.Customer.Management.Tests
{
    public class OrderRepositoryTests
    {
        [Test]
        public void Get_AValidOrder()
        {
            var orderRepo = new OrderRepository();
            var expectedOrder = new Order(1)
            {
                OrderDate = DateTime.Now.AddDays(1)
            };

            var actualOrder = orderRepo.Get(1);


            Assert.AreEqual(expectedOrder.OrderId, actualOrder.OrderId);    
            Assert.AreEqual(expectedOrder.OrderDate.ToString(), actualOrder.OrderDate.ToString());
        }
    }
}