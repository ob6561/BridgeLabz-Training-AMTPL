using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.OOPs_work.Inheritance
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Student : Person
    {
        public int StudentID { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Student ID: {StudentID}");
        }
    }
    internal class Demo
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Om";
            s1.Age = 22;
            s1.StudentID = 1001;

            s1.DisplayInfo();
            Console.ReadLine();
        }
    }
}
