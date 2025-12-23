using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    class Person
    {
        public string Name { get; set; }
        private int Age { get; set; }
    }
    internal class Displaying_fields_of_a_class
    {
        static void Main()
        {
            Type t = typeof(Person);
            FieldInfo[] fields = t.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine(field.Name);
            }
        }
    }
}
