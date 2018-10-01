using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.file_handling
{
    class StringReaderClass1
    {
        static void Main(string[] args)
        {
            StringWriter str = new StringWriter();
            str.WriteLine("Hello,this message is ready by StringReader class");
            StringReader reader = new StringReader(str.ToString());

            while(reader.Peek()>-1)
            {
                Console.WriteLine(reader.ReadLine());
                Console.ReadLine();
            }
        }
    }
}
