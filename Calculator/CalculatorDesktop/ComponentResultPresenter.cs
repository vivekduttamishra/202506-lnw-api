using ConceptArchitect.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDesktop
{
    internal class ComponentResultPresenter : IResultPresenter
    {
        public Control  Target { get; set; }
        public void Present(object output)
        {
            Target.Text= output.ToString();
        }
    }
}
