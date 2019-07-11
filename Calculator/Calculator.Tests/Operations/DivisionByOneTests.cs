using NUnit.Framework;


namespace Calculator.Tests.Operations
{
    [TestFixture]
    public class DivisionByOneTests
    {
        [TestCase(2, 0.5)]
        [TestCase(6, 0.166)]
        [TestCase(8, 0.125)]
        public void CalculateTest(
            double first,
            double expected)
        {
            var calculator = new Calculator.FactoryTwo.Operations.DivisionByOne();
            var actualResult = calculator.CalculateTwo(first);
            Assert.AreEqual(expected, actualResult, 0.001);
        }

    }
}