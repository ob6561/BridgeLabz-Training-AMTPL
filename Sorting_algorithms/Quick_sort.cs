using System;

namespace Sorting_and_searching_techniques.Sorting_algorithms
{
    internal class Quick_sort
    {
        public static void Main(string[] args)
        {
            int[] arr = { 9, 3, 7, 5, 6, 4, 8, 2, 1 };

            Console.WriteLine("Original Array:");
            PrintArray(arr);

            QuickSort(arr, 0, arr.Length - 1);

            Console.WriteLine("\nSorted Array:");
            PrintArray(arr);

            Console.ReadLine();
        }

        
        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(arr, low, high);

                QuickSort(arr, low, partitionIndex - 1);
                QuickSort(arr, partitionIndex + 1, high);
            }
        }

        
        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, high);
            return i + 1;
        }

        
        private static void Swap(int[] arr, int i, int j)
        {
            
            (arr[i], arr[j]) = (arr[j], arr[i]);
        }

        private static void PrintArray(int[] arr)
        {
            foreach (int value in arr)
                Console.Write(value + " ");
            Console.WriteLine();
        }
    }
}
