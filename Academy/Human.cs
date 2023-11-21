using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Human
    {
        const int LAST_NAME_WIDTH = 10;
        const int FIRST_NAME_WIDTH = 10;
        const int AGE_WIDTH = 5;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Human(string last_name, string first_name, int age) {
            LastName = last_name;
            FirstName = first_name;
            Age = age;
            Console.WriteLine("HConstructor:\t" + this.GetHashCode());
        }
        public Human(Human other) { 
            this.LastName = other.LastName;
            this.FirstName = other.FirstName;
            this.Age = other.Age;
            Console.WriteLine("HCopyConstructor:\t" + this.GetHashCode());
        }
        ~Human() {
            Console.WriteLine("HDestructor:\t" + this.GetHashCode());
        }

        public virtual void Info(){
            Console.Write($"{LastName.PadRight(LAST_NAME_WIDTH)} {FirstName.PadRight(FIRST_NAME_WIDTH)} {Age.ToString().PadRight(AGE_WIDTH)}");
        }

        public override string ToString()
        {
            return $"{LastName},{FirstName},{Age}";
        }
        public virtual void Init(string[] values) {
            LastName = values[1];
            FirstName = values[2];
            Age = Convert.ToInt32(values[3]);
        }
    }
}
