using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsOperations
{
    [TestFixture]
    public class MultiplicationTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Calculator.TwoArgumentsOperations.Multiplication();
            var actual = calculator.Calculate(10, 5);

            Assert.AreEqual(50, actual, 0.01);
        }
    }
}

