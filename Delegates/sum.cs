using System;

namespace Lambda_expressions_C__Bridgelabz.Delegates
{
    delegate void myDelegate3(int a, int b);

    internal class sum
    {
        static void Add(int a, int b)
        {
            Console.WriteLine("Sum: " + (a + b));
        }

        static void Main(string[] args)
        {
            myDelegate3 d1 = Add;
            d1(10, 20);
        }
    }
}
