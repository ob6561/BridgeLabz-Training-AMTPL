using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_expressions_C__Bridgelabz.Lambda
{
    internal class Double_every_number
    {
        static void Main(string[] args)
        {
            int [] numbers = { 1, 2, 3, 4, 5 };
            Func<int[], int[]> doubleNumbers = nums => nums.Select(n => n * 2).ToArray();
            int[] doubled = doubleNumbers(numbers);
            Console.WriteLine("Doubled numbers: " + string.Join(", ", doubled));
        }
    }
}
