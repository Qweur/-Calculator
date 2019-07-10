using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.FactoryOne;

namespace Calculator._10
{
    class RemainderOfTheDivision : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first % second;
        }
    }
}
