using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLibrary.Generator;

namespace FigureHtmlRenderer
{
    class Program
    {
        static void Main(string[] args)
        {
            var htmlRenderer = new HtmlRenderer();
            var renderer = new FigureHtmlRenderer(htmlRenderer);

            var figures = FigureGenerator.TestFigures.ToList();

            foreach (var figure in figures)
            {
                // renderer.Render((dynamic)figure); // неправильно!
                figure.Render(renderer);
            }
        }
    }
}
