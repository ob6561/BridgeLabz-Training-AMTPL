using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ioio.IO_streams
{
    internal class Writing_text
    {
        static void Main()
        {
            StreamWriter sw = new StreamWriter("file1.txt");
            sw.WriteLine("Hello from StreamWriter");
            sw.Close();

            Console.WriteLine("Text written to file.");
        }
    }
}
