using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractClass
{
    internal class Circle:Shape
    {
        public int Radius
        {
            get { return Radius; }
            set
            {
                if (value < MIN_LENGTH) value = MIN_LENGTH;
                if (value > MAX_LENGTH) value = MAX_LENGTH;
                Radius = value;
            }
        }
        public Circle(int radius, int start_x, int start_y, int line_width, Color color)
            : base(start_x, start_y, line_width, color)
        {
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
        public override void draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            e.Graphics.DrawEllipse(pen, StartX, StartY, LineWidth, Radius);
        }
        public override void info(PaintEventArgs e) {
            Console.WriteLine("Радиус фигуры равен: " + Radius);
            base.info(e);
        }
    }
}
