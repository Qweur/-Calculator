using NUnit.Framework;
namespace Calculator.Tests.Operations
{
    [TestFixture]

    public class MinTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 3)]
        [TestCase(-7, -2, -7)]

        public void CalculateTest(
    double first,
    double second,
    double expected)
        {
            var calculator = new Calculator.FactoryOne.Operations.Min();
            var actualResult = calculator.Calculate(first, second);
            Assert.AreEqual(expected, actualResult);
        }

    }
}
