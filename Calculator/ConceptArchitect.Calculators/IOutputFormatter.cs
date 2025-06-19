using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.Calculators
{
    public  interface IOutputFormatter
    {
        string Format(string operation, double number1, double number2, double result);
    }

    public class InfixFormatter : IOutputFormatter
    {
        public string Format(string operation, double number1, double number2, double result)
        {
            return $"{number1} {operation} {number2} = {result}";
        }
    }

    public class RawFormatter : IOutputFormatter
    {
        public string Format(string operation, double number1, double number2, double result)
        {
            return result.ToString();
        }
    }
}
