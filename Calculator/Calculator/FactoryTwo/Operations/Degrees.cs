using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.FactoryTwo.Operations
{
    class Degrees : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return first * 180 / Math.PI;
        }
    }
}
