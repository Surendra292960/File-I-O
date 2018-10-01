using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.file_handling
{
    class BinaryWriterClass1
    {
        static void Main(string[] args)
        {
            string fileName = "g:\\binaryfile.dat";
            using(BinaryWriter writer = new BinaryWriter(File.Open(fileName,FileMode.Create)))
            {
                writer.Write(2.5);
                writer.Write("this is string data");
                writer.Write(true);
            }
            Console.WriteLine("Data wrritten successfully....");
            Console.Read();
        }
    }
}
