using System;
using System.Collections.Generic;
using System.Linq;
using FigureLibrary.Generator;
using FigureLibrary.Abstract;

namespace FigureWinFormsRenderer
{
    class Program
    {
        static void Main(string[] args)
        {
            var figures = FigureGenerator.TestFigures.ToList();
            
            foreach (var figure in figures)
            {
            }

        }
    }
}
