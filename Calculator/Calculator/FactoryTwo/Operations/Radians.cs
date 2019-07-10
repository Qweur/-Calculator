using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.FactoryTwo.Operations
{
    class Radians : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return first * Math.PI / 180;
        }
    }
}
