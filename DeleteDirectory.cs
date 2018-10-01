using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.file_handling
{
    class DeleteDirectory
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"g:\javatpoint");
            try
            {
                directory.Delete();

                //directory.MoveTo(@"");
                Console.WriteLine("The directory is deleted successfully");
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong:{0}", e.ToString());
            }
            Console.ReadLine();
        }
    }
}
