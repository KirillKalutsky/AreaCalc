using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    public abstract class Figure : ICalcArea
    {
        public abstract string Name { get; }
        public abstract double CalcArea();
    }
}
