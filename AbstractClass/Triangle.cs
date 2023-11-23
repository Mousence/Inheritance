using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Triangle:Shape
    {
        public abstract double get_height();

        public Triangle() { }
        ~Triangle() { }

        public void info() {
            Console.WriteLine("Высота фигуры: " + get_height());
            base.info();
        }
    }
}
