using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Array_problems
{
    internal class Input_giving
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The elements in the array are:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
                
            }
        }
    }
}
