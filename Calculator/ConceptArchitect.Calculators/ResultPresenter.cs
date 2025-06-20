using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.Calculators
{
    public interface IResultPresenter
    {
        public void Present(object output);
    }

    //Action<object>

    public class ConsoleResultPresenter : IResultPresenter
    {
        public void Present(object output)
        {
            Console.WriteLine(output);
        }
    }

}
