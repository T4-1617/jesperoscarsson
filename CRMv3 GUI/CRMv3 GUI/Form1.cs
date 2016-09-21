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
        System.Collections.ArrayList peopleList;
        Random random;
        //Global variables
        static int registeredCustomerCounter = 0;
        static int registeredEmployeeCounter = 0;
        static int registeredSupplierCounter = 0;
        static int employeeIDCounter = 0;
        //Used to set a customer ID range (Max amount of customers)
        static int customerMinIDVal = 1;
        static int customerMaxIDVal = 500;       

        public Form1()
        {
            InitializeComponent();
            peopleList = new System.Collections.ArrayList();
            random = new Random();
            //Fills dropdown list with options
            dropDownList.Items.Add("Kund"); dropDownList.Items.Add("Anställd"); dropDownList.Items.Add("Leverantör");
        }

        /*public void setDefaultValuesNewRegisterWindow()
        {
            txtBoxCompany.Visible = false; txtBoxCompany.Text = string.Empty; lblCompany.Visible = false;
            txtBoxTitel.Visible = false; txtBoxTitel.Text = string.Empty; lblTitel.Visible = false;
            txtBoxSalary.Visible = false; txtBoxSalary.Text = string.Empty; lblSalary.Visible = false;
            txtBoxEmpNumb.Visible = false; txtBoxEmpNumb.Text = string.Empty; lblEmpNumb.Visible = false;
            txtBoxFName.Text = string.Empty;
            txtBoxLName.Text = string.Empty;
            txtBoxNumber.Text = string.Empty;
        }*/

        private void dropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (dropDownList.Text)
            {
                case "Anställd":
                    //Show relevant extra fields
                    lblTitel.Visible = true;
                    txtBoxTitel.Visible = true;
                    lblSalary.Visible = true;
                    txtBoxSalary.Visible = true;
                    //Hide others
                    lblCompany.Visible = false;
                    txtBoxCompany.Visible = false;
                    break;
                case "Leverantör":
                    //Show relevant extra fields
                    lblCompany.Visible = true;
                    txtBoxCompany.Visible = true;
                    //Hide others
                    lblTitel.Visible = false; txtBoxTitel.Visible = false;
                    lblSalary.Visible = false; txtBoxSalary.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void btnRegisterNewUserCancel_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            //Set focus to first name
            txtBoxFName.Focus();
        }

        private void btnRegisterNewUserSave_Click(object sender, EventArgs e)
        {
            switch (dropDownList.Text)
            {
                case "Kund":
                    peopleList.Add(new Customer { firstName = txtBoxFName.Text, lastName = txtBoxLName.Text, telephoneNumber = Convert.ToInt32(txtBoxNumber.Text), customerID = getRndNumb(customerMinIDVal, customerMaxIDVal) });
                    registeredCustomerCounter++;
                    break;
                case "Anställd":
                    employeeIDCounter++;
                    peopleList.Add(new Employee { firstName = txtBoxFName.Text, lastName = txtBoxLName.Text, telephoneNumber = Convert.ToInt32(txtBoxNumber.Text), EmployeeNumber = employeeIDCounter, titel = txtBoxTitel.Text, salary = Convert.ToDouble(txtBoxSalary.Text) });
                    registeredEmployeeCounter++;
                    break;
                case "Leverantör":
                    peopleList.Add(new Supplier { firstName = txtBoxFName.Text, lastName = txtBoxLName.Text, telephoneNumber = Convert.ToInt32(txtBoxNumber.Text), supplierCompany = txtBoxCompany.Text });
                    registeredSupplierCounter++;
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
            lblTellHowManyRegistered.Text = string.Format("Du har registrerat {0} kunder, {1} anställda och {2} leverantörer.", registeredCustomerCounter, registeredEmployeeCounter, registeredSupplierCounter);
            //Update listBox
            listBoxRegisteredUsers.Items.Clear();
            foreach (Person item in peopleList)
            {
                listBoxRegisteredUsers.Items.Add(item.fullName);
            }
            //Clear txtBoxes where user left input
            clearTextBoxes();
        }
        //Clears textBoxes where user left input
        public void clearTextBoxes()
        {
            txtBoxFName.Text = string.Empty;
            txtBoxLName.Text = string.Empty;
            txtBoxNumber.Text = string.Empty;
            txtBoxTitel.Text = string.Empty;
            txtBoxSalary.Text = string.Empty;
            txtBoxCompany.Text = string.Empty;
        }

        public int getRndNumb(int minVal, int maxVal)
        {
            int rndNumber = random.Next(minVal, (maxVal+1));

            return rndNumber;
        }
    }
}