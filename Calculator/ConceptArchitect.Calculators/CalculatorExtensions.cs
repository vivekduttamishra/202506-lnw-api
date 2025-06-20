using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.Calculators
{
    public static  class CalculatorExtensions
    {
        public static Calculator AddOperator(this Calculator calc, BinaryOperator oper, string name, params string[] aliasNames)
        {
            calc.AddOperator(new FunctionAdapter(oper), name, aliasNames);
            return calc;
        }

        public static Calculator SetFormatter(this Calculator calc, IOutputFormatter fomatter)
        {
            calc.Formatter = fomatter;
            return calc;
        }

        public static Calculator SetOutputPresenter(this Calculator calc, IResultPresenter presenter)
        {
            calc.OutputPresenter = presenter;
            return calc;
        }

        public static Calculator SetErrorPresenter(this Calculator calc, IResultPresenter presenter)
        {
            calc.ErrorPresenter = presenter;
            return calc;
        }
    }
}
