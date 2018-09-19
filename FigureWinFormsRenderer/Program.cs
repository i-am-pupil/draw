using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLibrary.Generator;

namespace FigureWinFormsRenderer
{
    class Program
    {
        static void Main(string[] args)
        {
            var renderer = new WinFormsRenderer();
            var figures = FigureGenerator.TestFigures.ToList();

            foreach (var figure in figures)
            {
                // draw the figures!
                renderer.Line(0d, 0d, 1d, 1d);
            }

        }
    }
}
