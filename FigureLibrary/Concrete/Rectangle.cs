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
    public class Rectangle : AbstractFigure
    {
        public Point UpperLeftCorner { get; }
        public Point BottomRightCorner { get; }

        public Rectangle(Point upperLeftCorner, Point bottomRightCorner)
        {
            Debug.Assert(upperLeftCorner.Y > bottomRightCorner.Y);
            Debug.Assert(bottomRightCorner.X > upperLeftCorner.X);
            UpperLeftCorner = upperLeftCorner;
            BottomRightCorner = bottomRightCorner;
        }
        public override object GetFigure()
        {
            return this.MemberwiseClone();
        }
        public override double Area => Width * Height;
        public override double Width => BottomRightCorner.X - UpperLeftCorner.X;
        public override double Height => BottomRightCorner.Y - UpperLeftCorner.Y;
    }
}
