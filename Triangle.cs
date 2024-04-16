using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresCalculations
{
    public class Triangle: Figure
    {
        private double _s;
        private double _p;
        public Triangle (double a, double b, double c)
        {
            Side1 = a;
            Side2 = b;
            Side3 = c;
            Perimeter =_p;
            Area = _s;
        }
        public new double PerimeterOfTheFigure(double a, double b, double c)
        {
            _p = a + b + c;
            Console.WriteLine($"Perimeter of the triangle is {_p}");
            return _p;
        }
        public new double AreaOfTheFigure(double a, double b, double c)
        {
            _p = a + b + c;
            _s = Math.Sqrt(_p * (_p - a) * (_p - b) * (_p - c));
            Console.WriteLine($"Area of the triangle is {_s}");
            return _s;
        }

        public new void Calculations(double a, double b, double c)
        {
            Area = AreaOfTheFigure(a, b,c);
            Perimeter = PerimeterOfTheFigure(a, b,c);
        }

    }
}
