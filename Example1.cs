using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflections
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class Example1
    {
        static void Main(string[] args)
        {
            Type t = typeof(Student);
            Console.WriteLine("Class Name: " +  t.Name);
            Console.WriteLine("Is Class: " + t.IsClass);
            Console.WriteLine("Is Public: " + t.IsPublic);
        }
    }
}
