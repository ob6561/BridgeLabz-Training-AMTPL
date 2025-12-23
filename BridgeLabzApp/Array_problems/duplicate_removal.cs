using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Array_problems
{
    internal class duplicate_removal
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

            int[] unique = new int[n];  // Temporary array for unique elements
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                bool isDuplicate = false;

                // check if arr[i] already exists in unique[]
                for (int j = 0; j < count; j++)
                {
                    if (arr[i] == unique[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    unique[count] = arr[i];
                    count++;
                }
            }

            Console.WriteLine("\nArray after removing duplicates:");
            for (int i = 0; i < count; i++)
            {
                Console.Write(unique[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
