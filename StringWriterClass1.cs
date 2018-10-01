using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.file_handling
{
    class StringWriterClass1
    {
        static void Main(string[] args)
        {
            string text = "Hello, Welcome to the javatpoint\n" + "It is nice site. \n" + "it provides technical tutrials";
            StringBuilder sb = new StringBuilder();
            StringWriter writer = new StringWriter(sb);
            writer.WriteLine(text);
            writer.Flush();
            writer.Close();
    
            StringReader reader = new StringReader(sb.ToString());

            while(reader.Peek()>-1)
            {
                Console.WriteLine(reader.ReadLine());
            }
            Console.Read();
        }
    }
}
