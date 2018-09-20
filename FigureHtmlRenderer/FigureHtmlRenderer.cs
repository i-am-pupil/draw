using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLibrary.Abstract;
using FigureLibrary.Concrete;

namespace FigureHtmlRenderer
{
    public class FigureHtmlRenderer : IRenderer
    {
        private readonly HtmlRenderer _htmlRenderer;

        public FigureHtmlRenderer(HtmlRenderer renderer)
        {
            _htmlRenderer = renderer;
        }

        public void Render(AbstractFigure figure)
        {
            throw new NotImplementedException();
        }

        public void Render(Circle circle)
        {
            _htmlRenderer.DrawCircle(circle.Center.X, circle.Center.Y, circle.Radius);
        }

        public void Render(Rectangle rectangle)
        {
            _htmlRenderer.DrawLine(rectangle.UpperLeftCorner.X, rectangle.BottomRightCorner.Y, rectangle.UpperLeftCorner.X, rectangle.UpperLeftCorner.Y);
            _htmlRenderer.DrawLine(rectangle.BottomRightCorner.X, rectangle.BottomRightCorner.Y, rectangle.BottomRightCorner.X, rectangle.UpperLeftCorner.Y);
            _htmlRenderer.DrawLine(rectangle.UpperLeftCorner.X, rectangle.BottomRightCorner.Y, rectangle.BottomRightCorner.X, rectangle.BottomRightCorner.Y);
            _htmlRenderer.DrawLine(rectangle.UpperLeftCorner.X, rectangle.UpperLeftCorner.Y, rectangle.BottomRightCorner.X, rectangle.UpperLeftCorner.Y);
        }
    }
}
