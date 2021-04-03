using Calculator.Models.Calculation.Operations.Base;
using System;

namespace Calculator.Models.Calculation.Operations.ArithmeticOperations
{
    class Sqrt : UnaryOperation
    {
        public Sqrt(UniversalOperation sqrt) : base(sqrt) { }

        public override double Operation()
        {
            return Math.Sqrt(arg.Operation());
        }
    }
    
}
