using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Conditionalstatements
{
    internal class greaterof3numbers
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("The greatest number is: " + num1);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("The greatest number is: " + num2);
            }
            else
            {
                Console.WriteLine("The greatest number is: " + num3);
            }
        }
    }
}
