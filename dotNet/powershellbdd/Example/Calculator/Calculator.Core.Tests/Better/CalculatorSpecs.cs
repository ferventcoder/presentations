namespace Calculator.Core.Tests.Better
{
    using System.Collections.Generic;
    using Core.Better;
    using Moq;
    using Should;

    public class CalculatorSpecs
    {
        public abstract class CalculatorSpecsBase : TinySpec
        {
            public Calculator _calulator;
            public Mock<IOperator> _operation;


            public override void Context()
            {
                _operation = new Mock<IOperator>();
                _calulator = new Calculator(new List<IOperator> { _operation.Object });
            }
        }

        public class when_using_a_calculator_to_perform_operations_and_the_operator_is_loaded : CalculatorSpecsBase
        {
            private int left = 1;
            private int right = 2;
            private const int expectedResult = 3;
            private int result = 0;

            public override void Context()
            {
                base.Context();
                _operation.Setup(x => x.OperationType).Returns(OperationType.Addition);
                _operation.Setup(x => x.PerformOperation(It.IsAny<int>(), It.IsAny<int>())).Returns(3);
                //adf
            }

            public override void Because()
            {
                result = _calulator.PerformOperation(OperationType.Addition, left, right);
            }

            [Fact]
            public void should_add_one_and_two_to_equal_three()
            {
                result.ShouldEqual(expectedResult);
            }

            [Fact]
            public void should_find_the_proper_operation()
            {
                _operation.Verify(x => x.OperationType);
            }

            [Fact]
            public void should_perform_an_operation_call_on_the_operation_type()
            {
                _operation.Verify(x => x.PerformOperation(left, right));
            }

        }    
        
        public class when_using_a_calculator_to_perform_operations_and_the_operator_is_not_loaded : CalculatorSpecsBase
        {
            private int left = 1;
            private int right = 2;
            private int result = 0;

            public override void Context()
            {
                base.Context();
                _operation.Setup(x => x.OperationType).Returns(OperationType.Addition);
                //_operation.Setup(x => x.PerformOperation(It.IsAny<int>(), It.IsAny<int>())).Returns(3);
                //adf
            }

            public override void Because()
            {
                result = _calulator.PerformOperation(OperationType.Subtraction, left, right);
            }

            [Fact]
            public void should_only_return_the_first_number_passed_in()
            {
                result.ShouldEqual(left);
            }

            [Fact]
            public void should_find_the_proper_operation()
            {
                _operation.Verify(x => x.OperationType);
            }

            [Fact]
            public void should_not_perform_an_operation_call_on_the_operation_type()
            {
                _operation.Verify(x => x.PerformOperation(left, right),Times.Never());
            }

        }
    }
}
