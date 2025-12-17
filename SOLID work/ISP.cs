using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_work
{
    interface IPrintable
    {
        void Print();
    }

    interface IScannable
    {
        void Scan();
    }

    class Printer : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Printing document");
        }
    }
    class Scanner : IScannable
    {
        public void Scan()
        {
            Console.WriteLine("Scanning document");
        }
    }
    internal interface ISP
    {
        static void Main()
        {
            IPrintable printer = new Printer();
            printer.Print();

            IScannable scanner = new Scanner();
            scanner.Scan();
        }
    }
}
