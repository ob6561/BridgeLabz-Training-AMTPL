using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioio.IO_streams
{
    internal class Writing_bytes
    {
        static void Main()
        {
            FileStream fs = new FileStream("file2.txt", FileMode.Create);
            byte[] data = Encoding.UTF8.GetBytes("FileStream Example");
            fs.Write(data, 0, data.Length);
            fs.Close();

            Console.WriteLine("Bytes written using FileStream.");
        }
    }
}
