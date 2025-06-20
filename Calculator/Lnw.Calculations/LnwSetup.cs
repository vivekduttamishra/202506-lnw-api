using ConceptArchitect.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lnw.Calculations
{
    public static class LnwSetup
    {
        public static Calculator AddLnwOperators(this Calculator calc)
        {
            calc.AddOperator(new MultiplyOperator(),"multiply");
            calc.AddOperator(new DivideOperator().Calculate, "divide");
            return calc;
        }
    }
}
