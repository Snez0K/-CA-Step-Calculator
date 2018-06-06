using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private int value = 0;
        private string operation = "";
        private bool operation_start = false;
        private bool lastoperation = false;
        private bool check = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (operation_start == false)
            {
                EnableAll();
                buttonResult.Enabled = false;
            }
            if (result.Text == "0" || lastoperation == true)
            {
                result.Text = button.Text;
                lastoperation = false;
            }
            else if (operation_start == true && check == false)
            {
                result.Text = "";
                result.Text = result.Text + button.Text;
                buttonResult.Enabled = true;
                check = true; 
            }
            else 
            {
                result.Text = result.Text + button.Text;
            }
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (operation_start == true)
            {
                result.Text = "";
            }else
            {
                result.Text = "";
                history.Text = "";
                value = 0;
                operation = "";
                DisableAll();
                buttonResult.Enabled = false;
            }
            
        }

        private void Button_operator(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value = int.Parse(result.Text);
            operation_start = true;
            history.Text = value + " " + operation;
            DisableAll();
            check = false;
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
            operation_start = false;
            buttonResult.Enabled = false;
            lastoperation = true;
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