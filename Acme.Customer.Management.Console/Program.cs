using Acme.Customer.Management.Data;

namespace Acme.Customer.Management.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            var addressRepo = new AddressRepository();
            var addresses = addressRepo.Get(1);
        }
    }
}
