
using System.Diagnostics;
using System.Numerics;

namespace ConceptArchitect.Calculators

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestCalculatorOperations(calculator);

            Calculator calculator=new Calculator();

            if (args.Length == 0)
                RunShell(calculator);
            else
                RunCommandLine(calculator, args);


        }

        static void TestCalculatorV4()
        {
            var calc = new CalculatorV4();
            calc.Calculate(20, new PlusOperator(), 30);
            calc.Calculate(20, new MinusOperator(), 30);
            //calc.Calculate(20, "multiply", 30);

            //calc.Calculate(20, new MultiplyOperator(), 40);
        }

        private static void RunCommandLine(Calculator calculator, string[] args)
        {
            var operation = args[0].ToLower();
            if(operation == "help")
            {
                Console.WriteLine("plus, minus, multiply, help, exit");
                return;
            }else if(operation == "exit")
            {
                throw new TerminateApplicationException();
            }
            else if (args.Length < 3)
            {
                Console.WriteLine("Insufficient Arguments");
                return;
            }
            
            var number1 = double.Parse(args[1]);
            var number2 = double.Parse(args[2]);

            calculator.Calculate(number1, operation, number2);


        }

        private static void RunShell(Calculator calculator)
        {
            try
            {

                while (true)
                {
                    Console.Write("> ");
                    string command = Console.ReadLine();
                    string[] args = command.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                    //Console.WriteLine(args.Length);

                    RunCommandLine(calculator, args);
                }
            }catch(TerminateApplicationException ex)
            {
                //application terminated
                Console.WriteLine("Thanks for using the Calculator");
            }
        }

        private static void RunApp(string[] args)
        {
            throw new NotImplementedException();
        }

        private static void TestCalculatorOperations()
        {
            var calculator = new Calculator();
            calculator.Calculate(20, "plus", 30);
            calculator.Calculate(40, "minus", 2);
            calculator.Calculate(50, "foo", 4);
        }
    }
}
