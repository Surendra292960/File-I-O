using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace ConsoleApp1.file_handling
{
    class File1
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("g:\\b.txt", FileMode.OpenOrCreate);
            f.WriteByte(65);
            f.Close();
        }
    }
}
