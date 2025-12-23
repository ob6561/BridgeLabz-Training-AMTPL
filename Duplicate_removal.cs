using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_tasks
{

    internal class Duplicate_removal
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string> { "Delhi", "Chennai", "Hyderabad", "Delhi" };
            var uniqueCities = cities
                .Select(c => c.ToLower())
                .Distinct();
            foreach(var city in uniqueCities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
