using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Array_problems
{
    internal class even_odd_elements
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of the array:");
            int e = 0, o = 0;
            for( int i=0; i<n; i++)
            {
                Console.WriteLine("Enter element " + (i + 1) + ":");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i<n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    e++;
                }
                else
                {
                    o++;
                }
            }
            Console.WriteLine("The number of even elements is=" + e);
            Console.WriteLine("The number of odd elements is=" + o);
        }
    }
}
