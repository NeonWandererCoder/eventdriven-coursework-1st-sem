using System;
using System.Windows.Forms;
using CalculatorPrivateAssembly; // the private assembly we referenced

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            // make sure both inputs are real numbers first
            float num1, num2;

            if (!float.TryParse(txtNumber1.Text, out num1))
            {
                MessageBox.Show("First number must be a valid number.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumber1.Focus();
                return;
            }

            if (!float.TryParse(txtNumber2.Text, out num2))
            {
                MessageBox.Show("Second number must be a valid number.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumber2.Focus();
                return;
            }

            if (cbOperator.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an operator.",
                    "Missing Operator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float total = 0;

            // call the matching method from BasicComputation in the private assembly
            switch (cbOperator.Text)
            {
                case "+":
                    total = BasicComputation.Addition(num1, num2);
                    break;

                case "-":
                    total = BasicComputation.Subtraction(num1, num2);
                    break;

                case "*":
                    total = BasicComputation.Multiplication(num1, num2);
                    break;

                case "/":
                    // can't divide by zero, so stop here
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.",
                            "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    total = BasicComputation.Division(num1, num2);
                    break;
            }

            lblTotal.Text = total.ToString();
        }
    }
}
