using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_expressions_C__Bridgelabz.Lambda
{
    internal class Printing_elements_of_list
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
            Action<List<int>> print = nums =>
            {
                foreach (var num in nums)
                {
                    Console.WriteLine(num);
                }
            };
            print(numbers);
            
        }
    }
}
