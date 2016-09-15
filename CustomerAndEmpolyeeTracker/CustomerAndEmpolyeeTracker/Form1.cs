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
            if (rdbtnCustomer.Checked)
            {
                CustomerAndEmployeeList.Add(new Customer() { firstName = txtBoxFName.Text, lastName = txtBoxLName.Text }); //add customer object to arrayList
                txtBoxFName.Text = string.Empty; txtBoxLName.Text = string.Empty;   //Set boxes to empty
                txtBoxFName.Focus(); //Set focus to fName box
            }
            else if (rdbtnEmployee.Checked)
            {
                CustomerAndEmployeeList.Add(new Employee() { firstName = txtBoxFName.Text, lastName = txtBoxLName.Text });  //add employee object to arrayList
                txtBoxFName.Text = string.Empty; txtBoxLName.Text = string.Empty;   //Set boxes to empty
                txtBoxFName.Focus(); //Set focus to fName box
            }

            DisplayCustomersAndEmployees();
        }

        private void DisplayCustomersAndEmployees()
        {
            //Clear lists
            listBoxCustomers.Items.Clear();
            listBoxEmployees.Items.Clear();
            //Print new lists
            foreach (var arrayContent in CustomerAndEmployeeList)
            {
                switch (arrayContent.GetType().Name)
                {
                    case "Customer":
                        listBoxCustomers.Items.Add(arrayContent);
                        break;
                    case "Employee":
                        listBoxEmployees.Items.Add(arrayContent);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
