﻿using System;
using System.Globalization;
using System.Windows.Forms;
using Calculator.FactoryOne;
using Calculator.FactoryTwo;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Input1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_Two(object sender, EventArgs e)
        {
            double firstOperand = Convert.ToDouble(Input1.Text);
            IOneArgumentsCalculator calculator = FactoryTwo.FactoryTwo.CalculateTwo(((Button)sender).Name);
            double result = calculator.CalculateTwo(firstOperand);


            Result.Text = result.ToString(CultureInfo.InvariantCulture);
        }
        private void Calculate(object sender, EventArgs e)
        {
            double firstOperand = Convert.ToDouble(Input1.Text);
            double secondOperand = Convert.ToDouble(Input2.Text);
            ITwoArgumentsCalculator calculator = Factory.Calculate(((Button)sender).Name);
            double result = calculator.Calculate(firstOperand,secondOperand);


            Result.Text = result.ToString(CultureInfo.InvariantCulture);

        }
    }
}
