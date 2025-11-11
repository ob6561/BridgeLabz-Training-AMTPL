using System;

namespace BridgeLabzApp.OOPs_work.Abstraction
{
    internal class ConstDest
    {
        private string name;
        private int age;
        private double salary;

        // Non-paramitarized constructor
        public ConstDest() :  base()
        {
            name = null;
            age = 0;
            Console.WriteLine("Default Constructor Called");
        }

        // Parameterized constructor
        public ConstDest(string name, int age) 
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("Parameterized Constructor Called");
        }

        // Copy constructor (manually implemented in C#)
        public ConstDest(ConstDest other) : this()
        {
            this.name = other.name;
            this.age = other.age;
            Console.WriteLine("Copy Constructor Called");
        }

        // Constructor chaining (calls the parameterized one first)
        public ConstDest(string name,int age,double salary) : this(name, age) // default age = 18
        {
            //this(name, age);
            this.salary = salary;
            Console.WriteLine("Constructor Chaining Example Called");
        }

        // Destructor (called by garbage collector)
        ~ConstDest()
        {
            Console.WriteLine($"Destructor Called for {name}");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Default constructor
            

            // Parameterized constructor
            ConstDest person2 = new ConstDest("Adithya", 22);
            person2.DisplayInfo();
            Console.WriteLine();

            // Constructor chaining
            ConstDest person3 = new ConstDest("Jenson",22,200.00);
            person3.DisplayInfo();

            Console.WriteLine();

            // Copy constructor
            ConstDest person4 = new ConstDest(person2);
            person4.DisplayInfo();

            Console.WriteLine("Program Execution Completed. Waiting for Destructor Calls...");
            Console.ReadLine(); // Keep console open to observe destructor messages
        }
    }
}
