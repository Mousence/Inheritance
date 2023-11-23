using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Square:Shape
    {
        public double X { get; set; }

        public Square(double x) {
            X = x;
            Console.WriteLine("SConstructor:\t" + this.GetHashCode());
        }
        ~Square() {
            Console.WriteLine("SDestructor:\t" + this.GetHashCode());
        }
        public override double get_perimeter() {
            return X * 4;
        }
        public override double get_area()
        {
            return X * X;
        }
        public void info() {
            Console.WriteLine("Длина стороны: " + X);
            base.info();
        }
    }
}
