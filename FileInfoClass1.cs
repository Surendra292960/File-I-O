using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.file_handling
{
    class FileInfoClass1
    {
        static void Main(string[] args)
        {
            try
            {
                string loc = "g:\\abc";

                FileInfo file = new FileInfo(loc);
                file.Create();
                Console.WriteLine("File is created Successfully");
            }catch(IOException e)
            {
                Console.WriteLine("Something went wrong:" + e);
            }
            Console.ReadLine();
        }
    }
}
