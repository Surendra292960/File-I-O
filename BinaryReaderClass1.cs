using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.file_handling
{
    class BinaryReaderClass1
    {
        static void Main(string[] args)
        {
            WriteBinaryFile();
            ReadBinaryFile();
            Console.ReadKey();
        }
        static void WriteBinaryFile()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("g:\\binaryfile.dat",FileMode.Create)))
            {
                writer.Write(12.5);
                writer.Write("this is string data");
                writer.Write(true);
            }
        }
        static void ReadBinaryFile()
        {
            using (BinaryReader reader = new BinaryReader(File.Open("g:\\binaryfile.dat",FileMode.Open)))
            {
                Console.WriteLine("Double Value:" + reader.ReadDouble());
                Console.WriteLine("String Value:" + reader.ReadString());
                Console.WriteLine("Boolean Value:" + reader.ReadBoolean());
                Console.Read();
            }
        }
    }
}
