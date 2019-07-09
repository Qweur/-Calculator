using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public class Factory
    {
        public static ITwoArgumentsCalculator Calculate(string name)
        {

            switch (name)
            {
                case "Addition":
                    return new Addition();

                case "Subtraction":
                    return new Subtraction();

                case "Multiplication":
                    return new Multiplication();

                case "Division":
                    return new Division();

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
