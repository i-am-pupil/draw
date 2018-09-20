using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureHtmlRenderer
{
    public class HtmlRenderer
    {
        public void DrawLine(double x0, double y0, double x1, double y1)
        {
            Console.WriteLine($"HTML: Drawing line: ({x0:0.00},{y0:0.00}) → ({x1:0.00},{y1:0.00})");
        }

        public void DrawCircle(double x, double y, double r)
        {
            Console.WriteLine($"HTML: Drawing circle: ({x:0.00},{y:0.00}), r = {r:0.00}");
        }

    }
}
