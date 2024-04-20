using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresCalculations
{
    public class Figure
    {
        public double Side1 { get; set; }

        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public double Radius { get; set; }

        public double Perimeter { get; set; }
        public double Area { get; set; }
        double _p;
        double _s;


        public abstract class AreaOfTheFigure()
        {
        }

        public abstract class PerimeterOfTheFigure()
        {
        }

        public abstract class Calculations()
        {
        }

    }
}
