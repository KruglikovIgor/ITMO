using Calculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class EnginForm : SimpleCalculator.CalcUI
    {
        public EnginForm()
        {
            InitializeComponent();
        }
        public static double firstNumber;
        private void KeySqr_Click(object sender, EventArgs e)
        {
            firstNumber = System.Convert.ToDouble(OutputDisplay.Text);
            firstNumber =Math.Sqrt(firstNumber);
            OutputDisplay.Text = System.Convert.ToString(firstNumber);
        }

        private void KeyHyperbola_Click(object sender, EventArgs e)
        {
            firstNumber = System.Convert.ToDouble(OutputDisplay.Text);
            firstNumber = 1/firstNumber;
            OutputDisplay.Text = System.Convert.ToString(firstNumber);
        }

        private void KeyParabola_Click(object sender, EventArgs e)
        {
            firstNumber = System.Convert.ToDouble(OutputDisplay.Text);
            firstNumber = firstNumber*firstNumber;
            OutputDisplay.Text=System.Convert.ToString(firstNumber);
        }

        private void KeyDegree_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eDegree);
        }
    }
}
