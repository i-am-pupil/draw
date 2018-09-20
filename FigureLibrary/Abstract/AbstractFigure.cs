using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Abstract
{
    public abstract class AbstractFigure
    {
        public abstract void Render(IRenderer renderer);
        public abstract double Area { get; }
        public abstract double Width { get; }
        public abstract double Height { get; }
    }
}
