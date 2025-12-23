using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflections
{
    class Message
    {
        public void Show()
        {
            Console.WriteLine("Hello from reflection: ");
        }
    }
    internal class Invoking_a_method
    {
        static void Main()
        {
            Type t = typeof(Message);
            object obj = Activator.CreateInstance(t);
            MethodInfo method = t.GetMethod("Show");
            method.Invoke(obj, null);
        }
    }
}
