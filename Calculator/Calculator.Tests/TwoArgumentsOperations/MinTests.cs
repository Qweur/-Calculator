using Calculator.TwoArgumentsOperations;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsOperations
{
    [TestFixture]
    public class MinTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 3)]
        [TestCase(-7, -2, -7)]
        public void CalculateTest(
            double first,
            double second,
            double expected)
        {
            var calculator = new Min();
            var actualResult = calculator.Calculate(first, second);
            Assert.AreEqual(expected, actualResult);
        }

    }
}
