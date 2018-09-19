using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLibrary.Abstract;
using FigureLibrary.Common;

namespace FigureLibrary.Concrete
{
    public class Circle : AbstractFigure
    {
        public Point Center { get; }
        public double Radius { get; }

        public Circle(Point center, double radius)
        {
            Debug.Assert(radius > 0d);
            Center = center;
            Radius = radius;
        }

        public override double Area => Math.PI * Radius * Radius;
        public override double Width => Radius * 2d;
        public override double Height => Radius * 2d;
    }
}
