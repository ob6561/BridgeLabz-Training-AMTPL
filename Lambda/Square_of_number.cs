using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_expressions_C__Bridgelabz.Lambda
{
    internal class Square_of_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(x));
        }
    }
}
