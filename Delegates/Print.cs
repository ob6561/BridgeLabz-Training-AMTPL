using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_expressions_C__Bridgelabz.Delegates
{
    delegate void MessageDelegate(string message);
    internal class Print
    {
        static void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Main(string[] args)
        {
            MessageDelegate messageDelegate = PrintMessage;
            messageDelegate("Hello, this is a delegate example in C#!");
        }
    }
}
