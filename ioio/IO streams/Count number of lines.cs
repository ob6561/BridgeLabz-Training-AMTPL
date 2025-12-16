using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioio.IO_streams
{
    internal class Count_number_of_lines
    {
        static void Main()
        {
            StreamReader sr = new StreamReader("file1.txt");
            int count = 0;

            while (sr.ReadLine() != null)
            {
                count++;
            }

            sr.Close();
            Console.WriteLine("Total Lines: " + count);
        }
    }
}
