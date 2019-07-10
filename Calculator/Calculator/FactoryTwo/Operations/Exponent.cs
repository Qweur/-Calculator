using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.FactoryTwo.Operations
{
    class Exponent : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return Math.Exp(first);
        }
    }
}
