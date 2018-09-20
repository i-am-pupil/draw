using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLibrary.Generator;
using FigureLibrary.Concrete;
using FigureLibrary.Container;
using FigureLibrary.Abstract;

namespace FigureWinFormsRenderer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFigure<AbstractFigure>> figures = FigureGenerator.TestFigure.ToList();
            var draw = new Draw();
            foreach (var figure in figures)
            {
                var figa = figure.GetFigure;
                //draw.Drawing(figa);
                Console.WriteLine(figure.GetFigure);
            }

        }
    }
}
