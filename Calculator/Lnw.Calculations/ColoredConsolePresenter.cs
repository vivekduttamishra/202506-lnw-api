using ConceptArchitect.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lnw.Calculations
{
    public class ColoredConsolePresenter : IResultPresenter
    {
        public ConsoleColor Color { get; set; }

        public void Present(object output)
        {
            Console.ForegroundColor = Color;
            Console.WriteLine(output);
            Console.ResetColor();
        }
    }
}
