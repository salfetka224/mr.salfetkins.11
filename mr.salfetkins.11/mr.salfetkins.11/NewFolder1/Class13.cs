public class Expression
{
    public class ArithmeticExpression
    {
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }
        public string Operator { get; set; }
    }

    public class LogicalExpression
    {
        public bool Operand1 { get; set; }
        public bool Operand2 { get; set; }
        public string Operator { get; set; }
    }
}