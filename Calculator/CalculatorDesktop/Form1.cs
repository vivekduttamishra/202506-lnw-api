using ConceptArchitect.Calculators;
using Lnw.Calculations;

namespace CalculatorDesktop
{
    public partial class Form1 : Form
    {
        Calculator calc = new Calculator();

        public Form1()
        {
            InitializeComponent();
            calc.OutputPresenter = new ComponentResultPresenter() 
            { 
                Target = resultLabel 
            };
            calc.ErrorPresenter = new MessageBoxErrorPresenter();
            //calc.AddOperator(new MultiplyOperator(),"multiply");
            //calc.AddOperator(new FunctionAdapter(new DivideOperator().Calculate), "divide");

            calc.AddLnwOperators();

            foreach(var operation in calc.Operators)
            {
                operationList.Items.Add(operation);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            var number1 = double.Parse(number1TextBox.Text);
            var number2= double.Parse(number2TextBox.Text);
            var operation = operationList.SelectedItem.ToString();
            

            calc.Calculate(number1, operation, number2);
        }
    }
}
