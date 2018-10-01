using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.file_handling
{
    class MultipleBytes
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("g:\\b.txt", FileMode.OpenOrCreate);
            for (int i = 65; i<100; i++)
            {
                f.WriteByte((byte)i);
            }
            f.Close();
        }
    }
}
