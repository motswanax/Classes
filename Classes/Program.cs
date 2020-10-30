using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "BAD");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
