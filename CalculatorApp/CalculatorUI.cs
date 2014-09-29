using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }

        Calculator aCalculator = new Calculator();
        private double result = 0;
        private double firstNo=0;
        private double secondNo=0;

        private void InitializationFirstNoAndSecondNo()
        {
            if (firstNumTextBox.Text != "" && secNumTextBox.Text != "")
            {
                firstNo = Convert.ToDouble(firstNumTextBox.Text);
                secondNo = Convert.ToDouble(secNumTextBox.Text);
                
            }
            else
            {
                MessageBox.Show(@"Please Enter Your Number!");
            }
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            InitializationFirstNoAndSecondNo();
            result= aCalculator.Add(firstNo, secondNo);
            resultTextBox.Text = result.ToString();


        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            
            InitializationFirstNoAndSecondNo();
            result = aCalculator.Subtract(firstNo, secondNo);
            resultTextBox.Text = result.ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            
            InitializationFirstNoAndSecondNo();
            result = aCalculator.Multiply(firstNo, secondNo);
            resultTextBox.Text = result.ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            
            InitializationFirstNoAndSecondNo();
            result = aCalculator.Divide(firstNo, secondNo);
            resultTextBox.Text = result.ToString();
        }

       
    }
}
