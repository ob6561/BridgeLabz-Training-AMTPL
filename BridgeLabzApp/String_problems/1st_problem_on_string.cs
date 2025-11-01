using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.String_problems
{
    internal class _1st_problem_on_string
    {
        public static void Main(string[] args)
        {
            string fullname = "Om Bandyopadhyay";
            fullname = fullname.ToUpper();
            Console.WriteLine(fullname);
            fullname = fullname.ToLower();
            Console.WriteLine(fullname);

            string phno = "1234-1258-1286";
            phno = phno.Replace("-", "");
            Console.WriteLine(phno);

            string user = fullname.Insert(0, "Mr. ");
                        Console.WriteLine(user);
            Console.WriteLine(fullname.Length);

            string firstname = fullname.Substring(0, 2);
            Console.WriteLine(firstname);
            string lastname = fullname.Substring(3, 13);
            Console.WriteLine(lastname);
        }
    }
}
