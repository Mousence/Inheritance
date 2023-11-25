using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractClass
{
    abstract class Triangle:Shape
    {
        public abstract double get_height();

        public Triangle(int start_x, int start_y, int line_width, Color color) 
            : base(start_x, start_y, line_width, color)  { }
        ~Triangle() { }

        public override void info(PaintEventArgs e) {
            Console.WriteLine("Высота Треугольника: " + get_height());
            base.info(e);
        }
    }
}
