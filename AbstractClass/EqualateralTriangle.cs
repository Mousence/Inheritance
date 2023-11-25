using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace AbstractClass
{
    internal class EqualateralTriangle:Triangle
    {
        double side;

        public double Side
        {
            get { return side; }
            set { 
                if(value < MIN_LENGTH) value = MIN_LENGTH;
                if (value > MAX_LENGTH) value = MAX_LENGTH;
                side = value;
            }
        }
        public EqualateralTriangle(double side, int start_x, int start_y, int line_width, Color color)
            : base(start_x, start_y, line_width, color) { Side = side; }
        ~EqualateralTriangle() { }
        public override double get_height()
        {
            return Math.Sqrt(Math.Pow(Side, 2) - Math.Pow(Side / 2, 2));
        }
        public override double get_perimeter()
        {
            return Side * 3;
        }
        public override double get_area()
        {
            return Math.Pow(get_height(), 2) * Math.Sqrt(3);
        }
        public override void draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            Point[] points = new Point[] 
            {
                new Point(StartX, StartY),
                new Point(StartX+(int)Side, StartY+(int)Side),
                new Point(StartX + (int)Side/2, StartY + (int)Side - (int)get_height())
            };
            e.Graphics.DrawPolygon(pen, points);
        }

        public override void info(PaintEventArgs e)
        {
            base.info(e);
            draw(e);
        }
    }
}
