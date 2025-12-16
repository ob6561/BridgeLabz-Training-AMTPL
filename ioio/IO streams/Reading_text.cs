using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioio.IO_streams
{
    internal class Reading_text
    {
        static void Main()
        {
            StreamReader sr = new StreamReader("file1.txt");
            string content = sr.ReadToEnd();
            sr.Close();

            Console.WriteLine(content);
        }
    }
}
