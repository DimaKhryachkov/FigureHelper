using System;

namespace FigureHelper
{
    public class Circle : IFigure
    {
        public double Radius { get; }

        public double GetSquare() => Math.PI * Radius * Radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException($"{nameof(radius)} can't be zero or below");
            }

            Radius = radius;
        }
    }
}