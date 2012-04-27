namespace Calculator.Core.Tests.NotTestFriendly
{
    using NUnit.Framework;
    using Calculator = Calculator.Core.NotTestFriendly.Calculator;

    [TestFixture]
    public class CalculatorTests
    {

        Calculator _calulator = new Calculator();

        [Test] 
        public void TestAddWorks()
        {
            Assert.AreEqual(3,_calulator.Add(1,2));
        }

        [Test]
        public void TestSubtract()
        {
            Assert.AreEqual(1, _calulator.Subtract(3, 2));
        }
    }
}