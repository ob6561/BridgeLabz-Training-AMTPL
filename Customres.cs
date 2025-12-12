using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_tasks
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Product { get; set; }
    }
    internal class Customres
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>
            {
                new Customer{ Id=1, Name="Rohit"},
                new Customer{ Id=2, Name="Sonal"},
                new Customer{ Id=3, Name="Priya"}
            };

            var orders = new List<Order>
            {
                new Order{ Id=100, CustomerId=1, Product="Book" },
                new Order{ Id=101, CustomerId=1, Product="Pen" },
                new Order{ Id=102, CustomerId=2, Product="Notebook" }
            };
            var innerJoin =
                from c in customers
                join o in orders on c.Id equals o.CustomerId
                select new { CustomerName = c.Name, o.Product, o.Id };

            Console.WriteLine("Inner join (customers with orders):");
            foreach (var item in innerJoin)
                Console.WriteLine($"{item.CustomerName} ordered {item.Product} (order #{item.Id})");

            
            var leftJoin = from c in customers
                           join o in orders on c.Id equals o.CustomerId into custOrders
                           select new
                           {
                               Customer = c.Name,
                               Orders = custOrders.DefaultIfEmpty()
                           };

            Console.WriteLine("\nLeft outer join (all customers, with orders if any):");
            foreach (var entry in leftJoin)
            {
                Console.WriteLine($"\nCustomer: {entry.Customer}");
                var actualOrders = entry.Orders.Where(x => x != null).ToList();
                if (actualOrders.Any())
                {
                    foreach (var ord in actualOrders)
                        Console.WriteLine($"  Order #{ord.Id}: {ord.Product}");
                }
                else
                {
                    Console.WriteLine("  No orders.");
                }
            }
        }
    }
}
