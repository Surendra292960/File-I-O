using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.file_handling
{
    class FileInfoWriteFile
    {
        static void Main(string[] args)
        {
            try
            {
                string loc = "g:\\abc.txt";
                FileInfo file = new FileInfo(loc);
                StreamWriter sw = file.CreateText();
                sw.WriteLine("This text is written to the file by using StreamWriter class");
                sw.Close();
            }catch(IOException e)
            {
                Console.WriteLine("Something went wrong" + e);
            }
            Console.ReadLine();
        }
    }
}
