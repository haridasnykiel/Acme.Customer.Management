using System;
using System.Collections.Generic;
using Acme.Common.Interfaces;
using Acme.Common.Services;
using Acme.Customer.Management.Data;

namespace Acme.Customer.Management.Console {
    class Program {
        static void Main (string[] args) {

            var productRepo = new ProductRepository ();
            var product = productRepo.Get (1);

            System.Console.WriteLine (product.ToString ());
            System.Console.WriteLine (product.Log ());

            var customerRepo = new CustomerRepository ();
            var customer = customerRepo.Get (1);
            System.Console.WriteLine (customer.ToString ());
            System.Console.WriteLine (customer.Log ());

            var orderRepo = new OrderRepository();
            var order = orderRepo.Get(1);
            System.Console.WriteLine(order.ToString());
            System.Console.WriteLine(order.Log());

            var listOfLoggables = new List<ILoggable> ();
            listOfLoggables.Add (customer);
            listOfLoggables.Add(product);
            listOfLoggables.Add(order);
            var datetime = DateTime.Now.ToString ("yyyy-MM-dd");
            LoggingService.WriteToFile ($"/Users/Hari/Log/{datetime}-Customer-Management-Service", listOfLoggables);
        }
    }
}