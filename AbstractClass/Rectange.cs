using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractClass
{
    internal class Rectange : Shape
    {
        double width;
        double height;
        public double Width
        {
            get { return width; }
            set
            {
                if (value < MIN_LENGTH) value = MIN_LENGTH;
                if (value > MAX_LENGTH) value = MAX_LENGTH;
                width = value;
            }
        }


        public double Height
        {
            get { return height; }
            set
            {
                if (value < MIN_LENGTH) value = MIN_LENGTH;
                if (value > MAX_LENGTH) value = MAX_LENGTH;
                height = value;
            }
        }

        public Rectange(double x, double y, int start_x, int start_y, int line_width, Color color)
            : base(start_x, start_y, line_width, color)
        {
            Width = x;
            Height = y;
        }
        ~Rectange() { }

        public override double get_perimeter()
        {
            return (Width + Height) * 2;
        }
        public override double get_area()
        {
            return Width * Height;
        }
        public override void draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            e.Graphics.DrawRectangle(pen, StartX, StartY, (int)Width, (int)Height);
        }
        public override void info(PaintEventArgs e)
        {
            Console.WriteLine("Ширина:" + Width);
            Console.WriteLine("Высота:" + Height);
        }
    }
}
