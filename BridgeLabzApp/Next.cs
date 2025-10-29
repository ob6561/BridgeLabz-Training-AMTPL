using System;

namespace BridgeLabzApp
{
    internal class Next
    {
        static void Main(string[] args)
        {
            // Integer types
            byte byteVar = 255;          // 8-bit unsigned
            short shortVar = -32768;     // 16-bit signed
            int intVar = 100000;         // 32-bit signed
            long longVar = 1234567890L;  // 64-bit signed

            // Floating-point types
            float floatVar = 3.14f;      // 32-bit floating point
            double doubleVar = 3.14159265359; // 64-bit floating point
            decimal decimalVar = 19.99m; // 128-bit precise decimal

            // Character and boolean
            char charVar = 'A';
            bool boolVar = true;

            // String
            string stringVar = "Hello, BridgeLabz!";

            Console.WriteLine("=== Primitive Data Types in C# ===\n");
            Console.WriteLine($"byte     : {byteVar}");
            Console.WriteLine($"short    : {shortVar}");
            Console.WriteLine($"int      : {intVar}");
            Console.WriteLine($"long     : {longVar}");
            Console.WriteLine($"float    : {floatVar}");
            Console.WriteLine($"double   : {doubleVar}");
            Console.WriteLine($"decimal  : {decimalVar}");
            Console.WriteLine($"char     : {charVar}");
            Console.WriteLine($"bool     : {boolVar}");
            Console.WriteLine($"string   : {stringVar}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
