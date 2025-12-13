using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_tasks
{
    class Prod
    {
        public string Name {  get; set; }
        public double Price {  get; set; }
    }
    internal class Costliest
    {
        static void Main(string[] args)
        {
            List<Prod> products = new List<Prod>
            {
                new Prod { Name = "Laptop", Price = 70000 },
                new Prod { Name = "Phone", Price = 40000 },
                new Prod { Name = "Tablet", Price = 30000 },
                new Prod { Name = "Watch", Price = 15000 }
            };

            var top3 = products
                .OrderByDescending(p => p.Price)
                .Take(3);
            foreach ( var prod in top3)
            {
                Console.WriteLine(prod.Price);
            }
        }
    }
}
