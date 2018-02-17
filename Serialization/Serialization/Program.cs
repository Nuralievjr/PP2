using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{   
    [Serializable]
    class Student
    {
        public string name;
        public string surname;
        public int age;
        public Student() { }
        public Student(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }


    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            //Student s = new Student();
            //s.name = Console.ReadLine();
            //s.surname = Console.ReadLine();
            //s.age = int.Parse(Console.ReadLine());
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //Student d = new Student();
            Student d = bf.Deserialize(fs) as Student;
            Console.WriteLine(d.name + " " + d.surname + " " + d.age);
            fs.Close();
        }
    }


}
