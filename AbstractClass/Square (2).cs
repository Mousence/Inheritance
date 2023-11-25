using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Square:Shape
    {
        public double X { get; set; }

        public Square(double x, int start_x, int start_y, int line_width, Color color) 
            : base( start_x,  start_y,  line_width, color) 
        {
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
        public override void draw()
        { }
            public void info() {
            Console.WriteLine("Длина стороны: " + X);
            base.info();
        }
    }
}
