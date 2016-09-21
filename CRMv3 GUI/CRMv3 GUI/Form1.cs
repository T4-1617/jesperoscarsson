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
        int registeredSuppliersCounter = 0;
        int customerUniqueIDCounter = 10000;

        public Form1()
        {
            InitializeComponent();
            persons = new System.Collections.ArrayList();
            //Fills dropdown list with options
            dropDownList.Items.Add("Kund"); dropDownList.Items.Add("Anställd"); dropDownList.Items.Add("Leverantör");
        }

        public void setDefaultValuesNewRegisterWindow()
        {
            txtBoxCompany.Visible = false; txtBoxCompany.Text = string.Empty; lblCompany.Visible = false;
            txtBoxTitel.Visible = false; txtBoxTitel.Text = string.Empty; lblTitel.Visible = false;
            txtBoxSalary.Visible = false; txtBoxSalary.Text = string.Empty; lblSalary.Visible = false;
            txtBoxEmpNumb.Visible = false; txtBoxEmpNumb.Text = string.Empty; lblEmpNumb.Visible = false;
            txtBoxFName.Text = string.Empty;
            txtBoxLName.Text = string.Empty;
            txtBoxNumber.Text = string.Empty;
        }

        private void dropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

            setDefaultValuesNewRegisterWindow();

            switch (dropDownList.Text)
            {
                case "Anställd":
                    //Show relevant extra fields
                    lblTitel.Visible = true;
                    txtBoxTitel.Visible = true;
                    lblSalary.Visible = true;
                    txtBoxSalary.Visible = true;
                    lblEmpNumb.Visible = true;
                    txtBoxEmpNumb.Visible = true;
                    break;
                case "Leverantör":
                    //Show relevant extra fields
                    lblCompany.Visible = true;
                    txtBoxCompany.Visible = true;
                    break;
                default:
                    //setDefaultValuesNewRegisterWindow();
                    break;
            }
        }

        private void btnRegisterNewUserCancel_Click(object sender, EventArgs e)
        {
            txtBoxFName.Text = string.Empty;
            txtBoxLName.Text = string.Empty;
            txtBoxNumber.Text = string.Empty;
            txtBoxTitel.Text = string.Empty;
            txtBoxSalary.Text = string.Empty;
            txtBoxEmpNumb.Text = string.Empty;
        }

        private void btnRegisterNewUserSave_Click(object sender, EventArgs e)
        {
            switch (dropDownList.Text)
            {
                case "Kund":
                    persons.Add(new Customer { firstName = txtBoxFName.Text, lastName = txtBoxLName.Text, telephoneNumber = txtBoxNumber.Text, customerID = (customerUniqueIDCounter+1) });
                    registeredCustomersCounter++;
                    break;
                case "Anställd":
                    persons.Add(new Employee { firstName = txtBoxFName.Text, lastName = txtBoxLName.Text, telephoneNumber = txtBoxNumber.Text });
                    registeredEmployeesCounter++;
                    break;
                case "Leverantör":
                    persons.Add(new Supplier { firstName = txtBoxFName.Text, lastName = txtBoxLName.Text, telephoneNumber = txtBoxNumber.Text, supplierCompany = txtBoxCompany.Text });
                    registeredSuppliersCounter++;
                    break;
                default:
                    break;
            }

            listBoxUpdate();

        }
        //Updates listBox and counter label 
        public void listBoxUpdate()
        {
            //Update label
            lblTellHowManyRegistered.Text = string.Format("Du har registrerat {0} kunder, {1} anställda och {2} leverantörer.", registeredCustomersCounter, registeredEmployeesCounter, registeredSuppliersCounter);
            //Update listBox
            listBoxRegisteredUsers.Items.Clear();
            foreach (Person item in persons)
            {
                listBoxRegisteredUsers.Items.Add(item.fullName);
            }
        }
    }
}
