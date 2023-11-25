using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AbstractClass
{
    class Square:Rectange
    {
        public Square(double x, int start_x, int start_y, int line_width, Color color) 
            : base(x, x, start_x,  start_y,  line_width, color)
        {
        }
        ~Square() {}
    }
}
