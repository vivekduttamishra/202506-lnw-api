namespace ConceptArchitect.Calculators
{
    public class Calculator
    {
        Dictionary<string,IOperator> operators= new Dictionary<string,IOperator>();
        public IOutputFormatter Formatter { get; set; }
        public IResultPresenter OutputPresenter { get; set; }
        public IResultPresenter ErrorPresenter { get; set; }
        public Calculator()
        {
            operators.Add("plus", new PlusOperator());
            operators.Add("minus", new MinusOperator());
            Formatter = new InfixFormatter();
            OutputPresenter = new ConsoleResultPresenter();
            ErrorPresenter = OutputPresenter;
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
                var result= oper.Calculate(number1, number2);
                var output = Formatter.Format(operatorName, number1, number2, result);
                OutputPresenter.Present(output);
            }
            else
            {
                //Console.WriteLine($"Invalid Operator: {operatorName}");
                ErrorPresenter.Present($"Invalid Operator: {operatorName}");
            }
        }
    }
}
