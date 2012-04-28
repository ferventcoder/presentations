namespace Calculator.Core.Tests.NotTestFriendly
{
    using Core.NotTestFriendly;
    using Should;

    public class CalculatorSpecs
    {
        public abstract class CalculatorSpecsBase : TinySpec
        {
            public Calculator _calulator; 

            public override void Context()
            {
                _calulator = new Calculator();
            }
        }

        public class when_using_a_calculator_to_perform_operations : CalculatorSpecsBase
        {
            public override void Because(){}

            [Fact]
            public void should_add_one_and_two_to_equal_three()
            {
                _calulator.Add(1, 2).ShouldEqual(3);
            }

            [Fact]
            public void should_subtract_three_and_two_to_equal_one()
            {
                 _calulator.Subtract(3, 2).ShouldEqual(1);
            }
        }
    }
}