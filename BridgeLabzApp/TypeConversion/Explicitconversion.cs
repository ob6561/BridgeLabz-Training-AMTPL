using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.TypeConversion
{
    /// <summary>
    internal class Explicitconversion
    {
        static void Main(string[] args)
        {
            double a = 9.78;
            int b = (int)a; // Explicit conversion from double to int
            Console.WriteLine("Double value: " + a);
            Console.WriteLine("Converted Integer value: " + b);
        }
    }
}
