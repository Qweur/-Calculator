using Calculator.TwoArgumentsOperations;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsOperations
{
    [TestFixture]
    public class SinTests
    {
        [TestCase(-6, 0.279)]
        [TestCase(30,-0.988)]
        [TestCase(1, 0.841)]
        public void CalculateTest(
            double first,
            double expected)
        {
            var calculator = new Sin();
            var actualResult = calculator.CalculateTwo(first);
            Assert.AreEqual(expected, actualResult, 0.001);
        }

    }
}