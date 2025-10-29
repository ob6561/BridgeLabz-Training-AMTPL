using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Looping_statements
{
    internal class Counting_even_and_odd_digits
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int e = 0, o = 0;
            while (n > 0){
                int d = n % 10;
                if(d % 2 == 0)
                {
                    e++;
                }
                else
                {
                    o++;
                }
                n = n / 10;
            }
            Console.WriteLine("Number of even digits: " + e);
            Console.WriteLine("Number of odd digits: " + o);
        }
    }
}
