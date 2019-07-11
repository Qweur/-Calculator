using Calculator.TwoArgumentsOperations;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsOperations
{
    [TestFixture]
    public class MaxTests
    {
        [TestCase(51, 50, 51)]
        [TestCase(8, 20, 20)]
        [TestCase(8, 12, 12)]
        public void CalculateTest(
            double first,
            double second,
            double expected)
        {
            var calculator = new Max();
            var actualResult = calculator.Calculate(first, second);
            Assert.AreEqual(expected, actualResult, 0.001);
        }

    }
}
