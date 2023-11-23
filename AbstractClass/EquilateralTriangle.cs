using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class EquilateralTriangle:Triangle
    {
        public double A { get; set; }
        public double B { get; set; }

        public double C;
        public double get_C()
        {
            return Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
        }

        public EquilateralTriangle(double a, double b)
        {
            A = a;
            B = b;
            C = Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));

            Console.WriteLine("ETConstructor:\t" + this.GetHashCode());
        }
        ~EquilateralTriangle()
        {
            Console.WriteLine("ETDestructor:\t" + this.GetHashCode());
        }

        public override double get_height()
        {
            return A;
        }
        public override double get_area()
        {
            return (A*B)/2;
        }
        public override double get_perimeter()
        {
            return A + B + C;
        }

        public void info() {
            Console.WriteLine("Гипотенуза прямоугольного треугольника равна: " + C);
            base.info();
        }
    }
}
