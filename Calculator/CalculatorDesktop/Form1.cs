using ConceptArchitect.Calculators;

namespace CalculatorDesktop
{
    public partial class Form1 : Form
    {
        Calculator calc;

        public Form1()
        {
            InitializeComponent();
            var builder = new CalculatorBuilder();
            calc = builder.Build();

            calc.OutputPresenter = new ComponentResultPresenter() 
            { 
                Target = resultLabel 
            };


            foreach (var operation in calc.Operators)
                operationList.Items.Add(operation);
            
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
