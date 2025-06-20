using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.Calculators
{
    public delegate double BinaryOperator(double x, double y);

    public class FunctionAdapter : IOperator
    {
        BinaryOperator target;

        public FunctionAdapter(BinaryOperator target)
        {
            this.target = target;
        }
        public double Calculate(double x, double y)
        {
            return target(x, y);
        }
    }
}
