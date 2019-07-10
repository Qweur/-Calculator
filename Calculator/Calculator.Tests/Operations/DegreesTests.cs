using NUnit.Framework;

namespace Calculator.Tests.Operations
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
            var calculator = new Calculator.FactoryTwo.Operations.Degrees();
            var actualResult = calculator.CalculateTwo(first);
            Assert.AreEqual((int)expected,(int) actualResult);
        }
    }
}
