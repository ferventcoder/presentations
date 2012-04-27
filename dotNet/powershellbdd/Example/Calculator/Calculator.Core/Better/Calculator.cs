namespace Calculator.Core.Better
{
    using System.Collections.Generic;

    public class Calculator
    {
        private readonly IEnumerable<IOperator> _operators;

        public Calculator(IEnumerable<IOperator> operators)
        {
            _operators = operators;
        }

        public int PerformOperation(OperationType type, int left, int right)
        {
            int result = left;
            foreach (var @operator in _operators)
            {
                if (@operator.OperationType == type)
                {
                    result = @operator.PerformOperation(result, right);
                }
                // what if we don't find one?
            }

            return result;
        }
    }
}