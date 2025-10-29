using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Looping_statements
{
    internal class Perfect_number
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            for( int i=2; i< Math.Sqrt(n); i++)
            {
                if (n% i == 0)
                {
                    sum += i;
                    if (i != n / i)
                    {
                        sum += n / i;
                    }
                }

            }
            if (sum == n && n != 1)
            {
                Console.WriteLine($"{n} is a Perfect Number");
            }
            else
            {
                Console.WriteLine($"{n} is NOT a Perfect Number");
            }
        }
    }
}
