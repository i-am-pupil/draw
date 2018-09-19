using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLibrary.IFigure;//тут не хочет 

namespace FigureLibrary.Abstract
{
    using FigureLibrary.IFigure; //тут хочет магия
    public abstract class AbstractFigure:IFigure
    {
        public abstract double Area { get; }
        public abstract double Width { get; }
        public abstract double Height { get; }

        public abstract object GetFigure();
    }
}
