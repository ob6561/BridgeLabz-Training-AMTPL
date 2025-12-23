using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_and_searching_techniques.Sorting_algorithms
{
    internal class Merge_sort
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

            
            MergeSort(arr, 0, n - 1);

            Console.WriteLine("The sorted array is:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }

        
        private static void MergeSort(int[] arr, int left, int right)
        {
            if (left >= right)
                return;

            int mid = (left + right) / 2;

            
            MergeSort(arr, left, mid);

            
            MergeSort(arr, mid + 1, right);

            
            Merge(arr, left, mid, right);
        }

        
        private static void Merge(int[] arr, int left, int mid, int right)
        {
            int i = left;      
            int j = mid + 1;   
            int k = 0;         

            int[] temp = new int[right - left + 1];

            
            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k] = arr[i];
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    j++;
                }
                k++;
            }

            
            while (i <= mid)
            {
                temp[k] = arr[i];
                i++;
                k++;
            }

            
            while (j <= right)
            {
                temp[k] = arr[j];
                j++;
                k++;
            }

            
            for (int t = 0; t < temp.Length; t++)
            {
                arr[left + t] = temp[t];
            }
        }
    }
}
