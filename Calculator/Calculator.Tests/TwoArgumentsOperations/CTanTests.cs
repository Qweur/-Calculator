using Calculator.TwoArgumentsOperations;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsOperations
{
    [TestFixture]
    public class CTanTests
    {
        [TestCase(60, 3.124)]
        [TestCase(-5, 0.295)]
        [TestCase(17, 0.286)]
        public void CalculateTest(
            double first,
            double expected)
        {
            var calculator = new CTan();
            var actualResult = calculator.CalculateTwo(first);
            Assert.AreEqual(expected, actualResult, 0.001);
        }

    }
}