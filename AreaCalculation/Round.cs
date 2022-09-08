using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    public class Round : Figure
    {
        public Round(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус - величина неотрицательная");
            Radius = radius;
        }

        public double Radius { get; }

        public override string Name => "Круг";

        public override double CalcArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
