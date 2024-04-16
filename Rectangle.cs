using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresCalculations
{
    public class Rectangle : Figure
    {
        private double _s;
        private double _p;



        public new double AreaOfTheFigure(double a, double b)
        {
            _s = a * b;
            Console.WriteLine($"Area of the rectangle is {_s}");
            return _s;
        }

        public new double PerimeterOfTheFigure(double a, double b)
        {
            _p = (a + b) * 2;
            Console.WriteLine($"Perimeter of the rectangle is {_p}");
            return _p;
        }
        public new void Calculations(double a, double b)
        {
            Area = AreaOfTheFigure(a,b);
            Perimeter = PerimeterOfTheFigure(a,b);
        }
        public Rectangle(double a, double b)
        {
            Side1 = a;
            Side2 = b;
            Perimeter = _p;
            Area = _s;
        }
    }
}
