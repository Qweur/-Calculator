using NUnit.Framework;

namespace Calculator.Tests.Operations
{
    [TestFixture]

   public class ExponentTests
    {
        [TestCase(8, 2980)]
        [TestCase(-4, 0.018)]
        [TestCase(16, 8886110)]

        public void CalculateTest(
double first,
double expected)
        {
            var calculator = new Calculator.FactoryTwo.Operations.Exponent();
            var actualResult = calculator.CalculateTwo(first);
            Assert.AreEqual((int) expected, (int) actualResult);
        }
    }
}
