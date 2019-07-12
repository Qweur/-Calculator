using Calculator.TwoArgumentsOperations;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsOperations
{
    [TestFixture]
    public class AdditionTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Addition();
            var actual = calculator.Calculate(3, 2);

            Assert.AreEqual(5, actual, 0.01);
        }
    }
}
