namespace FigureHelper
{
    public class Figure : IFigure
    {
        private readonly IFigure _figure;

        public double GetSquare() => _figure.GetSquare();

        public Figure(IFigure figure)
        {
            _figure = figure;
        }
    }
}