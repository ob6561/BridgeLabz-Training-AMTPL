using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_expressions_C__Bridgelabz.Delegates
{
    delegate void myDelegate2(string message);
    internal class trial2
    {
        static void PrintUpper(string msg)
        {
            Console.WriteLine(msg.ToUpper());
        }
        static void PrintLower(string msg)
        {
            Console.WriteLine(msg.ToLower());
        }
        static void ShowMessage(myDelegate2 d2)
        {
            d2("helloo");
        }
        static void Main(string[] rags)
        {
            ShowMessage(PrintUpper);
            ShowMessage(PrintLower);
        }
    }
}
