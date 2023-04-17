
namespace labor9
{
    class ABSException : ArgumentException
    {
        public double Value { get; }
        public int Value1 { get; }
        public ABSException(string message, double val,int val1)
            : base(message)
        {
            Value = val;
            Value1 = val1;
        }
    }
    class IntervalException : ArgumentException
    {
        public double Value { get; }
        public int Value1 { get; }
        public IntervalException(string message, double val, int val1)
            : base(message)
        {
            Value = val;
            Value1 = val1;
        }
    }
}
