using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace ConsoleApp1.file_handling
{
    [Serializable]
    class Student
    {
        int rollno;
        string name;
        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
    public class SerializeExample
    {
        public static void Main(string[] args)
        {
            FileStream stream = new FileStream("g:\\sss.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Student s = new Student(101, "sonoo");
            formatter.Serialize(stream, s);

            stream.Close();
        }
    }
}