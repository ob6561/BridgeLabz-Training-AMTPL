using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioio.IO_streams
{
    internal class Write_binary_data
    {
        static void Main()
        {
            BinaryWriter bw = new BinaryWriter(
                File.Open("data.bin", FileMode.Create));

            bw.Write(25);
            bw.Write("C# Streams");
            bw.Write(true);
            bw.Close();

            Console.WriteLine("Binary data written.");
        }
    }
}
