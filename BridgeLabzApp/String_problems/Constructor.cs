using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.String_problems
{
    internal class Constructor
    {
        public static void Main(string[] args)
        {
            char[] chars = {'O', 'm', ' ', 'B', 'a', 'n', 'd', 'y', 'o', 'p', 'a', 'd', 'h', 'y', 'a', 'y' };
            string s = new string(chars);
            Console.WriteLine(s);
            string s2 = new string('O', 4);
            Console.WriteLine(s2);
            StringBuilder sb = new StringBuilder("Om Bandyopadhyay", 20);
            
            Console.WriteLine(sb);
            sb.Replace("Om", "Ashimey");
            Console.WriteLine(sb);
        }
    }
}
