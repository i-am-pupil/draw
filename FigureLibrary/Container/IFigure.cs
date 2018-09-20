using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Container
{
    public interface IFigure<out T>
    {
        T GetFigure { get; }
    }
}
