namespace Calculator.Core.NotTestFriendly
{
    public class Calculator
    {
        public int Add(int left, int right)
        {
            return left + right;
        }

        public int Subtract(int left, int right)
        {
            return left - right;
        }

    }

    //public class Calculator
    //{
    //    private AddtionOperator _additionOperator;
    //    private SubtractionOperator _subtractionOperator;

    //    public Calculator()
    //    {
    //        _additionOperator = new AddtionOperator();
    //        _subtractionOperator = new SubtractionOperator();
    //    }

    //    public int Add(int left, int right)
    //    {
    //        return _additionOperator.Add(left, right);
    //    }

    //    public int Subtract(int left, int right)
    //    {
    //        return _subtractionOperator.Subtract(left, right);
    //    }

    //}
}