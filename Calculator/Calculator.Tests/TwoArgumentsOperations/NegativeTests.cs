using Calculator.TwoArgumentsOperations;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsOperations
{
    [TestFixture]

    public class NegativeTests
    {
        [TestCase(-3, 3)]
        [TestCase(2, -2)]
        [TestCase(16, -16)]

        public void CalculateTest(
double first,
double expected)
        {
            var calculator = new Negative();
            var actualResult = calculator.CalculateTwo(first);
            Assert.AreEqual((int)expected, (int)actualResult);
        }
    }
}
