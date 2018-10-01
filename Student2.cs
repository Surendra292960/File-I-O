using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp1.file_handling
{
    [Serializable]

    class Student2
    {
        public  int rollno;
        public string name;

        public Student2(int rollno,string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }

    public class DeserializableExample
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("g:\\sss.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Student2 s = (Student2)formatter.Deserialize(stream);
           
            Console.WriteLine("Rollno: " + s.rollno);
            Console.WriteLine("Name: " + s.name);

            stream.Close();
        }
    }
}
