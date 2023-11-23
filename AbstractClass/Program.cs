using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(5);
            square.info();
            Console.WriteLine();
            Rectange rectange = new Rectange(5,4);
            rectange.info();
            Console.WriteLine();
            Circle circle = new Circle(10);
            circle.info();
            Console.WriteLine();
            EquilateralTriangle triangle = new EquilateralTriangle(5,4);
            triangle.info();
            Console.WriteLine();
        }
    }
}
