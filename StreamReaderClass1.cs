using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.file_handling
{
    class StreamReaderClass1
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("g:\\output.txt",FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);

            string line = s.ReadLine();
            Console.WriteLine(line);

            s.Close();
            f.Close();
            Console.Read();
        }
    }
}
