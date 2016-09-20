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
            //Fills dropdown list with options
            dropDownList.Items.Add("Customer"); dropDownList.Items.Add("Employee"); dropDownList.Items.Add("Supplier");
        }

        public virtual void setDefaultValuesNewRegisterWindow()
        {
            txtBoxCompany.Visible = false; txtBoxCompany.Text = string.Empty; lblCompany.Visible = false;
            txtBoxFName.Text = string.Empty;
            txtBoxLName.Text = string.Empty;
            txtBoxNumber.Text = string.Empty;
        }

        private void dropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check that an actual item has been selected
            if (dropDownList.SelectedIndex != -1)
            {
                //Sets all boxes to default mode
                setDefaultValuesNewRegisterWindow();

                switch (dropDownList.Text)
                {
                    case "Employee":
                        //TODO Add Employee txtboxes
                        break;
                    case "Supplier":
                        //Show relevant extra fields
                        lblCompany.Visible = true;
                        txtBoxCompany.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnRegisterNewUserCancel_Click(object sender, EventArgs e)
        {
            txtBoxFName.Text = string.Empty;
            txtBoxLName.Text = string.Empty;
            txtBoxNumber.Text = string.Empty;
            txtBoxCompany.Text = string.Empty;
            //Repeat for other txtboxes once added
        }
    }
}
