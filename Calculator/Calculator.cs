using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private int value = 0;
        private string operation = "";
        private bool operationStart = false;
        private bool lastOperation = false;
        private bool checkForNextNumber = false;
        private bool trouble = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (operationStart == false)
            {
                EnableAll();
                buttonResult.Enabled = false;
            }
            if (result.Text == "0" || lastOperation == true)
            {
                result.Text = button.Text;
                lastOperation = false;
            }
            else if (operationStart == true && checkForNextNumber == false)
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
            if (trouble == true)
            {
                buttonResult.Enabled = true;
                trouble = false;
            }
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (operationStart == true)
            {
                result.Text = "";
            }
            else
            {
                result.Text = "";
                history.Text = "";
                value = 0;
                operation = "";
                DisableAll();
            }
            buttonResult.Enabled = false;
            trouble = true;
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
                default:
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