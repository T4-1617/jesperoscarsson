using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22092016_onlineBanking
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList peopleList;
        System.Collections.ArrayList accountList;
        Random random;
        //Global variables declaration
        int minVal;
        int maxVal;    

        public Form1()
        {
            InitializeComponent();
            peopleList = new System.Collections.ArrayList();
            accountList = new System.Collections.ArrayList();
            random = new Random();
            //Global variables initialization
            minVal = 1;
            maxVal = 500000;
        }

        private void btnOpenAcc_Click(object sender, EventArgs e)
        {
            closeAllPnl();
            pnlOpenAcc.Visible = true;
        }

        private void closeAllPnl()
        {
            pnlDeposit.Visible  = false;
            pnlHistory.Visible  = false;
            pnlOpenAcc.Visible  = false;
            pnlWithdraw.Visible = false;
            pnlBalance.Visible  = false;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            closeAllPnl();
            pnlDeposit.Visible = true;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            closeAllPnl();
            pnlWithdraw.Visible = true;
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            closeAllPnl();
            pnlBalance.Visible = true;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            closeAllPnl();
            pnlHistory.Visible = true;
        }

        private void btnConfirmAccReg_Click(object sender, EventArgs e)
        {
            //Check if boxes are empty or initial deposit is equal to or greater than 1000
            if (txtBFName.Text != string.Empty && txtBLName.Text != string.Empty && txtBNumb.Text != string.Empty && txtBAccName.Text != string.Empty && txtBFDeposit.Text != string.Empty && float.Parse(txtBFDeposit.Text) >= 1000)
            {
                if (listBCustomers.SelectedItem != null)
                {
                    //Add new account to existing customer
                    MessageBox.Show("Test");
                }
                //Check if no previous customer has been selected
                if (listBCustomers.SelectedItem == null)
                {
                    listBCustomers.Items.Add(new Customer() { firstName = txtBFName.Text, lastName = txtBLName.Text, phoneNumber = txtBNumb.Text, customerID = getRndNumber(minVal, maxVal) });
                    listBCustomers.DisplayMember = "fullName";
                }
            }

            else
            {
                 MessageBox.Show("Could not add account, one of the requirements were not met. Try not leaving anything empty/deposit less than 1000kr.");
            }
        }

        public int getRndNumber(int minVal, int maxVal)
        {
            return random.Next(minVal, (maxVal + 1));
        }
    }
}
