namespace Calculator.Core.Tests.Better
{
    using Core.Better;
    using Should;

    public class AdditionOperatorSpecs
    {
        public abstract class AdditionOperatorSpecsBase : TinySpec
        {
            public AdditionOperator _additionOperator;

            public override void Context()
            {
                _additionOperator = new AdditionOperator();
            }
        }

        public class when_using_AdditionOperator_to_add_two_numbers_together : AdditionOperatorSpecsBase
        {
            private int left = 1;
            private int right = 2;
            private const int expectedResult = 3;
            private int result;

            public override void Because()
            {
                result = _additionOperator.PerformOperation(left, right);
            }

            [Fact]
            public void should_add_one_and_two_to_equal_three()
            {
                result.ShouldEqual(expectedResult);
            }
        }

        public class when_using_AdditionOperator_to_add_two_three_together : AdditionOperatorSpecsBase
        {
            private int left = 1;
            private int right = 2;
            private int third = 3;
            private const int expectedResult = 6;
            private int result;

            public override void Because()
            {
                result = _additionOperator.PerformOperation(left, right, third);
            }

            [Fact]
            public void should_add_one_two_and_three_to_equal_six()
            {
                result.ShouldEqual(expectedResult);
            }
        }

        public class when_using_AdditionOperator_to_add_a_number_and_null_together : AdditionOperatorSpecsBase
        {
            private int left = 1;
            private const int expectedResult = 1;
            private int result;

            public override void Because()
            {
                result = _additionOperator.PerformOperation(left, null);
            }

            [Fact]
            public void should_add_1_and_null_to_equal_1()
            {
                result.ShouldEqual(expectedResult);
            }
        }

        public class when_using_AdditionOperator_to_add_a_number_and_0_together : AdditionOperatorSpecsBase
        {
            private int left = 1;
            private const int expectedResult = 1;
            private int result;

            public override void Because()
            {
                result = _additionOperator.PerformOperation(left, 0);
            }

            [Fact]
            public void should_add_1_and_0_to_equal_1()
            {
                result.ShouldEqual(expectedResult);
            }
        }
    }
}