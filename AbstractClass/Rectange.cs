using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Rectange:Shape
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Rectange(double x, double y) { 
            X = x;
            Y = y;
            Console.WriteLine("RConstructor:\t" + this.GetHashCode());
        }
        ~Rectange() {
            Console.WriteLine("RDestructor:\t" + this.GetHashCode());
        }

        public override double get_perimeter() {
            return (X + Y) * 2;
        }
        public override double get_area()
        {
            return X * Y;
        }

        public void info() {
            Console.WriteLine("Длина стороны X:" + X);
            Console.WriteLine("Длина стороны Y:" + Y);
            base.info();
        }
    }
}
