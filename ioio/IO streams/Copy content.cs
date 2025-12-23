using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioio.IO_streams
{
    internal class Copy_content
    {
        static void Main()
        {
            StreamReader sr = new StreamReader("file1.txt");
            StreamWriter sw = new StreamWriter("file_copy.txt");

            sw.Write(sr.ReadToEnd());

            sr.Close();
            sw.Close();

            Console.WriteLine("File copied successfully.");
        }
    }
}
