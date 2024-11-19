using CalculatorPrivateAssembly;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(textBox1.Text);
                float num2 = float.Parse(textBox1.Text);

                float result = 0;

                string selectedOperator = comboBox1.SelectedItem.ToString();

                switch (selectedOperator)
                {
                    case "+":
                        result = BasicComputation.Add(num1, num2);
                        break;

                    case "-":
                        result = BasicComputation.Subtract(num1, num2);
                        break;

                    case "*":
                        result = BasicComputation.Multiply(num1, num2);
                        break;

                    case "/":
                        result = BasicComputation.Divide(num1, num2);
                        break;

                    default:
                        throw new InvalidOperationException("Unknown operator.");
                }

                
                richTextBox1.Clear(); 
                richTextBox1.AppendText("First Number: " + num1.ToString() + "\n");
                richTextBox1.AppendText("Second Number: " + num2.ToString() + "\n");
                richTextBox1.AppendText("Operator: " + selectedOperator + "\n");
                richTextBox1.AppendText("Total: " + result.ToString());
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Cannot divide by zero.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
