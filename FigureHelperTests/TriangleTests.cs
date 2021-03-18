using System;
using FigureHelper;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureHelperTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        [DataRow(0, 2, 3)]
        [DataRow(1, 0, 3)]
        [DataRow(1, 2, 0)]
        [DataRow(-1, 2, 3)]
        [DataRow(1, -2, 3)]
        [DataRow(1, 2, -3)]
        [DataRow(1, 2, 3)]
        public void CreateTriangle_ThrowArgumentException_WhenNotValidSidesGiven(double firstSide, double secondSide, double thirdSide)
        {
            Action act = () => new Triangle(firstSide, secondSide, thirdSide);

            act.Should().Throw<ArgumentException>();
        }

        [TestMethod]
        [DataRow(2, 4, 4, 3.872983346207417)]
        [DataRow(2, 4.62, 4.3, 4.2904516125927818)]
        public void GetSquare_ValidSquare_WhenValidSidesGiven(double firstSide, double secondSide, double thirdSide, double expectedSquare)
        {
            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            triangle.GetSquare().Should().Be(expectedSquare);
        }

        [TestMethod]
        [DataRow(3, 4, 5)]
        [DataRow(5, 12, 13)]
        public void IsRight_True_WhenRightTriangleGiven(double firstSide, double secondSide, double thirdSide)
        {
            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            triangle.IsRight().Should().Be(true);
        }

        [TestMethod]
        [DataRow(2, 4, 4)]
        [DataRow(3, 6, 5.15)]
        public void IsRight_False_WhenNotRightTriangleGiven(double firstSide, double secondSide, double thirdSide)
        {
            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            triangle.IsRight().Should().Be(false);
        }
    }
}