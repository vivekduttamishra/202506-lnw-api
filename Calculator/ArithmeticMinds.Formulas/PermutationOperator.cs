using ConceptArchitect.Calculators;

namespace ArithmeticMinds.Formulas
{
    [ArithmeticOperator(Name = "permutation", Alias = ["per", "p"], Help = "Calculates Permutation")]
    public class PermutationOperator : IOperator
    {
        
        
        public double Calculate(double n, double r)
        {
            return MathFormulas.Factorial((int)n) / MathFormulas.Factorial((int)(n - r));
        }
    }
}
