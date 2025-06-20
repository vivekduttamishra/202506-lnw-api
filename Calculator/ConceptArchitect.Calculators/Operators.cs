using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.Calculators
{
    public interface IOperator
    {
        public double Calculate(double x, double y);
    }

    delegate double Operator(double x, double y);
    //Func<double,double,double>

    public class PlusOperator:IOperator
    {
        public double Calculate(double number1, double number2)
        {
            return number1 + number2;
        }
    }

    public class MinusOperator:IOperator
    {
        public double Calculate(double number1, double number2)
        {
            return number1 - number2;
        }
    }
}
