namespace ConceptArchitect.Calculators
{

    public class Calculator
    {

      

        Dictionary<string,IOperator> operators= new Dictionary<string,IOperator>();
        Dictionary<string, string[]> alias= new Dictionary<string, string[]>();
        
        public IOutputFormatter Formatter { get; set; }
        public IResultPresenter OutputPresenter { get; set; }
        public IResultPresenter ErrorPresenter { get; set; }
        public Calculator()
        {
            //operators.Add("plus", new PlusOperator());
            //operators.Add("minus", new MinusOperator());

            AddOperator(new PlusOperator(), "plus", "add", "sum");
            AddOperator(new MinusOperator(), "minus", "substract", "sub");

            Formatter = new InfixFormatter();
            OutputPresenter = new ConsoleResultPresenter();
            ErrorPresenter = OutputPresenter;
        }

        public Calculator AddOperator(IOperator oper, string name, params string []aliasNames)
        {

            operators[name.ToLower()] = oper;
            _operators.Add(name);
            alias.Add(name, aliasNames);
            foreach(var aliasName in aliasNames)  
                operators[aliasName.ToLower()] = oper;

            return this;
        }

    

        List<String> _operators= new List<String>();
        public IEnumerable<String> Operators
        {
            get
            {
                return _operators;
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

        Dictionary<string, string> _help=new Dictionary<string, string>();

        public void AddHelp(string operatorName, string help)
        {
            operatorName= operatorName.ToLower();
            if(operators.ContainsKey(operatorName))
                _help.Add(operatorName, help);
        }

        public string GetHelp(string operatorName)
        {
            operatorName = operatorName.ToLower();
            if (_help.ContainsKey(operatorName))
                return _help[operatorName];
            else
                return $"calculate {operatorName}";
        }

        public string[] GetAlias(string operatorName)
        {
            return alias[operatorName];
        }
        
    }
}
