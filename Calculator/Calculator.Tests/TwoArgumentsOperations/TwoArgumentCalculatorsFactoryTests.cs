using System;
using Calculator.TwoArgumentsOperations;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsOperations
{
    [TestFixture]
    public class TwoArgumentCalculatorsFactoryTests
    {
        [TestCase("Addition", typeof(Addition))]
        [TestCase("Subtraction", typeof(Subtraction))]
        [TestCase("Multiplication", typeof(Multiplication))]
        [TestCase("Division", typeof(Division))]
        [TestCase("Logarithms", typeof(Logarithms))]
        [TestCase("RemainderOfTheDivision", typeof(RemainderOfTheDivision))]
        [TestCase("Max", typeof(Max))]
        [TestCase("GeometricMean", typeof(GeometricMean))]
        [TestCase("Min", typeof(Min))]
        [TestCase("Average", typeof(Average))]
        [TestCase("Exponentiation", typeof(Exponentiation))]
        [TestCase("Root", typeof(Root))]
        public void CreateCalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentCalculatorsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);

        }
    }
}