using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioio.IO_streams
{
    internal class Types_of_streams
    {
        static void Main(string[] args)
        {
            //Read write
            FileStream fileStream = new FileStream("filestream.txt", FileMode.Create);
            byte[] fsData = Encoding.UTF8.GetBytes("This is FileStream\n");
            fileStream.Write(fsData, 0, fsData.Length);
            fileStream.Close();

            //Writing text data
            StreamWriter streamWriter = new StreamWriter("streamwriter.txt");
            streamWriter.WriteLine("This is StreamWriter");
            streamWriter.WriteLine("Used for writing text");
            streamWriter.Close();

            //Reads text data
            StreamReader streamReader = new StreamReader("streamwriter.txt");
            Console.WriteLine("\nReading using StreamReader:");
            Console.WriteLine(streamReader.ReadToEnd());
            streamReader.Close();

            //Writes binary data
            BinaryWriter binaryWriter = new BinaryWriter(
            File.Open("binarydata.bin", FileMode.Create));
            binaryWriter.Write(100);
            binaryWriter.Write("Binary Stream");
            binaryWriter.Write(true);
            binaryWriter.Close();

            //Reads binary data
            BinaryReader binaryReader = new BinaryReader(
            File.Open("binarydata.bin", FileMode.Open));

            Console.WriteLine("Reading using BinaryReader:");
            Console.WriteLine(binaryReader.ReadInt32());
            Console.WriteLine(binaryReader.ReadString());
            Console.WriteLine(binaryReader.ReadBoolean());
            binaryReader.Close();

            // Stores data temporarily
            byte[] memoryData = Encoding.UTF8.GetBytes("This is MemoryStream");
            MemoryStream memoryStream = new MemoryStream(memoryData);

            Console.WriteLine("\nReading from MemoryStream:");
            Console.WriteLine(Encoding.UTF8.GetString(memoryStream.ToArray()));
            memoryStream.Close();
        }
    }
}
