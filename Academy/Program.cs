using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Vercetti", "Tommy", 30);
            human.Info();
            Console.WriteLine(human);

            Student student = new Student("Pinkman", "Jessie",  25, "Chemistry", "WW_220", 95, 98);
            student.Info();
            Console.WriteLine(student);

            Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 20);
            teacher.Info();
            Console.WriteLine(teacher);

            Graduate graduate = new Graduate("Shreder", "Hank", 40, "Chriminalistic", "OBN", 40, 70, "How to catch Heisenberg");
            graduate.Info();
            Console.WriteLine(graduate);

            Student tommy = new Student(human, "Theft", "Vice",98,99);
            Console.WriteLine(tommy);

            Graduate tommy_grad = new Graduate(tommy, "How to make money");
            Console.WriteLine(tommy_grad);

            Human[] Group = new Human[]
            {
            student, teacher, graduate, tommy,
            new Graduate("Rosenberg", "Ken", 30, "Lawer", "Vice", 45,22,"How to get money back"),
            new Teacher("Diaz", "Ricardo", 50, "Weapons Distribution", 25)
            };
            Console.WriteLine("---------------------------------------------");
            for (int i = 0; i < Group.Length; i++) {
                Console.WriteLine(Group[i]);
            }
            StreamWriter sw = new StreamWriter("group.txt");
            foreach (Human i in Group) sw.WriteLine($"{i.GetType()}: {i}");
            sw.Close();
            System.Diagnostics.Process.Start("notepad", $"{Directory.GetCurrentDirectory()}\\group.txt");
            Console.WriteLine("---------------------------------------------");

            StreamReader sr = new StreamReader("group.txt");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] data = line.Split();

                string Class = data[0];
                string last_name = data[1];
                string first_Name = data[2];
                int age = int.Parse(data[3]);
                Human person;
                if (Class.Equals("Academy.Student:"))
                {
                    string speciality = data[5];
                    string group = data[6];
                    double rating = double.Parse(data[7]);
                    double attendance = double.Parse(data[8]);
                    person = new Student(last_name, first_Name, age, speciality, group, rating, attendance);
                    person.Info();
                }
                else if (Class.Equals("Academy.Teacher:"))
                {
                    string speciality = data[5];
                    int experience = int.Parse(data[6]);
                    person = new Teacher(last_name, first_Name, age, speciality, experience);
                    person.Info();
                }
                else if (Class.Equals("Academy.Graduate:"))
                {
                    string speciality = data[5];
                    string group = data[6];
                    double rating = double.Parse(data[7]);
                    double attendance = double.Parse(data[8]);
                    string project = "";
                    for (int i = 9; data.Length > i; i++) {
                        project += data[i];
                    }
                    person = new Graduate(last_name, first_Name, age, speciality, group, rating, attendance, project);
                    person.Info();
                }
                
            }
            sr.Close();
        }
    }
}
