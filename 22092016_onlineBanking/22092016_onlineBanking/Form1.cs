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
            //Check if already existing customer has been chosen
            if (listBCustomers.SelectedItem != null)
            {
                //Add new account to existing customer
            }
            //Check that boxes aren't empty
            if (txtBFName.Text == string.Empty || txtBLName.Text == string.Empty || txtBNumb.Text == string.Empty || txtBAccName.Text == string.Empty || txtBFDeposit.Text == string.Empty)
            {
                MessageBox.Show("Test");
            }
        }
    }
}
