using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.FactoryTwo;

namespace Calculator.FactoryTwo.Operations
{
    class CTan : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return 1/ Math.Tan(first);
        }
    }
}
