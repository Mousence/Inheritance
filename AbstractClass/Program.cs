using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntPtr hwnd = GetConsoleWindow();
            Graphics graphics = Graphics.FromHwnd(hwnd);
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle
                (Console.WindowLeft, Console.WindowTop,
                Console.WindowWidth, Console.WindowHeight);
            PaintEventArgs e = new PaintEventArgs(graphics, rectangle);

            Rectange rect = new Rectange(200,150,700,50, 2, Color.AliceBlue);
            rect.info(e);

            Square square = new Square(50, 300, 300, 2, Color.Red);
            square.info(e);

            EqualateralTriangle equalateralTriange = new EqualateralTriangle(250, 700, 50, 3, Color.Green);
            equalateralTriange.info(e);

            Circle circle = new Circle(200, 350, 350, 5, Color.Aqua);
            circle.info(e);

            EquilateralTriangle equilateralTriangle = new EquilateralTriangle(300,200, 400, 400, 3, Color.Azure);
            equilateralTriangle.info(e);
        }
        [DllImport("kernel32.dll")] 
        public static extern IntPtr GetConsoleWindow();
    }
}
