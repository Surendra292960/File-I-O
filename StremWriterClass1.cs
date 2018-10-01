using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.file_handling
{
    class StremWriterClass1
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("g:\\output.txt", FileMode.OpenOrCreate);

            StreamWriter s = new StreamWriter(f);

            s.WriteLine("hello C#");
            s.Close();
            f.Close();
            Console.WriteLine("File created successfully....");
            Console.ReadLine();
        }
    }
}
