using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Conditionalstatements
{
    internal class greaterof2numbers
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("The greater number is: " + num1);
            }
            else if (num2 > num1)
            {
                Console.WriteLine("The greater number is: " + num2);
            }
            else
            {
                Console.WriteLine("Both numbers are equal.");
            }
        }
    }
}
