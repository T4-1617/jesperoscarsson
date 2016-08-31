using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Buttons
        private void btn1_Click(object sender, EventArgs e)
        {
            double fNumber = double.Parse(fNum.Text);
            double sNumber = double.Parse(sNum.Text);
            showAnswer.Text = "Equals: " + (fNumber + sNumber);
            fNum.ResetText();
            sNum.ResetText();
            fNum.Focus();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            double fNumber = double.Parse(fNum.Text);
            double sNumber = double.Parse(sNum.Text);
            showAnswer.Text = "Equals: " + (fNumber - sNumber);
            fNum.ResetText();
            sNum.ResetText();
            fNum.Focus();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            double fNumber = double.Parse(fNum.Text);
            double sNumber = double.Parse(sNum.Text);
            showAnswer.Text = "Equals: " + (fNumber / sNumber);
            fNum.ResetText();
            sNum.ResetText();
            fNum.Focus();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            double fNumber = double.Parse(fNum.Text);
            double sNumber = double.Parse(sNum.Text);
            showAnswer.Text = "Equals: " + (fNumber * sNumber);
            fNum.ResetText();
            sNum.ResetText();
            fNum.Focus();
        }
    }
}
