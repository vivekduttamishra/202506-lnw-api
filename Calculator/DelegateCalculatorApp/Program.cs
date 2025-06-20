using ConceptArchitect.Calculators;

namespace DelegateCalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new DelegateCalculator();

            TestCalculator(calc,"Default Calculator");

            calc.OutputPresenter = (output) =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(output);
                Console.ResetColor();
            };
            calc.ErrorPresenter = (output) =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(output);
                Console.ResetColor();
            };

            TestCalculator(calc, "With Custome Presenter");

            //adding the power operator
            calc.AddOperator(Math.Pow, "power");
            TestCalculator(calc, "After adding power operator");
        }

        private static void TestCalculator(DelegateCalculator calc, string testName)
        {
            Console.WriteLine(testName);
            calc.Calculate(20, "plus", 30);
            calc.Calculate(20, "minus", 30);
            calc.Calculate(20, "power", 3);
            Console.WriteLine("-------------\n\n");
        }
    }
}
