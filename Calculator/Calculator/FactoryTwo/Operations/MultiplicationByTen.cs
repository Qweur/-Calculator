using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.FactoryTwo.Operations
{
    class MultiplicationByTen : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return 1 / first;
        }
    }
}
