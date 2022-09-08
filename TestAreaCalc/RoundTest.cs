using AreaCalculation;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace TestAreaCalc
{
    public class RoundTest
    {
        [TestCase(0,0)]
        [TestCase(2, 12.566)]
        public void CalculateRoundAreaTest(double radius, double result)
        {
            var triangle = new Round(radius);
            triangle.CalcArea().Should().BeApproximately(result, 0.001);
        }

        [Test]
        public void NegativeRadiusTest()
        {
            Action act = () => new Round(-1);
            act.Should().Throw<ArgumentException>()
                .WithMessage("Радиус - величина неотрицательная");
        }
    }
}
