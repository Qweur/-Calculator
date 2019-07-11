using Calculator.TwoArgumentsOperations;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsOperations
{
    [TestFixture]
    public class ArcsinTests
    {
        [TestCase(-1, -1.570)]
        [TestCase(0.5, 0.523)]
        [TestCase(1, 1.570)]
        public void CalculateTest(
            double first,
            double expected)
        {
            var calculator = new Arcsin();
            var actualResult = calculator.CalculateTwo(first);
            Assert.AreEqual(expected, actualResult, 0.001);
        }

    }
}