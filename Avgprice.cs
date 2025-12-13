using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_tasks
{
    public class Product1
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
    internal class Avgprice
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { Name = "Pen", Category = "Stationery", Price = 10 },
                new Product { Name = "Notebook", Category = "Stationery", Price = 40 },
                new Product { Name = "Soap", Category = "Toiletries", Price = 30 }
            };

            var grouped = products
                .GroupBy(p => p.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    AvgPrice = g.Average(p => p.Price)
                });

            foreach (var g in grouped)
            {
                Console.WriteLine($"{g.Category} - Avg Price: {g.AvgPrice}");
            }

            Console.ReadLine(); // keeps console open
        }
    }
}
