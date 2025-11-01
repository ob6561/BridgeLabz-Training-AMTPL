using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.String_problems
{
    internal class Non_repeating_character
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            
            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }
            
            foreach (char c in input)
            {
                if (charCount[c] == 1)
                {
                    Console.WriteLine($"The first non-repeating character is: {c}");
                    return;
                }
            }
            Console.WriteLine("There are no non-repeating characters.");
        }
    }
}
