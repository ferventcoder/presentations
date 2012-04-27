namespace Calculator.Core.Better
{
    using System;

    public class AdditionOperator : IOperator
    {
        public OperationType OperationType
        {
            get { return OperationType.Addition; }
        }

        public int PerformOperation(int left, params int[] right)
        {
            int result = left;
            if (right != null && right.Length > 0)
            {
                Array.ForEach(right, item => result = result + item);
            }
            
            return result;
        }
    }
}