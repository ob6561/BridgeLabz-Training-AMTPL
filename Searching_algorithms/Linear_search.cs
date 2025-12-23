using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_and_searching_techniques.Searching_algorithms
{
    internal class Linear_search
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
                Console.WriteLine(arr[i] + " ");
            }
            
            Console.WriteLine("Enter the element to be searched:");
            int key = Convert.ToInt32(Console.ReadLine());
            
            for(int i =0; i<n; i++)
            {
                if (arr[i] == key)
                {
                    Console.WriteLine("Element found at index: " + i);
                    
                }
            }
        }
    }
}
