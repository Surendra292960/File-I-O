using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.file_handling
{
    class TextReaderClass2
    {
        static void Main(string[] args)
        {
            using (TextReader tr = File.OpenText("g:\\f.txt"))
            {
                Console.WriteLine(tr.ReadLine());
            }
            Console.Read();
        }
    }
}
