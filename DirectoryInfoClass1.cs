using System;
using System.IO;

namespace ConsoleApp1.file_handling
{
    class DirectoryInfoClass1
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"g:\javatpoint");

            try
            {
                if(directory.Exists)
                {
                    Console.WriteLine("Directory already exist.");
                    return;
                }
                directory.Create();
                Console.WriteLine("The directory is created successfully.");
            }
            catch(Exception e)
            {
                Console.WriteLine("Directory not created:{0}",e.ToString());
               
            }
            Console.ReadLine();
        }
    }
}
