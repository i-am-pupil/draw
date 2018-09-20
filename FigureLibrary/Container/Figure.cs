using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLibrary.Concrete;

namespace FigureLibrary.Container
{
    public class Figure<T> : IFigure<T>
    {
        T _figure;
        public Figure(T value)
        {
            _figure = value;
        }
        public T GetFigure { get => _figure; }
    }
}
