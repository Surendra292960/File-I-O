using System;
using System.IO;

namespace ConsoleApp1.file_handling
{
    class TextWriterClass1
    {
        static void Main(string[] args)
        {
            using (TextWriter writer = File.CreateText("g:\\f.txt")) 
                {
                writer.WriteLine("Hello C#");
                writer.WriteLine("C# File Handling by JavaTPoint");

                 }
            Console.WriteLine("Data written Successfully....");
            Console.Read();
        }
    }
}
