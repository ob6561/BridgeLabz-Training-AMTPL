using System;
using BridgeLabzApp.Generic;   // <-- Add this so you can access Reverse_array class

namespace BridgeLabzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Original array:");
            foreach (var item in arr)
                Console.Write(item + " ");

            Console.WriteLine();

            // Call your reverse method
            int[] reversed = Reverse_array.ReverseArrayCopy(arr);

            Console.WriteLine("Reversed array:");
            foreach (var item in reversed)
                Console.Write(item + " ");

            Console.ReadLine();
        }
    }
}
