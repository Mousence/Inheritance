using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractClass
{
    internal class EquilateralTriangle:Triangle
    {
        public double A
        {
            get { return A; }
            set
            {
                if (value < MIN_LENGTH) value = MIN_LENGTH;
                if (value > MAX_LENGTH) value = MAX_LENGTH;
                A = value;
            }
        }
        public double B
        {
            get { return B; }
            set
            {
                if (value < MIN_LENGTH) value = MIN_LENGTH;
                if (value > MAX_LENGTH) value = MAX_LENGTH;
                B = value;
            }
        }

        public double C;
        public double get_C()
        {
            return Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
        }

        public EquilateralTriangle(double a, double b, int start_x, int start_y, int line_width, Color color)
            : base(start_x, start_y, line_width, color)
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
        public override void draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            Point[] points = new Point[]
            {
                new Point(StartX, StartY),
                new Point(StartX+(int)A, StartY+(int)B),
                new Point(StartX, StartY + (int)A)
            };
            e.Graphics.DrawPolygon(pen, points);
        }
        public override void info(PaintEventArgs e) {
            Console.WriteLine("Гипотенуза прямоугольного треугольника равна: " + C);
            base.info(e);
        }
    }
}
