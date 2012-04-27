namespace Calculator.Core.Tests.NotTestFriendly
{
    using System;
    using Core.NotTestFriendly;
    using NUnit.Framework;

    [TestFixture]
    public class WhenUsingACalculator
    {

        Calculator _calulator = new Calculator();

        [Test] 
        public void Adding1And2ShouldEqual3()
        {
            Assert.AreEqual(3,_calulator.Add(1,2));
        }

        [Test]
        public void SubtractingThreeMinusTwoShouldBe1()
        {
            Assert.AreEqual(1, _calulator.Subtract(3, 2));
        }
    }
}