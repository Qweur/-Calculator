using System;
using Calculator.OneArgumentsOperations;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentsOperations
{
    [TestFixture]
    public class FactoryTests
    {
        [TestCase("Addition", typeof(Addition))]
        [TestCase("Subtraction", typeof(Subtraction))]
        [TestCase("Multiplication", typeof(Calculator.OneArgumentsOperations.Multiplication))]
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
            var calculator = Factory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);

        }
    }
}