using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_tasks
{
    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }

    internal class Product_linqs
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product{ Name="Pen",       Category="Stationery", Price=10m },
                new Product{ Name="Notebook",  Category="Stationery", Price=40m },
                new Product{ Name="Pencil",    Category="Stationery", Price=5m  },
                new Product{ Name="Tea",       Category="Grocery",    Price=120m },
                new Product{ Name="Sugar",     Category="Grocery",    Price=50m },
                new Product{ Name="Shampoo",   Category="Toiletries", Price=150m }
            };

            var groups = products
                         .GroupBy(p => p.Category)
                         .Select(g => new
                         {
                             Category = g.Key,
                             Count = g.Count(),
                             Total = g.Sum(x => x.Price),
                             Average = g.Average(x => x.Price),
                             Items = g.Select(x => x.Name).ToList()
                         });

            Console.WriteLine("Products grouped by category:");
            foreach (var g in groups)
            {
                Console.WriteLine($"\nCategory: {g.Category}");
                Console.WriteLine($" Count = {g.Count}");
                Console.WriteLine($" Total Price = {g.Total}");
                Console.WriteLine($" Average Price = {g.Average:F2}");
                Console.WriteLine(" Items: " + string.Join(", ", g.Items));
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
