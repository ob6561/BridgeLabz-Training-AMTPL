using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Array_problems
{
    internal class maxminelements
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element " + (i + 1) + ":");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i<n; i++)
            {
                for(int j=i+1; j<n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("The minimum element is: " + arr[0]);
            Console.WriteLine("The maximum element is: " + arr[n - 1]);
        }
    }
}
