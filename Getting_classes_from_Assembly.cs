using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflections
{
    class A { }
    class B { }
    class c { }
    internal class Getting_classes_from_Assembly
    {
        static void Main()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            Type[] types = asm.GetTypes();
            foreach(Type t in types)
            {
                Console.WriteLine(t.Name);
            }
        }
    }
}
