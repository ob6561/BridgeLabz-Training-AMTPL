using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_expressions_C__Bridgelabz.Delegates
{
    delegate int myDelegate(int a, int b);
    internal class trial_program
    {
        static int Add(int a, int b)
        {
                       return a + b;
        }

        static int Multiply(int a, int b)
        {
                       return a * b;
        }
        static void Main(string[] args)
        {
            myDelegate d1 = Add;
            myDelegate d2 = Multiply;
            Console.WriteLine("Addition: " + d1(10, 20));
            Console.WriteLine("Multiplication: " + d2(10, 20));
        }
    }
}
