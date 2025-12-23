using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_and_searching_techniques.Searching_algorithms
{
    internal class Binary_Search
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter the elements of the array in sorted order:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("Enter the element to be searched:");
            int key = Convert.ToInt32(Console.ReadLine());
            int left = 0;
            int right = n - 1;
            bool found = false;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == key)
                {
                    Console.WriteLine("Element found at index: " + mid);
                    found = true;
                    break;
                }
                else if (arr[mid] < key)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            if (!found)
            {
                Console.WriteLine("Element not found in the array.");
            }
        }
    }
}
