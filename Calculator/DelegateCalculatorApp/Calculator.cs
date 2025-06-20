namespace ConceptArchitect.Calculators
{

    public delegate double BinaryOperator(double x, double y);
    public delegate string OutputFormatter(string operatorName, double n1, double n2, double result);
    public delegate void ResultPresenter(object output);

    public class Formatters
    {
        public static string Infix(string name, double n1, double n2, double r)
        {
            return $"{n1} {name} {n2} = {r}";
        }

        public static string Raw(string name, double n1, double n2, double r)
        {
            return $"{r}";
        }
    }

    public class DelegateCalculator
    {

        class BasicMath
        {
            public static double Plus(double x, double y) { return x + y; }
            public static double Minus(double x, double y) { return x - y; }
        }



        Dictionary<string,BinaryOperator> operators= new Dictionary<string,BinaryOperator>();
        public OutputFormatter Formatter { get; set; }
        public ResultPresenter OutputPresenter { get; set; }
        public ResultPresenter ErrorPresenter { get; set; }
        public DelegateCalculator()
        {
            operators.Add("plus", BasicMath.Plus);
            operators.Add("minus", BasicMath.Minus);
            Formatter = Formatters.Infix;
            OutputPresenter = Console.WriteLine;
            ErrorPresenter = Console.WriteLine;
        }
        public void AddOperator( BinaryOperator oper, string name=null)
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
                var result= oper(number1, number2);
                var output = Formatter(operatorName, number1, number2, result);
                OutputPresenter(output);
            }
            else
            {
                //Console.WriteLine($"Invalid Operator: {operatorName}");
                ErrorPresenter($"Invalid Operator: {operatorName}");
            }
        }
    }
}
