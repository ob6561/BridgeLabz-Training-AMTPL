using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflections
{
    class Student1
    {
        public string Name { get; set; }
    }
    internal class Property_parameters
    {
        static void Main()
        {
            Type t = typeof(Student);
            object obj = Activator.CreateInstance(t);
            PropertyInfo prop = t.GetProperty("Name");
            prop.SetValue(obj, "Om");
            Console.WriteLine("Student Name: " + prop.GetValue(obj));
        }
    }
}
