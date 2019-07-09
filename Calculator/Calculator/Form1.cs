using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void Addition_Click(object sender, EventArgs e)
        {
            double operand1 = Convert.ToDouble(Input1.Text);
            double operand2 = Convert.ToDouble(Input2.Text);
            double result = operand1 + operand2;
            Result.Text = result.ToString();

        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            double operand1 = Convert.ToDouble(Input1.Text);
            double operand2 = Convert.ToDouble(Input2.Text);
            double result = operand1 - operand2;
            Result.Text = result.ToString();
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            double operand1 = Convert.ToDouble(Input1.Text);
            double operand2 = Convert.ToDouble(Input2.Text);
            double result = operand1 * operand2;
            Result.Text = result.ToString();
        }

        private void Division_Click(object sender, EventArgs e)
        {
            double operand1 = Convert.ToDouble(Input1.Text);
            double operand2 = Convert.ToDouble(Input2.Text);
            double result = operand1 / operand2;
            Result.Text = result.ToString();
        }
    }
}
