using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_expressions_C__Bridgelabz.Lambda
{
    internal class Odd_even
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            Func<int, string> oddEven = x => x % 2 == 0 ? "Even" : "Odd";
            Console.WriteLine(oddEven(x));
        }
    }
}
