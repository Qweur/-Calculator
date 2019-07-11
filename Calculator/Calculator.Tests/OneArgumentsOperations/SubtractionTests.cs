using Calculator.OneArgumentsOperations;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentsOperations
{
    [TestFixture]
    public class SubtractionTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Subtraction();
            var actual = calculator.Calculate(10, 5);

            Assert.AreEqual(5, actual, 0.01);
        }
    }
}
