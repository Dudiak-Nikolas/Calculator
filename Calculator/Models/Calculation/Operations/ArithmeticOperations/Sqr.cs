using Calculator.Models.Calculation.Operations.Base;
using System;

namespace Calculator.Models.Calculation.Operations.ArithmeticOperations
{
    public class Sqr : UnaryOperation
    {
        public Sqr(UniversalOperation sqr) : base(sqr) { }

        public override double Operation()
        {
            return Math.Pow(arg.Operation(),2);
        }
    }
}
