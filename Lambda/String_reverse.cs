using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_expressions_C__Bridgelabz.Lambda
{
    internal class String_reverse
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            Func<string, string> revstr = s =>
            {
                string rev = "";
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    rev += s[i];
                }
                return rev;
            };
            Console.WriteLine("Reversed string is: " + revstr(str));
        }
    }
}
