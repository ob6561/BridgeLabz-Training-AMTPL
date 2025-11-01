using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.String_problems
{
    internal class reverse_a_string
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();
            int n = s.Length;
            string rev = "";
            for(int i = n-1; i>=0; i--)
            {
                rev += s[i];
            }
            Console.WriteLine("Reversed string is: " +rev);

        }
    }
}
