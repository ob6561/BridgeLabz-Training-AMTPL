using System;

namespace BridgeLabzApp.OOPs_work.Polymorphism
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    internal class Overloading
    {
        static void Main(string[] args)
        {
            Calculator bolo = new Calculator();

            Console.WriteLine("Task: Method Overloading Demo");
            Console.WriteLine($"Add(int, int): {bolo.Add(5, 10)}");
            Console.WriteLine($"Add(double, double): {bolo.Add(5.10, 25.12)}");
            Console.WriteLine($"Add(int, int, int): {bolo.Add(5, 10, 15)}");

            Console.ReadLine();
        }
    }
}
