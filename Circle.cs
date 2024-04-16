using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresCalculations
{
    public class Circle : Figure
    {
        private double _s;
        private double _p;
        public Circle(double r)
        {
            Radius = r;
            Perimeter = _p;
            Area = _s;
        }
        public new double PerimeterOfTheFigure(double r)
        {
            _p = 2 * Math.PI * r;
            Console.WriteLine($"Perimeter of the circle is {_p}");
            return _p;
        }
        public new double AreaOfTheFigure(double r)
        {
            _s = Math.PI * r * r;
            Console.WriteLine($"Area of the circle is {_s}");
            return _s;
        }
        public new void Calculations(double r)
        {
            Area = AreaOfTheFigure(r);
            Perimeter = PerimeterOfTheFigure(r);
        }
    }
}
