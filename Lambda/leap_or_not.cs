using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_expressions_C__Bridgelabz.Lambda
{
    internal class leap_or_not
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Func<int, bool> isLeapYear = y =>
            {
                return y % 4 == 0 && y % 100 != 0 || y % 400 == 0;
            };
            if (isLeapYear(year))
                Console.WriteLine($"{year} is a leap year.");
            else
                Console.WriteLine($"{year} is not a leap year.");
        }
    }
}
