using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflections
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
    internal class List_properties
    {
        static void Main(string[] args)
        {
            Type t = typeof(Product);
            PropertyInfo[] props = t.GetProperties();
            foreach(PropertyInfo p in props)
            {
                Console.WriteLine($"{p.Name} - {p.PropertyType}");
            }
        }
    }
}
