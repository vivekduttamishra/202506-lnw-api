using ConceptArchitect.Calculators;
using Lnw.Calculations;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var calculator = new Calculator();
            //TestCalculator(calc);

            //calculator.AddOperator(new MultiplyOperator(),"multiply");
            //calculator.AddOperator(new DivideOperator(), "divide");
            //calculator.AddOperator(new FunctionAdapter(new DivideOperator().Calculate), "divide");


            //calculator.AddOperator(Math.Pow, "power");

            //calculator.AddOperator(new FunctionAdapter(Math.Pow), "power");

            //calculator
            //    .AddOperator(Math.Pow, "power")
            //    .AddLnwOperators()
            //    .AddOperator((x, y) => x % y, "mod")
            //    .AddOperator((x, y) => (x + y) / (x - y), "custom")

            var calculator = new CalculatorBuilder()
                                .Build()
                                .SetOutputPresenter(new ColoredConsolePresenter()
                                {
                                    Color = ConsoleColor.Yellow
                                })
                                .SetErrorPresenter(new ColoredConsolePresenter()
                                {
                                    Color = ConsoleColor.Red
                                });

            if (args.Length == 0)
                RunShell(calculator);
            else
                RunCommandLine(calculator, args);

        }


        private static void RunCommandLine(Calculator calculator, string[] args)
        {
            var operation = args[0].ToLower();
            if (operation == "help")
            {
                GenerateHelp(calculator,args);
                return;
            }
            else if (operation == "exit")
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

        private static void GenerateHelp(Calculator calculator, string[]args)
        {
            if (args.Length == 1)
            {
               foreach (var opr in calculator.Operators)
                    Console.Write(opr + ", ");
                Console.WriteLine("help, exit");
            }else
            {
                var command = args[1];
                Console.WriteLine($"About: {command}");
                Console.Write($"Alias: ");
                foreach (var alias in calculator.GetAlias(command))
                    Console.Write(alias + "\t");
                Console.WriteLine();
                Console.WriteLine(calculator.GetHelp(command));
            }
        }

        private static void RunShell(Calculator calculator)
        {
            try
            {

                while (true)
                {
                    Console.Write("> ");
                    string command = Console.ReadLine();
                    string[] args = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    //Console.WriteLine(args.Length);

                    RunCommandLine(calculator, args);
                }
            }
            catch (TerminateApplicationException ex)
            {
                //application terminated
                Console.WriteLine("Thanks for using the Calculator");
            }
        }

        private static void TestCalculator(Calculator calc)
        {
            calc.Calculate(20, "plus", 30);
            calc.Calculate(20, "minus", 30);
            calc.Calculate(20, "multiply", 30);
        }
    }
}
/*
 
> new PlusOperator() 20 30

*/