using NUnit.Framework;

namespace Calculator.Tests.Operations
{
    [TestFixture]

    public class CosTests
    {
        [TestCase(0, 1)]
        [TestCase(6,0.960)]
        [TestCase(-3, -0.989)]

        public void CalculateTest(
double first,
double expected)
        {
            var calculator = new Calculator.FactoryTwo.Operations.Cos();
            var actualResult = calculator.CalculateTwo(first);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}
