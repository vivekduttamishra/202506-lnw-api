using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.Calculators
{
    public class CalculatorBuilder
    {
        public Calculator Build()
        {
            var calc= new Calculator();

            //step#1 find location of plugin folder
            var pluginPath= $"{AppDomain.CurrentDomain.BaseDirectory}\\plugins";

            if (!Directory.Exists(pluginPath))
                return calc;

            //step#2 find out all dll files present in plugins
            foreach (var dll in Directory.GetFiles(pluginPath, "*.dll"))
            {
                try
                {
                    //step #3 load Assembly in memory.
                    var assembly = Assembly.LoadFile(dll);
                    AddPlugins(calc, assembly);

                }catch(Exception ex)
                { 
                    //ignore not found elements.
                }

            }



            return calc;
        }

        private void AddPlugins(Calculator calc, Assembly assembly)
        {
            var operatorInterfaceType = typeof(IOperator);

            //find all the types present in the Assembly
            foreach (var type in assembly.GetTypes())
            {
                //make sure they are non-abstract classes and implment IOperator

                if (type.IsClass    //should be a class
                    && !type.IsAbstract //should not be abstract
                    && operatorInterfaceType.IsAssignableFrom(type) //should be subclass of IOperator
                    )
                {
                    AddOperator(calc, type);
                }
                else if (type.IsClass)
                {
                    AddOperatorFunctions(calc, type);
                }

            }
        }

        private void AddOperatorFunctions(Calculator calc, Type type)
        {

            foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Static))
            {
                if (!typeof(double).IsAssignableFrom(method.ReturnType))
                    continue;
                
                var parameters = method.GetParameters();
                if (parameters.Length != 2)
                    continue;

                if (!typeof(double).IsAssignableFrom(parameters[0].ParameterType))
                    continue;

                if (!typeof(double).IsAssignableFrom(parameters[1].ParameterType))
                    continue;

                //this is a valid operator method
                AddFunctionOperator(calc, method);
            }

        }

        private void AddFunctionOperator(Calculator calc, MethodInfo method)
        {
            var _operatorDelegate = Delegate.CreateDelegate(typeof(BinaryOperator), method) as BinaryOperator;
            var _operator = new FunctionAdapter(_operatorDelegate);
            var _operatorName = method.Name;
            string[] alias = { };
            string help = "";


            var info = method.GetCustomAttribute(typeof(ArithmeticOperatorAttribute)) as ArithmeticOperatorAttribute;
            if (info != null)
            {
                if (!string.IsNullOrEmpty(info.Name))
                    _operatorName = info.Name;
                alias = info.Alias;
                help = info.Help;
            }


            calc.AddOperator(_operator, _operatorName, alias);
            calc.AddHelp(_operatorName, help);

        }

        private void AddOperator(Calculator calc, Type type)
        {
            //create the object of this type.
            try
            {
                var _operator = Activator.CreateInstance(type) as IOperator;
                var _operatorName = type.Name.Replace("Operator", "").ToLower();
                string[] alias = { };
                string help = "";

                var info = type.GetCustomAttribute(typeof(ArithmeticOperatorAttribute)) as ArithmeticOperatorAttribute;
                if (info != null)
                {
                    if (!string.IsNullOrEmpty(info.Name))
                        _operatorName = info.Name;
                    alias= info.Alias;
                    help= info.Help;
                }


                calc.AddOperator(_operator, _operatorName, alias);
                calc.AddHelp(_operatorName, help);
            }catch(Exception ex)
            {
                //ignore the error for now.
            }
            
        }
    }
}
