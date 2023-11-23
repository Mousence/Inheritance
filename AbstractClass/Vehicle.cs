using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Shape
    {
        public abstract double get_perimeter();
        public abstract double get_area();

        public Shape() { }
        ~Shape() {}
        public void info() {
            Console.WriteLine("Площадь фигуры: " + get_area());
            Console.WriteLine("Периметр фигуры: " + get_perimeter());
        }
    }
}
