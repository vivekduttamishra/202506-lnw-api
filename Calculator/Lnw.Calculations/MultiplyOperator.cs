using ConceptArchitect.Calculators;

namespace Lnw.Calculations
{
    public class MultiplyOperator : IOperator
    {
        public double Calculate(double x, double y)
        {
            //Console.WriteLine($"{x} * {y} = {x * y}");
            return x * y;
        }

       
    }
}
