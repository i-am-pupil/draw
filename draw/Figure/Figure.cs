using System;
namespace Draw
{
    public class Figure : IFigureOne, IFigureTwo
    {
        void IFigureOne.Figure()
        {
            Console.WriteLine("OneFigure");
        }
        void IFigureTwo.Figure()
        {
            Console.WriteLine("TwoFigure");
        }
    }
}
