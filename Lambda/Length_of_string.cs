using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_expressions_C__Bridgelabz.Lambda
{
    internal class Length_of_string
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            Func<string, int> funcc = s => s.Length;
            Console.WriteLine("Length of the string is: " + funcc(str));
        }
    }
}
