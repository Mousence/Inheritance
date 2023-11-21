using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Academy
{
    internal class Teacher:Human
    {
        public string Speciality { get; set; }
        public int Experience { get; set; }

        public Teacher(
            string last_name, string first_name, int age,
            string speciality, int experience
            ) : base(last_name, first_name, age)
        {
            Speciality = speciality;
            Experience = experience;
            Console.WriteLine("TConstructor:\t"+this.GetHashCode());
        }
        ~Teacher()
        {
            Console.WriteLine("TDestructor:\t" + this.GetHashCode());
        }

        public void Info() {
            base.Info();
            Console.WriteLine($"{Speciality} {Experience} лет");
        }
        public override string ToString()
        {
            return base.ToString() + $" {Speciality} {Experience} лет";
        }
    }
}
