using FigureHelper;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureHelperTests
{
    [TestClass]
    public class FigureTests
    {
        [TestMethod]
        public void GetType_Figure_WhenIFigureObjectGiven()
        {
            var figure = new Figure(new Circle(2));

            figure.GetType().Should().Be(typeof(Figure));
        }

        [TestMethod]
        public void GetSquare_ValidSquare_WhenIFigureObjectGiven()
        {
            var figure = new Figure(new Circle(2));

            figure.GetSquare().Should().Be(12.566370614359172);
        }
    }
}