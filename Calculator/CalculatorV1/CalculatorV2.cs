using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.Calculators
{
    public class CalculatorV2
    {
        public void Calculate(double number1, string oper, double number2)
        {
            double result = double.NaN;
            switch (oper.ToLower())
            {
                case "plus":
                    result = number1 + number2;
                    break;
                case "minus":
                    result = number1 - number2;
                    break;
                case "multiply":
                    result = number1 * number2;
                    break;
                default:
                    break;
            }

            if (result == double.NaN)
                Console.WriteLine($"Invalid operator: {oper}");
            else

                Console.WriteLine($"{number1} {oper} {number2} = {result}");
        }
    }
}
//20 plus 30 = 50 ====>   plus(20,30) = 50   or 50