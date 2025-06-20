using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.Calculators
{

    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method)]
    public class ArithmeticOperatorAttribute : Attribute
    {
        public string Name { get; set; } = ""; 
        public string Help { get; set; } = "";
        public String[] Alias { get; set; } = [];


    }
}
