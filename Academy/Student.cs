using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Student:Human
    {
        const int SPECIALITY_WIDTH = 20;
        const int GROUP_WIDTH = 8;
        const int RATING_WIDTH = 6;
        const int ATTENDANCE_WIDTH = 6;
        public string Speciality { get; set; }
        public string Group { get; set; }
        public double Rating { get; set; }
        public double Attendance { get; set; }

        public Student
            (
            string last_name, string first_name, int age,
            string speciality, string group, double rating, double attendance
            ) : base(last_name, first_name, age)
        {
            Speciality = speciality;
            Group = group;
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine("SConstructor:\t"+this.GetHashCode());
        }
        public Student(
            Human human,
            string speciality, string group, double rating, double attendance
            ) : base(human)
        {
            Speciality = speciality;
            Group = group;
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine("SConstructor:\t" + this.GetHashCode());
        }
        public Student(Student other):base(other) {
            this.Speciality = other.Speciality;
            this.Group = other.Group;
            this.Rating = other.Rating;
            this.Attendance = other.Attendance;
            Console.WriteLine("SCopyConstructor:\t" + this.GetHashCode());
        }
        ~Student() {
            Console.WriteLine("SDestructor:\t" + this.GetHashCode());
        }

        public override void Info() {
            base.Info();
            Console.Write($"{Speciality.PadRight(SPECIALITY_WIDTH)} {Group.PadRight(GROUP_WIDTH)} {Rating.ToString().PadRight(RATING_WIDTH)} {Attendance.ToString().PadRight(ATTENDANCE_WIDTH)}");
        }

        public override string ToString()
        {
            return base.ToString() + $",{Speciality},{Group},{Rating},{Attendance}";
        }
        public override void Init(string[] values)
        {
            base.Init(values);
            Speciality = values[4];
            Group = values[5];
            Rating = Convert.ToInt32(values[6]);
            Attendance = Convert.ToInt32(values[7]);
        }
    }
}
