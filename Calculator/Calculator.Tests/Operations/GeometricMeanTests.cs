using NUnit.Framework;

namespace Calculator.Tests.Operations
{
    [TestFixture]
    public class GeometricMeanTests
    {
        [TestCase(5, 9, 6.708)]
        [TestCase(20, 90, 42.426)]
        [TestCase(8, 12, 9.797)]
        public void CalculateTest(
            double first,
            double second,
            double expected)
        {
            var calculator = new Calculator.FactoryOne.Operations.GeometricMean();
            var actualResult = calculator.Calculate(first, second);
            Assert.AreEqual(expected, actualResult, 0.001);
        }

    }
}