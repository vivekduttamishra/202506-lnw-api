namespace ConceptArchitect.Calculators
{
    public class CalculatorV4
    {
        public void Calculate(double number1, IOperator oper, double number2)
        {
            oper.Calculate(number1, number2);
        }
    }
}
