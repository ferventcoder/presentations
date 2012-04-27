namespace Calculator.Core.Better
{
    using System;

    public class SubtractionOperator : IOperator
    {
        public OperationType OperationType
        {
            get { return OperationType.Subtraction; }
        }

        public int PerformOperation(int left, params int[] right)
        {
            int result = left;
            Array.ForEach(right, item => result = result - item);

            return result;
        }
    }
}