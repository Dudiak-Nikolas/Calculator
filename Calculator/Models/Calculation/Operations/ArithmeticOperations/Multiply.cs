using Calculator.Models.Calculation.Operations.Base;

namespace Calculator.Models.Calculation.Operations.ArithmeticOperations
{
    /// <summary>
    /// For Multiply numbers
    /// </summary>
    public class Multiply : BinaryOperation
    {
        public Multiply(UniversalOperation leftArg, UniversalOperation rightArg) : base(leftArg, rightArg) { }

        public override double Operation()
        {
            return leftArg.Operation() * rightArg.Operation();
        }
    }
}
    
   