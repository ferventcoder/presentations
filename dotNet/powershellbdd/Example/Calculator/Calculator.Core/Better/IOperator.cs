namespace Calculator.Core.Better
{
    public interface IOperator
    {
        OperationType OperationType { get; }
        int PerformOperation(int left, params int[] right);
    }
}