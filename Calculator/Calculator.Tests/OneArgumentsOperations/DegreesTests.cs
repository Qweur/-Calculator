using Calculator.OneArgumentsOperations;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentsOperations
{
    [TestFixture]

    public class DegreesTests
    {
        [TestCase(7, 401)]
        [TestCase(-3, -171)]
        [TestCase(0.15, 8)]

        public void CalculateTest(
double first,
double expected)
        {
            var calculator = new Degrees();
            var actualResult = calculator.CalculateTwo(first);
            Assert.AreEqual((int)expected, (int)actualResult);
        }
    }
}
