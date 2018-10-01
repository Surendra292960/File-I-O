using System;
using System.IO;

namespace ConsoleApp1.file_handling
{
    class FileInfoReadLine
    {
        static void Main(string[] args)
        {
            try
            {
                string loc = "g:\\abc.txt";

                FileInfo file = new FileInfo(loc);

                StreamReader sr = file.OpenText();
                string data = "";
                while((data = sr.ReadLine())!=null)
                {
                    Console.WriteLine(data);
                }
            }catch(IOException e)
            {
                Console.WriteLine("Something went wrong:" + e);
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
