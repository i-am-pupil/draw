﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLibrary.Abstract;
using FigureLibrary.Common;
using FigureLibrary.Concrete;
using FigureLibrary.Container;

namespace FigureLibrary.Generator
{
    public static class FigureGenerator
    {
        public static IEnumerable<IFigure<AbstractFigure>> TestFigure
        {
            get
            {
                yield return new Figure<Circle>(new Circle(new Point(0d, 0d), 20d));
                yield return new Figure<Circle>(new Circle(new Point(0d, 20d), 20d));
                yield return new Figure<Circle>(new Circle(new Point(20d, 0d), 20d));
                yield return new Figure<Rectangle>(new Rectangle(new Point(0d, 100d), new Point(100, 0d)));
            }
        }
    }
}
