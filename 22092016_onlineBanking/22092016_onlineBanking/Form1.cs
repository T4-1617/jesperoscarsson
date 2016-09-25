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

        public Form1()
        {
            InitializeComponent();
            peopleList = new System.Collections.ArrayList();
            //Updates GUI to "customer layout" (this changes if you check that your an employee)
        }

        public void CloseAllPnl()
        {
            pnlDeposit.Visible  = false;
            pnlHistory.Visible  = false;
            pnlOpenAcc.Visible  = false;
            pnlWithdraw.Visible = false;
            pnlBalance.Visible  = false;
        }

        public void UpdateCustomerListBox()
        {
            listBCustomers.Items.Clear();
            listBCustomers.DisplayMember = "Name";
            foreach (Customer item in peopleList)
            {
                listBCustomers.Items.Add(item);
            }
        }

        private void btnOpenAcc_Click(object sender, EventArgs e)
        {
            CloseAllPnl();
            pnlOpenAcc.Visible = true;
        }       

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            CloseAllPnl();
            pnlDeposit.Visible = true;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            CloseAllPnl();
            pnlWithdraw.Visible = true;
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            CloseAllPnl();
            pnlBalance.Visible = true;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            CloseAllPnl();
            pnlHistory.Visible = true;
        }

        private void btnConfirmAccReg_Click(object sender, EventArgs e)
        {
            //Check if boxes are empty or initial deposit is equal to or greater than 1000
            if (txtBName.Text != string.Empty && txtBNumb.Text != string.Empty && txtBAccName.Text != string.Empty && txtBFDeposit.Text != string.Empty && decimal.Parse(txtBFDeposit.Text) >= 1000)
            {
                if (listBCustomers.SelectedItem != null)
                {
                    //Add new account to existing customer
                    MessageBox.Show("Existing User");
                }

                else
                {
                    //Adds new customer and creates one account for him/her
                    Customer temp = new Customer() { Name = txtBName.Text, TelephoneNumber = txtBNumb.Text };
                    temp.CreateAccount(decimal.Parse(txtBFDeposit.Text), txtBAccName.Text);
                    peopleList.Add(temp);
                    UpdateCustomerListBox();
                }

                lblCongratulations.Visible = true;
                btnCloseAccountPage.Visible = true;

            }

            else
            {
                 MessageBox.Show("Could not add account, one of the requirements were not met. Try not leaving anything empty/deposit less than 1000!");
            }
        }

        private void btnCloseAccountPage_Click(object sender, EventArgs e)
        {
            CloseAllPnl();
            lblCongratulations.Visible = false;
            btnCloseAccountPage.Visible = false;
        }
    }
}