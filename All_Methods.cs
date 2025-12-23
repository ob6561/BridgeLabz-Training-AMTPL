using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflections
{
    class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Sub(int a, int b) => a - b;
        public int Mul(int a, int b) => a * b;
        public int Div(int a, int b) => a / b;
    }
    internal class All_Methods
    {
        static void Main(string[] args)
        {
            Type t=typeof(Calculator);
            MethodInfo[] methods= t.GetMethods();
            foreach (MethodInfo m in methods)
            {
                Console.WriteLine(m.Name);
            }
        }
    }
}
