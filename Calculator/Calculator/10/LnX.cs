using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.FactoryTwo;

namespace Calculator._10
{
    class LnX : IOneArgumentsCalculator
    {
        public double CalculateTwo(double first)
        {
            return Math.Log(first,Math.E);
        }
    }
}
