using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Array_problems
{
    internal class sum_and_avg_of_elements
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of the array:");
            for(int i =0; i<n; i++)
            {
                Console.WriteLine("Enter element " + (i + 1) + ":");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for(int i=0; i<n; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("The sum is=" + sum);
            Console.WriteLine("The average is=" + (sum/n));
        }
    }
}
