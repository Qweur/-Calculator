using NUnit.Framework;

namespace Calculator.Tests.Operations
{
    [TestFixture]
    public class LogarithmsTests
    {
        [TestCase(2, 3, 0.631)]
        [TestCase(6, 3, 1.631)]
        [TestCase(8, 12, 0.837)]
        public void CalculateTest(
            double first,
            double second,
            double expected)
        {
            var calculator = new Calculator.FactoryOne.Operations.Logarithms();
            var actualResult = calculator.Calculate(first, second);
            Assert.AreEqual(expected, actualResult,0.001);
        }

    }
}