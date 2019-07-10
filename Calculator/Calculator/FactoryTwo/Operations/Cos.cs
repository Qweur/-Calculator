using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.FactoryTwo.Operations
{
    class Cos : IOneArgumentsCalculator
    {
    public double CalculateTwo(double first)
    {
        return Math.Cos(first);
    }
    }
}
