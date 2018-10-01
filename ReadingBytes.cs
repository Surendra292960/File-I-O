using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.file_handling
{
    class ReadingBytes
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("g:\\b.txt",FileMode.OpenOrCreate);
            int i = 0;
            while((i = f.ReadByte())!=-1)
            {
              Console.Write((char)i);
            }
            f.Close();
            Console.Read();
        }
    }
}
