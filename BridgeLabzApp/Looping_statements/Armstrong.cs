using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Looping_statements
{
    internal class Armstrong
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter a number :");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            int sum = 0;
            while (n > 0)
            {
                int d = n % 10;
                int a = d * d * d;
                n = n / 10;
                sum += a;
            }
            if(sum == temp)
            {
                Console.WriteLine("The given number is an Armstrong number");
            }
            else
            {
                Console.WriteLine("The given number is not an Armstrong number");
            }
        }
    }
}
