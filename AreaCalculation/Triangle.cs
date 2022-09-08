using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    public class Triangle : Figure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Длина - число положительное");
            if (a > b + c || b > a + c || c > a + b)
                throw new ArgumentException("Стороны не образуют треугольник");
            A = a;
            B = b; 
            C = c;
        }

        public override string Name =>
            "Треугольник";

        public override double CalcArea()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRectangular()
        {
            return A * A == B * B + C * C ||
                B * B == A * A + C * C ||
                C * C == B * B + A * A;
        }
    }
}
