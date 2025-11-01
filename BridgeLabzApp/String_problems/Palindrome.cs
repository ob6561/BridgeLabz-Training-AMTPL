using System;

namespace BridgeLabzApp.String_problems
{
    internal class Palindrome
    {
        public static void Main()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            string rev = "";
            int n = str.Length;
            for (int i = n-1; i >= 0; i--)
            {
                rev += str[i];
            }

            if (str == rev)
            {
                Console.WriteLine(" is a palindrome.");
            }
            else
            {
                Console.WriteLine("is not a palindrome.");
            }
        }
    }
}
