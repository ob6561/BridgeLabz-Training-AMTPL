using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reflections;

namespace Reflections
{
    class Employee
    {
        public Employee()
        {
            Console.WriteLine("Employee object created");
        }
    }
    internal class Runtime_object_creation
    {
        static void Main(string[] args)
        {
            Type t = typeof(Employee);
            object obj = Activator.CreateInstance(t);
        }
    }
}
