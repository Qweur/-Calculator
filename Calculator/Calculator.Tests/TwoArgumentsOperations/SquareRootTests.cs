using Calculator.TwoArgumentsOperations;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsOperations
{
    [TestFixture]
    public class SquareRootTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new SquareRoot();
            var actual = calculator.CalculateTwo(36);

            Assert.AreEqual(1296, actual, 0.25);
        }
    }
}
