using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLibrary.Concrete;

namespace FigureLibrary.Abstract
{
    public interface IRenderer
    {
        void Render(AbstractFigure figure);
        void Render(Circle circle);
        void Render(Rectangle rectangle);
    }
}
