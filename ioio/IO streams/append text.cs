using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioio.IO_streams
{
    internal class append_text
    {
        static void Main()
        {
            StreamWriter sw = new StreamWriter("file1.txt", true);
            sw.WriteLine("Appended line");
            sw.Close();

            Console.WriteLine("Text appended.");
        }
    }
}
