using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.FactoryOne;
using Calculator.FactoryTwo;

namespace Calculator._10
{
    class Sin : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return Math.Sin(first);
        }
    }
}
