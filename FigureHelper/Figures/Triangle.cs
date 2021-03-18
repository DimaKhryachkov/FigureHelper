using System;
using System.Collections.Generic;
using System.Linq;

namespace FigureHelper
{
    public class Triangle : IFigure
    {
        public double FirstSide { get; }

        public double SecondSide { get; }

        public double ThirdSide { get; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0)
            {
                throw new ArgumentException($"{nameof(firstSide)} can't be zero or below");
            }

            if (secondSide <= 0)
            {
                throw new ArgumentException($"{nameof(secondSide)} can't be zero or below");
            }

            if (thirdSide <= 0)
            {
                throw new ArgumentException($"{nameof(thirdSide)} can't be zero or below");
            }

            if ((!(firstSide + secondSide > thirdSide)) || 
                (!(firstSide + thirdSide > secondSide)) ||
                (!(secondSide + thirdSide > firstSide)))
            {
                throw new ArgumentException($"{nameof(Triangle)} with such sides does not exist");
            }

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public double GetSquare()
        {
            var halfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - FirstSide) * (halfPerimeter - SecondSide) * (halfPerimeter - ThirdSide));
        }

        public bool IsRight()
        {
            var maxSide = new List<double> { FirstSide, SecondSide, ThirdSide }.Max();

            return 2 * maxSide * maxSide == FirstSide * FirstSide + SecondSide * SecondSide + ThirdSide * ThirdSide;
        }
    }
}