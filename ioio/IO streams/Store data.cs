using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioio.IO_streams
{
    internal class Store_data
    {
        static void Main()
        {
            byte[] data = Encoding.UTF8.GetBytes("MemoryStream Data");
            MemoryStream ms = new MemoryStream(data);

            Console.WriteLine(Encoding.UTF8.GetString(ms.ToArray()));
            ms.Close();
        }
    }
}
