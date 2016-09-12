using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_0912
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Function for generating unique ID number in the 100-200 range (did not use random since it wasn't specified)
        public int getIDNumber()
        {
            IDcounter++;
            IDNumber = IDcounter;

            return IDNumber;
        }

        //Array for storing customer values
        System.Collections.ArrayList CustomerList = new System.Collections.ArrayList();
        //Variables
        static int IDcounter = 99;
        static int IDNumber = 0;

        //Executes when button is pressed
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IDcounter <= 200)
            {
                //Create new object from class Customers
                Customers customerInfo = new Customers();
                //Retrieve first & second name
                customerInfo.FirstName = txtBoxFName.Text;
                customerInfo.LastName = txtBoxLName.Text;
                customerInfo.Active = true;
                customerInfo.CustomerID = getIDNumber();
                //Add new info to list
                CustomerList.Add(customerInfo);
                //Clear textBoxes
                txtBoxFName.Text = string.Empty;
                txtBoxLName.Text = string.Empty;
                //Updates ListBox
                updateListBox();
            }
        }

        private void updateListBox()
        {
            listBoxMain.Items.Clear();

            foreach (Customers item in CustomerList)
            {
                listBoxMain.Items.Add(item.FullName());
            }
        }



    }
}
