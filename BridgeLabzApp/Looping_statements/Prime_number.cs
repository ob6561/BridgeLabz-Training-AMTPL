using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Looping_statements
{
    internal class Prime_number
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool isprime = true;
            if (n <= 1)
            {
                isprime = false;
            }
            else
            {
                for(int i=2; i<= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isprime = false;
                        break; // no need to check further
                    }
                }
            }
            if (isprime)
            {
                Console.WriteLine($"{n} is a Prime Number");
            }
            else
            {
                Console.WriteLine($"{n} is NOT a Prime Number");
            }
        }
    }
}
