using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioio.IO_streams
{
    internal class Reading_bytes
    {
        static void Main()
        {
            FileStream fs = new FileStream("file2.txt", FileMode.Open);
            byte[] data = new byte[fs.Length];
            fs.Read(data, 0, data.Length);
            fs.Close();

            Console.WriteLine(Encoding.UTF8.GetString(data));
        }
    }
}
