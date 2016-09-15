using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerAndEmpolyeeTracker
{
    public partial class Form1 : Form
    {

        System.Collections.ArrayList CustomerAndEmployeeList;

        public Form1()
        {
            InitializeComponent();
            CustomerAndEmployeeList = new System.Collections.ArrayList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
