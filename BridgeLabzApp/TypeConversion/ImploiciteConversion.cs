using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.TypeConversion
{
    internal class ImploiciteConversion
    {
        static void Main(string[] args)
        {
            int a = 100;
            double b = a; // Implicit conversion from int to double
            Console.WriteLine("Integer value: " + a);
            int c = (int) b; // Implicit conversion from double to int (This will cause a compile-time error)
        }
    }
}
