using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioio.IO_streams
{
    internal class Read_binary_data
    {
        static void Main()
        {
            BinaryReader br = new BinaryReader(
                File.Open("data.bin", FileMode.Open));

            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadBoolean());
            br.Close();
        }
    }
}
