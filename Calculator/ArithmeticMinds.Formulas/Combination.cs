using ConceptArchitect.Calculators;

namespace ArithmeticMinds.Formulas
{
    public class CombinationOperator : IOperator
    {
        public double Calculate(double n, double r)
        {
            return MathFormulas.Factorial((int)n) / MathFormulas.Factorial((int)(n - r))/MathFormulas.Factorial((int)r);
        }
    }
}
