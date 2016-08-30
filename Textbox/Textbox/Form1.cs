using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fName = textBox1.Text;
            string LName = textBox2.Text;

            if (fName == "Michael" && LName == "Bay")
            {
                pictureBox1.Visible = true;
            }

            else
            {
                pictureBox1.Visible = false;
            }

            MessageBox.Show("Hello " + fName + " " + LName + "!");
        }
    }
}
