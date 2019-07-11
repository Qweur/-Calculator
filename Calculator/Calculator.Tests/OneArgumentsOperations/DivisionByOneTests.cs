using Calculator.OneArgumentsOperations;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentsOperations
{
    [TestFixture]
    public class DivisionByOneTests
    {
        [TestCase(2, 0.5)]
        [TestCase(6, 0.166)]
        [TestCase(8, 0.125)]
        public void CalculateTest(
            double first,
            double expected)
        {
            var calculator = new DivisionByOne();
            var actualResult = calculator.CalculateTwo(first);
            Assert.AreEqual(expected, actualResult, 0.001);
        }

    }
}