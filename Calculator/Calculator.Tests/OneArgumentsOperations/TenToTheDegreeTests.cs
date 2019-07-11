using Calculator.OneArgumentsOperations;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentsOperations
{
    [TestFixture]

    public class TenToTheDegreeTests
    {
        [TestCase(-3, 0.001)]
        [TestCase(2, 100)]
        [TestCase(0, 1)]

        public void CalculateTest(
double first,
double expected)
        {
            var calculator = new TenToTheDegree();
            var actualResult = calculator.CalculateTwo(first);
            Assert.AreEqual((int)expected, (int)actualResult);
        }
    }
}
