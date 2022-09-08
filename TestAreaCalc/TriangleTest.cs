using NUnit.Framework;
using AreaCalculation;
using FluentAssertions;
using System;

namespace TestAreaCalc
{
    public class TriangleTest
    {
        [TestCase(5, 3, 4, 6)]
        [TestCase(10.56, 0.5, 11.005, 1.228)]
        public void CalculateAreaTest(double a, double b, double c, double result)
        {
            var triangle = new Triangle(a, b, c);

            triangle.CalcArea().Should().BeApproximately(result, 0.001);
        }

        [TestCase(8, 3, 4)]
        [TestCase(1, 2, 3.001)]
        public void NotTriangleTest(double a, double b, double c)
        {
            Action act = () => new Triangle(a, b, c);

            act.Should().Throw<ArgumentException>()
                .WithMessage("Стороны не образуют треугольник");
        }

        [TestCase(-1, 3, 4)]
        [TestCase(0, 1, 2)]
        [TestCase(-1, 0, 4)]
        [TestCase(2, 1, -3)]
        public void WrondTriangleSideTest(double a, double b, double c)
        {
            Action act = () => new Triangle(a, b, c);

            act.Should().Throw<ArgumentException>()
                .WithMessage("Длина - число положительное");
        }

        [TestCase(5, 3, 4, true)]
        [TestCase(5, 4, 4, false)]
        public void RectangularTriangleTest(double a, double b, double c, bool result)
        {
            var triangle = new Triangle(a, b, c);

            triangle.IsRectangular().Should().Be(result);
        }
    }
}