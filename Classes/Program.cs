using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "BAD");
            // Object initializer notation. Eliminates the need for many consructors.
            var cust = new Customer
            {
                Id = 123432134,
                Name = "BAD"
            };
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
