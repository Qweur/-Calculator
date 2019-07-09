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
            double firstoperand = Convert.ToDouble(Input1.Text);
            double secondoperand = Convert.ToDouble(Input2.Text);
            double result = firstoperand + secondoperand;
            Result.Text = result.ToString();

        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            double firstoperand = Convert.ToDouble(Input1.Text);
            double secondoperand = Convert.ToDouble(Input2.Text);
            double result = firstoperand - secondoperand;
            Result.Text = result.ToString();
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            double firstoperand = Convert.ToDouble(Input1.Text);
            double secondoperand = Convert.ToDouble(Input2.Text);
            double result = firstoperand * secondoperand;
            Result.Text = result.ToString();
        }

        private void Division_Click(object sender, EventArgs e)
        {
            double firstoperand = Convert.ToDouble(Input1.Text);
            double secondoperand = Convert.ToDouble(Input2.Text);
            double result = firstoperand / secondoperand;
            Result.Text = result.ToString();
        }
    }
}
