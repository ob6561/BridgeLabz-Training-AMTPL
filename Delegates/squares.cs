using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_expressions_C__Bridgelabz.Delegates
{
    delegate void SquareDelegate(int number);
    internal class squares
    {
        static void PrintSquare(int num)
        {
            Console.WriteLine(num * num);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            SquareDelegate square = new SquareDelegate(PrintSquare);
            square(number);
        }
    }
}
