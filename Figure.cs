using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresCalculations
{
    public abstract class Figure
    {
        public double Side1 { get; set; }

        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public double Radius { get; set; }

        public double Perimeter { get; set; }
        public double Area { get; set; }
        double _p;
        double _s;


        public virtual void AreaOfTheFigure()
        {
            Console.WriteLine("some basic Area calculation");
            _p = 0;
        }

        public virtual void PerimeterOfTheFigure()
        {
            Console.WriteLine("Some basic Perimeter calculation");
            _s = 0;
        }

        public virtual void Calculations()
        {
            AreaOfTheFigure();
            PerimeterOfTheFigure();
        }

    }
}
