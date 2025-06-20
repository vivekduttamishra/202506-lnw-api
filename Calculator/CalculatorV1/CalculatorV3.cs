using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.Calculators
{
    public class Calculator
    {
        public void Calculate(double number1, string oper, double number2)
        {
            double result = double.NaN;

            if (oper == "plus")
                result = number1 + number2;
            else if (oper == "minus")
                result = number1 - number2;
            else if (oper == "multiply")
                result = number1 * number2;
            else if(oper=="divide")
                result= number1 / number2;
            else
                result = double.NaN;


            if (double.IsNaN(result))
                Console.WriteLine($"Invalid operator: {oper}");
            else

                Console.WriteLine($"{number1} {oper} {number2} = {result}");
        }
    }
}
//20 plus 30 = 50 ====>   plus(20,30) = 50   or 50