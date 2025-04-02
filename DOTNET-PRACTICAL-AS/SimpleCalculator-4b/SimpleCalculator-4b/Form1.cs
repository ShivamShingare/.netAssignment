using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator_4b
{
    public partial class Form1 : Form
    {

        private double firstNumber;  // Stores the first number
        private double secondNumber; // Stores the second number
        private string operation;    // Stores the operator (+, -, *, /)
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (txtDisplay.Text == "0")
                txtDisplay.Text = button.Text;
            else
                txtDisplay.Text += button.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (txtDisplay.Text == "0")
                txtDisplay.Text = button.Text;
            else
                txtDisplay.Text += button.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (txtDisplay.Text == "0")
                txtDisplay.Text = button.Text;
            else
                txtDisplay.Text += button.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (txtDisplay.Text == "0")
                txtDisplay.Text = button.Text;
            else
                txtDisplay.Text += button.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (txtDisplay.Text == "0")
                txtDisplay.Text = button.Text;
            else
                txtDisplay.Text += button.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (txtDisplay.Text == "0")
                txtDisplay.Text = button.Text;
            else
                txtDisplay.Text += button.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (txtDisplay.Text == "0")
                txtDisplay.Text = button.Text;
            else
                txtDisplay.Text += button.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (txtDisplay.Text == "0")
                txtDisplay.Text = button.Text;
            else
                txtDisplay.Text += button.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (txtDisplay.Text == "0")
                txtDisplay.Text = button.Text;
            else
                txtDisplay.Text += button.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (txtDisplay.Text == "0")
                txtDisplay.Text = button.Text;
            else
                txtDisplay.Text += button.Text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(txtDisplay.Text);

            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (firstNumber + secondNumber).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (firstNumber - secondNumber).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (firstNumber * secondNumber).ToString();
                    break;
                case "/":
                    if (secondNumber != 0)
                        txtDisplay.Text = (firstNumber / secondNumber).ToString();
                    else
                        txtDisplay.Text = "Error";
                    break;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            firstNumber = double.Parse(txtDisplay.Text);
            operation = button.Text;
            txtDisplay.Text = "0";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            firstNumber = double.Parse(txtDisplay.Text);
            operation = button.Text;
            txtDisplay.Text = "0";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            firstNumber = double.Parse(txtDisplay.Text);
            operation = button.Text;
            txtDisplay.Text = "0";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            firstNumber = double.Parse(txtDisplay.Text);
            operation = button.Text;
            txtDisplay.Text = "0";
        }
    }
}
