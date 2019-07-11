using Calculator.OneArgumentsOperations;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentsOperations
{
    [TestFixture]
    public class DivisionTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Division();
            var actual = calculator.Calculate(10, 5);

            Assert.AreEqual(2, actual, 0.01);
        }
    }
}