using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Human(string last_name, string first_name, int age) {
            LastName = last_name;
            FirstName = first_name;
            Age = age;
            Console.WriteLine("HConstructor:" + this.GetHashCode());
        }
        public Human(Human other) { 
            this.LastName = other.LastName;
            this.FirstName = other.FirstName;
            this.Age = other.Age;
            Console.WriteLine("HCopyConstructor:"+this.GetHashCode());
        }
        ~Human() {
            Console.WriteLine("HDestructor:" + this.GetHashCode());
        }

        public void Info(){
            Console.WriteLine($"{LastName} {FirstName} {Age} лет");
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName} {Age} лет";
        }
    }
}
