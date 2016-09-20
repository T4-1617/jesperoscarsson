using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMv3_GUI
{
    public partial class Form1 : Form
    {
        //Holds all person objects (Customer, Employee & Supplier)
        System.Collections.ArrayList persons;
        //Global variables for keeping count of amount of customers
        int registeredCustomersCounter = 0;
        int registeredEmployeesCounter = 0;
        int registeredSuppliers = 0;

        public Form1()
        {
            InitializeComponent();

        }
    }
}
