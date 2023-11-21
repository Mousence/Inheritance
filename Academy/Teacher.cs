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
        const int SPECIALITY_WIDTH = 20;
        const int EXPERIENCE_WIDTH = 5;
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

        public override void Info() {
            base.Info();
            Console.Write($"{Speciality.PadRight(SPECIALITY_WIDTH)} {Experience.ToString().PadRight(EXPERIENCE_WIDTH)}");
        }
        public override string ToString()
        {
            return base.ToString() + $",{Speciality},{Experience}";
        }
        public override void Init(string[] values)
        {
            base.Init(values);
            Speciality = values[4];
            Experience = Convert.ToInt32(values[5]);
        }
    }
}
