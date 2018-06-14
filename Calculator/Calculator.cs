using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private int value;
        private string operation = "";
        private bool operationStart;
        private bool lastOperation;
        private bool checkForNextNumber;
        private bool noSecondOperand;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!operationStart)
            {
                EnableAll();
                buttonResult.Enabled = false;
            }
            if (result.Text == "0" || lastOperation)
            {
                result.Text = button.Text;
                lastOperation = false;
            }
            else if (operationStart && !checkForNextNumber)
            {
                result.Text = "";
                result.Text = result.Text + button.Text;
                buttonResult.Enabled = true;
                checkForNextNumber = true; 
            }
            else 
            {
                result.Text = result.Text + button.Text;
            }
            if (noSecondOperand)
            {
                buttonResult.Enabled = true;
                noSecondOperand = false;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            result.Text = "";
            if (!operationStart)
            {
                history.Text = "";
                value = 0;
                operation = "";
                DisableAll();
            }
            buttonResult.Enabled = false;
            noSecondOperand = true;
        }

        private void Button_operator(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value = int.Parse(result.Text);
            operationStart = true;
            history.Text = value + " " + operation;
            DisableAll();
            checkForNextNumber = false;
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            history.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + int.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - int.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * int.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / int.Parse(result.Text)).ToString();
                    break;
            }
            operationStart = false;
            buttonResult.Enabled = false;
            lastOperation = true;
        }

        private void EnableAll()
        {
            buttonPlus.Enabled = true;
            buttonMinus.Enabled = true;
            buttonMultiply.Enabled = true;
            buttonDivide.Enabled = true;
        }

        private void DisableAll()
        {
            buttonPlus.Enabled = false;
            buttonMinus.Enabled = false;
            buttonMultiply.Enabled = false;
            buttonDivide.Enabled = false;
        }
    }
}