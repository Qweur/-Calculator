using Calculator.TwoArgumentsOperations;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsOperations
{
    [TestFixture]
    public class LogTwo
    {
        [TestCase(22, 0.045)]
        [TestCase(5, 0.2)]
        [TestCase(36, 0.027)]
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