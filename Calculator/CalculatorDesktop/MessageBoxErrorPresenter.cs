using ConceptArchitect.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDesktop
{
    internal class MessageBoxErrorPresenter : IResultPresenter
    {
        public void Present(object output)
        {
            MessageBox.Show(output.ToString(), "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
