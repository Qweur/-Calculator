using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.FactoryTwo;

namespace Calculator._10
{
    class DivisionByOne : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return  1 / first;
        }
    }
}
