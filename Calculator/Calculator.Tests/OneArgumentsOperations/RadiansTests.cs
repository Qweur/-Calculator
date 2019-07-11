using Calculator.OneArgumentsOperations;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentsOperations
{
    [TestFixture]
   public class RadiansTests
    {
        [TestCase(401, 6)]
        [TestCase(-171, -2)]
        [TestCase(8, 0.15)]

        public void CalculateTest(
double first,
double expected)
        {
            var calculator = new Radians();
            var actualResult = calculator.CalculateTwo(first);
            Assert.AreEqual((int)expected, (int)actualResult);
        }
    }
}
