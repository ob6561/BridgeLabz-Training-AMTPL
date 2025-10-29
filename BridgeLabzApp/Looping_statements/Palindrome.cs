using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Looping_statements
{
    internal class Palindrome
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int r = 0;
            int temp = n;
            while (n > 0)
            {
                int d = n % 10;
                r= (r*10) + d;
                n= n/10;
            }
            if (temp == r)
            {
                Console.WriteLine("The number is Palindrome");
            }
            else
            {
                Console.WriteLine("The number is not a Palindrome");
            }
        }
    }
}
