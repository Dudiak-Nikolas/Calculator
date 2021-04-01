using Calculator.Models.Calculation.Operations.Base;

namespace Calculator.Models.Calculation.Operations.ArithmeticOperations
{
    class ModuleDivision : BinaryOperation
    {
        public ModuleDivision(UniversalOperation leftArg, UniversalOperation rightArg) : base(leftArg, rightArg) { }

        public override double Operation()
        {
            return (double)leftArg.Operation() % (double)rightArg.Operation();
        }
    }
}