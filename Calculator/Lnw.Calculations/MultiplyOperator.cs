using ConceptArchitect.Calculators;

namespace Lnw.Calculations
{
    [ArithmeticOperator(Alias = ["into","product"], Help ="Multiplies two number to get the result")]
    public class MultiplyOperator : IOperator
    {
        public double Calculate(double x, double y)
        {
            //Console.WriteLine($"{x} * {y} = {x * y}");
            return x * y;
        }

       
    }
}
