namespace ConceptArchitect.Calculators
{
    public class Calculator
    {
        Dictionary<string,IOperator> operators= new Dictionary<string,IOperator>();

        public Calculator()
        {
            operators.Add("plus", new PlusOperator());
            operators.Add("minus", new MinusOperator());
        }
        public void AddOperator(string name, IOperator oper)
        {
            operators[name.ToLower()] = oper;
        }

        public IEnumerable<String> Operators
        {
            get
            {
                return operators.Keys;
            }
        }
        public void Calculate(double number1, string operatorName, double number2)
        {
            operatorName=operatorName.ToLower();
            if (operators.ContainsKey(operatorName))
            {
                var oper = operators[operatorName];
                oper.Calculate(number1, number2);
            }
            else
            {
                Console.WriteLine($"Invalid Operator: {operatorName}");
            }
        }
    }
}
