using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.Calculators
{
    public class CalculatorV1
    {
        public void Calculate(double number1, string oper, double number2)
        {
            switch (oper.ToLower())
            {
                case "plus":
                    Console.WriteLine($"{number1} {oper} {number2} = {number1+number2}");
                    break;
                case "minus":
                    Console.WriteLine($"{number1} {oper} {number2} = {number1 - number2}");
                    break;
                case "multiply":
                    Console.WriteLine($"{number1} {oper} {number2} = {number1 * number2}");
                    break;
                default:
                    Console.WriteLine($"Invalid Operator: {oper}");
                    break;
            }
        }
    }
}
