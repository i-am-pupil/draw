using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLibrary.Concrete;

namespace FigureWinFormsRenderer
{
    public class Draw {
        public void Drawing(Circle circle) {
            var renderer = new WinFormsRenderer();
            renderer.Circle(circle.Center.X, circle.Center.Y, circle.Radius);
        }
    public void Drawing(Rectangle rectangle) {
            var renderer = new WinFormsRenderer();
            renderer.Line(rectangle.BottomRightCorner.X, rectangle.BottomRightCorner.Y, rectangle.UpperLeftCorner.X, rectangle.UpperLeftCorner.Y);
        }
     }
}
