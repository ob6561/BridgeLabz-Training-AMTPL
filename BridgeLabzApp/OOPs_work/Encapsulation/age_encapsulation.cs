using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.OOPs_work.Encapsulation
{
    internal class age_encapsulation
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine("Name cannot be empty!");
                else
                    name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0 || value < 120)
                    Console.WriteLine("Invalid age!");
                else
                    age = value;
            }
        }

        public static void Main()
        {
            age_encapsulation p = new age_encapsulation();
            p.Name = "Alice";
            p.Age = 10;

            Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");

            p.Age = -5;
            p.Name = ""; 
        }
    }
}
