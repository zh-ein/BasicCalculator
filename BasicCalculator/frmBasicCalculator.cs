using CalculatorPrivateAssembly;
namespace BasicCalculator
{
    public partial class frmBasicCalculator : Form
    {
        public frmBasicCalculator()
        {
            InitializeComponent();
            InitializeComboBox(); // Populate ComboBox when the form is initialized
        }

        private void InitializeComboBox()
        {
            // Add operations to the ComboBox
            cbOperations.Items.Add("+");
            cbOperations.Items.Add("-");
            cbOperations.Items.Add("*");
            cbOperations.Items.Add("/");
            cbOperations.SelectedIndex = 0; // Set default selection
        

    }

    private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtNum1.Text);
                float number2 = float.Parse(txtNum2.Text);
                string operation = cbOperations.SelectedItem.ToString();
                float result = 0;

                switch (operation)
                {
                    case "+":
                        result = BasicComputation.Add(number1, number2);
                        break;
                    case "-":
                        result = BasicComputation.Subtract(number1, number2);
                        break;
                    case "*":
                        result = BasicComputation.Multiply(number1, number2);
                        break;
                    case "/":
                        result = BasicComputation.Divide(number1, number2);
                        break;
                }

                rtbResult.Text = $"Result:\n {result}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }

}