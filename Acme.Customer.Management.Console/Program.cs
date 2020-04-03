using Acme.Customer.Management.Data;

namespace Acme.Customer.Management.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            var addressRepo = new AddressRepository();
            var address = addressRepo.Get(1);
            object myObject = new object();

            System.Console.WriteLine($"{myObject.ToString()}");
            System.Console.WriteLine($"{address.ToString()}");

            var productRepo = new ProductRepository();
            var product = productRepo.Get(1);
            System.Console.WriteLine(product.ToString());

            // var customerRepo = new CustomerRepository();
            // var customer = customerRepo.Get(1);
            // System.Console.WriteLine(customer.ToString());

            // var orderRepo = new OrderRepository();
            // var order = orderRepo.Get(1);
            // System.Console.WriteLine(order.ToString());
        }
    }
}
