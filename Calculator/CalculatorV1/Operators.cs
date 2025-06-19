using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.Calculators
{
    public interface IOperator
    {
        public void Calculate(double x, double y);
    }

    public class PlusOperator:IOperator
    {
        public void Calculate(double number1, double number2)
        {
            Console.WriteLine($"{number1}+{number2}={number1 + number2}");
        }
    }

    public class MinusOperator:IOperator
    {
        public void Calculate(double number1, double number2)
        {
            Console.WriteLine($"{number1}+{number2}={number1 - number2}");
        }
    }
}
