using System;
using FigureHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace FigureHelperTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        [DataRow(0)]
        [DataRow(-10)]
        [DataRow(-20.58)]
        public void CreateCircle_ThrowArgumentException_WhenNotValidRadiusGiven(double radius)
        {
            Action act = () => new Circle(radius);

            act.Should().Throw<ArgumentException>();
        }

        [TestMethod]
        [DataRow(2, 12.566370614359172)]
        [DataRow(2.58, 20.9116973393551)]
        public void GetSquare_ValidSquare_WhenValidRadiusGiven(double radius, double expectedSquare)
        {
            var circle = new Circle(radius);

            circle.GetSquare().Should().Be(expectedSquare);
        }
    }
}
