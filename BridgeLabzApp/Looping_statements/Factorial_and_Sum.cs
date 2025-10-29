using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Looping_statements
{
    internal class Factorial_and_Sum
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            int sum = 0;
            while (n > 0)
            {
                int d;
                d = n % 10;
                long factorial = 1;
                
                for (int i = 1; i <= d; i++)
                {
                    factorial *= i; // Calculate factorial
                }
                sum += (int)factorial; // Calculate sum of digits
                n = n / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine("The given number is a strong number");
            }
            else
            {
                Console.WriteLine("The given number is not a strong number");
            }
        }
    }
}
