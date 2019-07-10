using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.FactoryOne;
using Calculator.FactoryTwo;

namespace Calculator.FactoryTwo.Operations
{
    class Sin : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return Math.Sin(first);
        }
    }
}
