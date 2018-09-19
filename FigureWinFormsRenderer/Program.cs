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
            var figures = FigureGenerator.TestFigures.ToList();
            var draw = new Draw();
            foreach (var figure in figures)
            {
                draw.Drawing(figure);
            }

        }
    }
}
