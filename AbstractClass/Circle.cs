using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Circle:Shape
    {
        public double Radius { get; set; }

        public Circle(double radius) {
            Radius = radius;
            Console.WriteLine("CConstructor:\t" + this.GetHashCode());
        }
        ~Circle() {
            Console.WriteLine("CDestructor:\t" + this.GetHashCode());
        }

        public override double get_perimeter()
        {
            return Radius * 2 * Math.PI;
        }
        public override double get_area()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public void info() {
            Console.WriteLine("Радиус фигуры равен: " + Radius);
            base.info();
        }
    }
}
