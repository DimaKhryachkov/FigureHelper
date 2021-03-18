namespace FigureHelper
{
    /// <inheritdoc />
    /// Special class for calculation of square figure without knowing the type of figure
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
