using Calculator.Models.Calculation.Operations.Base;

namespace Calculator.Models.Calculation.Operations.ArithmeticOperations
{
    class PartOfTheWhole : BinaryOperation
    {
        public PartOfTheWhole(UniversalOperation leftArg, UniversalOperation rightArg) : base(leftArg, rightArg) { }

        public override double Operation()
        {
            return leftArg.Operation() + rightArg.Operation();
        }
    }
}