using System;

namespace Lambda_expressions_C__Bridgelabz.Delegates
{
    delegate int calDelegate(int a, int b);

    internal class Calculations
    {
        int Add(int a, int b) => a + b;
        int Subtract(int a, int b) => a - b;
        int Multiply(int a, int b) => a * b;
        int Divide(int a, int b) => a / b;

        public static void Main(string[] args)
        {
            Calculations obj = new Calculations();
            calDelegate op;

            Console.WriteLine("1-Add, 2-Sub, 3-Mul, 4-Div");
            int ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1) op = obj.Add;
            else if (ch == 2) op = obj.Subtract;
            else if (ch == 3) op = obj.Multiply;
            else op = obj.Divide;

            Console.WriteLine(op(5, 10));
        }
    }
}
