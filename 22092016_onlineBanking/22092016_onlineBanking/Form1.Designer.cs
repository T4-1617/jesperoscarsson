﻿namespace _22092016_onlineBanking
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rBtnCustomer = new System.Windows.Forms.RadioButton();
            this.rBtnEmployee = new System.Windows.Forms.RadioButton();
            this.btnOpenAcc = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.listBCustomers = new System.Windows.Forms.ListBox();
            this.listBAccounts = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSelectAcc = new System.Windows.Forms.Label();
            this.pnlOpenAcc = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.rBtnNewAccount = new System.Windows.Forms.RadioButton();
            this.rBtnNewCustomer = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCloseAccountPage = new System.Windows.Forms.Button();
            this.lblCongratulations = new System.Windows.Forms.Label();
            this.lblOpenAccInfo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnConfirmAccReg = new System.Windows.Forms.Button();
            this.txtBFDeposit = new System.Windows.Forms.TextBox();
            this.txtBAccName = new System.Windows.Forms.TextBox();
            this.txtBNumb = new System.Windows.Forms.TextBox();
            this.txtBName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlDeposit = new System.Windows.Forms.Panel();
            this.lblDepositError = new System.Windows.Forms.Label();
            this.btnDepositCancel = new System.Windows.Forms.Button();
            this.btnDepositAccept = new System.Windows.Forms.Button();
            this.lblDepositCurrentBalance = new System.Windows.Forms.Label();
            this.txtBDepositAmount = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlWithdraw = new System.Windows.Forms.Panel();
            this.btnWithdrawCancel = new System.Windows.Forms.Button();
            this.btnWithdrawAccept = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.lblWithdrawCurrentBalance = new System.Windows.Forms.Label();
            this.txtBWithdrawAmount = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.lblHistoryError = new System.Windows.Forms.Label();
            this.lblHistoryDifference = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.listBHistory = new System.Windows.Forms.ListBox();
            this.label28 = new System.Windows.Forms.Label();
            this.pnlBalance = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBalanceShow = new System.Windows.Forms.Label();
            this.pnlOpenAcc.SuspendLayout();
            this.pnlDeposit.SuspendLayout();
            this.pnlWithdraw.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            this.pnlBalance.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Who are you?";
            // 
            // rBtnCustomer
            // 
            this.rBtnCustomer.AutoSize = true;
            this.rBtnCustomer.Checked = true;
            this.rBtnCustomer.Location = new System.Drawing.Point(98, 12);
            this.rBtnCustomer.Name = "rBtnCustomer";
            this.rBtnCustomer.Size = new System.Drawing.Size(69, 17);
            this.rBtnCustomer.TabIndex = 1;
            this.rBtnCustomer.TabStop = true;
            this.rBtnCustomer.Text = "Customer";
            this.rBtnCustomer.UseVisualStyleBackColor = true;
            this.rBtnCustomer.CheckedChanged += new System.EventHandler(this.rBtnCustomer_CheckedChanged);
            // 
            // rBtnEmployee
            // 
            this.rBtnEmployee.AutoSize = true;
            this.rBtnEmployee.Location = new System.Drawing.Point(98, 35);
            this.rBtnEmployee.Name = "rBtnEmployee";
            this.rBtnEmployee.Size = new System.Drawing.Size(71, 17);
            this.rBtnEmployee.TabIndex = 2;
            this.rBtnEmployee.Text = "Employee";
            this.rBtnEmployee.UseVisualStyleBackColor = true;
            this.rBtnEmployee.CheckedChanged += new System.EventHandler(this.rBtnEmployee_CheckedChanged);
            // 
            // btnOpenAcc
            // 
            this.btnOpenAcc.Location = new System.Drawing.Point(8, 94);
            this.btnOpenAcc.Name = "btnOpenAcc";
            this.btnOpenAcc.Size = new System.Drawing.Size(128, 23);
            this.btnOpenAcc.TabIndex = 3;
            this.btnOpenAcc.Text = "Open account";
            this.btnOpenAcc.UseVisualStyleBackColor = true;
            this.btnOpenAcc.Click += new System.EventHandler(this.btnOpenAcc_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Enabled = false;
            this.btnDeposit.Location = new System.Drawing.Point(276, 94);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(128, 23);
            this.btnDeposit.TabIndex = 4;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.Enabled = false;
            this.btnBalance.Location = new System.Drawing.Point(142, 94);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(128, 23);
            this.btnBalance.TabIndex = 6;
            this.btnBalance.Text = "Balance";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Enabled = false;
            this.btnHistory.Location = new System.Drawing.Point(544, 94);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(128, 23);
            this.btnHistory.TabIndex = 7;
            this.btnHistory.Text = "Transaction History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Enabled = false;
            this.btnWithdraw.Location = new System.Drawing.Point(410, 94);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(128, 23);
            this.btnWithdraw.TabIndex = 8;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // listBCustomers
            // 
            this.listBCustomers.FormattingEnabled = true;
            this.listBCustomers.Location = new System.Drawing.Point(201, 19);
            this.listBCustomers.Name = "listBCustomers";
            this.listBCustomers.Size = new System.Drawing.Size(230, 69);
            this.listBCustomers.TabIndex = 9;
            this.listBCustomers.SelectedIndexChanged += new System.EventHandler(this.listBCustomers_SelectedIndexChanged);
            // 
            // listBAccounts
            // 
            this.listBAccounts.FormattingEnabled = true;
            this.listBAccounts.Location = new System.Drawing.Point(438, 19);
            this.listBAccounts.Name = "listBAccounts";
            this.listBAccounts.Size = new System.Drawing.Size(234, 69);
            this.listBAccounts.TabIndex = 10;
            this.listBAccounts.Visible = false;
            this.listBAccounts.SelectedIndexChanged += new System.EventHandler(this.listBAccounts_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Already a customer? Chose your name here";
            // 
            // lblSelectAcc
            // 
            this.lblSelectAcc.AutoSize = true;
            this.lblSelectAcc.Location = new System.Drawing.Point(435, 3);
            this.lblSelectAcc.Name = "lblSelectAcc";
            this.lblSelectAcc.Size = new System.Drawing.Size(140, 13);
            this.lblSelectAcc.TabIndex = 12;
            this.lblSelectAcc.Text = "Select one of your accounts";
            this.lblSelectAcc.Visible = false;
            // 
            // pnlOpenAcc
            // 
            this.pnlOpenAcc.Controls.Add(this.label5);
            this.pnlOpenAcc.Controls.Add(this.rBtnNewAccount);
            this.pnlOpenAcc.Controls.Add(this.rBtnNewCustomer);
            this.pnlOpenAcc.Controls.Add(this.label3);
            this.pnlOpenAcc.Controls.Add(this.btnCloseAccountPage);
            this.pnlOpenAcc.Controls.Add(this.lblCongratulations);
            this.pnlOpenAcc.Controls.Add(this.lblOpenAccInfo);
            this.pnlOpenAcc.Controls.Add(this.label14);
            this.pnlOpenAcc.Controls.Add(this.btnConfirmAccReg);
            this.pnlOpenAcc.Controls.Add(this.txtBFDeposit);
            this.pnlOpenAcc.Controls.Add(this.txtBAccName);
            this.pnlOpenAcc.Controls.Add(this.txtBNumb);
            this.pnlOpenAcc.Controls.Add(this.txtBName);
            this.pnlOpenAcc.Controls.Add(this.label8);
            this.pnlOpenAcc.Controls.Add(this.label7);
            this.pnlOpenAcc.Controls.Add(this.label6);
            this.pnlOpenAcc.Controls.Add(this.label4);
            this.pnlOpenAcc.Location = new System.Drawing.Point(8, 132);
            this.pnlOpenAcc.Name = "pnlOpenAcc";
            this.pnlOpenAcc.Size = new System.Drawing.Size(664, 241);
            this.pnlOpenAcc.TabIndex = 13;
            this.pnlOpenAcc.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "I want to register a:";
            // 
            // rBtnNewAccount
            // 
            this.rBtnNewAccount.AutoSize = true;
            this.rBtnNewAccount.Location = new System.Drawing.Point(111, 36);
            this.rBtnNewAccount.Name = "rBtnNewAccount";
            this.rBtnNewAccount.Size = new System.Drawing.Size(89, 17);
            this.rBtnNewAccount.TabIndex = 22;
            this.rBtnNewAccount.TabStop = true;
            this.rBtnNewAccount.Text = "New account";
            this.rBtnNewAccount.UseVisualStyleBackColor = true;
            this.rBtnNewAccount.CheckedChanged += new System.EventHandler(this.rBtnNewAccount_CheckedChanged);
            // 
            // rBtnNewCustomer
            // 
            this.rBtnNewCustomer.AutoSize = true;
            this.rBtnNewCustomer.Location = new System.Drawing.Point(17, 36);
            this.rBtnNewCustomer.Name = "rBtnNewCustomer";
            this.rBtnNewCustomer.Size = new System.Drawing.Size(93, 17);
            this.rBtnNewCustomer.TabIndex = 21;
            this.rBtnNewCustomer.TabStop = true;
            this.rBtnNewCustomer.Text = "New customer";
            this.rBtnNewCustomer.UseVisualStyleBackColor = true;
            this.rBtnNewCustomer.CheckedChanged += new System.EventHandler(this.rBtnNewCustomer_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "that your first deposit is equal to or greater than 1000";
            // 
            // btnCloseAccountPage
            // 
            this.btnCloseAccountPage.Location = new System.Drawing.Point(458, 96);
            this.btnCloseAccountPage.Name = "btnCloseAccountPage";
            this.btnCloseAccountPage.Size = new System.Drawing.Size(109, 23);
            this.btnCloseAccountPage.TabIndex = 19;
            this.btnCloseAccountPage.Text = "Close this page";
            this.btnCloseAccountPage.UseVisualStyleBackColor = true;
            this.btnCloseAccountPage.Visible = false;
            this.btnCloseAccountPage.Click += new System.EventHandler(this.btnCloseAccountPage_Click);
            // 
            // lblCongratulations
            // 
            this.lblCongratulations.AutoSize = true;
            this.lblCongratulations.Location = new System.Drawing.Point(427, 70);
            this.lblCongratulations.Name = "lblCongratulations";
            this.lblCongratulations.Size = new System.Drawing.Size(165, 13);
            this.lblCongratulations.TabIndex = 18;
            this.lblCongratulations.Text = "Congratulations! Account created";
            this.lblCongratulations.Visible = false;
            // 
            // lblOpenAccInfo
            // 
            this.lblOpenAccInfo.AutoSize = true;
            this.lblOpenAccInfo.Location = new System.Drawing.Point(4, 60);
            this.lblOpenAccInfo.Name = "lblOpenAccInfo";
            this.lblOpenAccInfo.Size = new System.Drawing.Size(176, 13);
            this.lblOpenAccInfo.TabIndex = 17;
            this.lblOpenAccInfo.Text = "Make sure you\'ve filled all fields and";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, -2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Open account";
            // 
            // btnConfirmAccReg
            // 
            this.btnConfirmAccReg.Location = new System.Drawing.Point(46, 213);
            this.btnConfirmAccReg.Name = "btnConfirmAccReg";
            this.btnConfirmAccReg.Size = new System.Drawing.Size(192, 23);
            this.btnConfirmAccReg.TabIndex = 10;
            this.btnConfirmAccReg.Text = "Confirm account registration";
            this.btnConfirmAccReg.UseVisualStyleBackColor = true;
            this.btnConfirmAccReg.Click += new System.EventHandler(this.btnConfirmAccReg_Click);
            // 
            // txtBFDeposit
            // 
            this.txtBFDeposit.Location = new System.Drawing.Point(140, 183);
            this.txtBFDeposit.Name = "txtBFDeposit";
            this.txtBFDeposit.Size = new System.Drawing.Size(205, 20);
            this.txtBFDeposit.TabIndex = 9;
            // 
            // txtBAccName
            // 
            this.txtBAccName.Location = new System.Drawing.Point(140, 157);
            this.txtBAccName.Name = "txtBAccName";
            this.txtBAccName.Size = new System.Drawing.Size(205, 20);
            this.txtBAccName.TabIndex = 8;
            // 
            // txtBNumb
            // 
            this.txtBNumb.Location = new System.Drawing.Point(140, 131);
            this.txtBNumb.Name = "txtBNumb";
            this.txtBNumb.Size = new System.Drawing.Size(205, 20);
            this.txtBNumb.TabIndex = 7;
            // 
            // txtBName
            // 
            this.txtBName.Location = new System.Drawing.Point(140, 105);
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(205, 20);
            this.txtBName.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "First deposit amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Account name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Telephone number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            // 
            // pnlDeposit
            // 
            this.pnlDeposit.Controls.Add(this.lblDepositError);
            this.pnlDeposit.Controls.Add(this.btnDepositCancel);
            this.pnlDeposit.Controls.Add(this.btnDepositAccept);
            this.pnlDeposit.Controls.Add(this.lblDepositCurrentBalance);
            this.pnlDeposit.Controls.Add(this.txtBDepositAmount);
            this.pnlDeposit.Controls.Add(this.label18);
            this.pnlDeposit.Controls.Add(this.label17);
            this.pnlDeposit.Controls.Add(this.label16);
            this.pnlDeposit.Location = new System.Drawing.Point(10, 134);
            this.pnlDeposit.Name = "pnlDeposit";
            this.pnlDeposit.Size = new System.Drawing.Size(228, 147);
            this.pnlDeposit.TabIndex = 14;
            this.pnlDeposit.Visible = false;
            // 
            // lblDepositError
            // 
            this.lblDepositError.AutoSize = true;
            this.lblDepositError.Location = new System.Drawing.Point(8, 18);
            this.lblDepositError.Name = "lblDepositError";
            this.lblDepositError.Size = new System.Drawing.Size(140, 13);
            this.lblDepositError.TabIndex = 21;
            this.lblDepositError.Text = "need to select account error";
            // 
            // btnDepositCancel
            // 
            this.btnDepositCancel.Location = new System.Drawing.Point(87, 116);
            this.btnDepositCancel.Name = "btnDepositCancel";
            this.btnDepositCancel.Size = new System.Drawing.Size(75, 23);
            this.btnDepositCancel.TabIndex = 8;
            this.btnDepositCancel.Text = "Cancel";
            this.btnDepositCancel.UseVisualStyleBackColor = true;
            this.btnDepositCancel.Click += new System.EventHandler(this.btnDepositCancel_Click);
            // 
            // btnDepositAccept
            // 
            this.btnDepositAccept.Location = new System.Drawing.Point(6, 116);
            this.btnDepositAccept.Name = "btnDepositAccept";
            this.btnDepositAccept.Size = new System.Drawing.Size(75, 23);
            this.btnDepositAccept.TabIndex = 7;
            this.btnDepositAccept.Text = "Accept";
            this.btnDepositAccept.UseVisualStyleBackColor = true;
            this.btnDepositAccept.Click += new System.EventHandler(this.btnDepositAccept_Click);
            // 
            // lblDepositCurrentBalance
            // 
            this.lblDepositCurrentBalance.AutoSize = true;
            this.lblDepositCurrentBalance.Location = new System.Drawing.Point(94, 41);
            this.lblDepositCurrentBalance.Name = "lblDepositCurrentBalance";
            this.lblDepositCurrentBalance.Size = new System.Drawing.Size(41, 13);
            this.lblDepositCurrentBalance.TabIndex = 5;
            this.lblDepositCurrentBalance.Text = "label20";
            // 
            // txtBDepositAmount
            // 
            this.txtBDepositAmount.Location = new System.Drawing.Point(97, 71);
            this.txtBDepositAmount.Name = "txtBDepositAmount";
            this.txtBDepositAmount.Size = new System.Drawing.Size(100, 20);
            this.txtBDepositAmount.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Deposit amount:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Current Balance:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, -2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Deposit";
            // 
            // pnlWithdraw
            // 
            this.pnlWithdraw.Controls.Add(this.btnWithdrawCancel);
            this.pnlWithdraw.Controls.Add(this.btnWithdrawAccept);
            this.pnlWithdraw.Controls.Add(this.label22);
            this.pnlWithdraw.Controls.Add(this.lblWithdrawCurrentBalance);
            this.pnlWithdraw.Controls.Add(this.txtBWithdrawAmount);
            this.pnlWithdraw.Controls.Add(this.label27);
            this.pnlWithdraw.Controls.Add(this.label26);
            this.pnlWithdraw.Location = new System.Drawing.Point(10, 134);
            this.pnlWithdraw.Name = "pnlWithdraw";
            this.pnlWithdraw.Size = new System.Drawing.Size(216, 183);
            this.pnlWithdraw.TabIndex = 15;
            this.pnlWithdraw.Visible = false;
            // 
            // btnWithdrawCancel
            // 
            this.btnWithdrawCancel.Location = new System.Drawing.Point(89, 157);
            this.btnWithdrawCancel.Name = "btnWithdrawCancel";
            this.btnWithdrawCancel.Size = new System.Drawing.Size(75, 23);
            this.btnWithdrawCancel.TabIndex = 10;
            this.btnWithdrawCancel.Text = "Cancel";
            this.btnWithdrawCancel.UseVisualStyleBackColor = true;
            this.btnWithdrawCancel.Click += new System.EventHandler(this.btnWithdrawCancel_Click);
            // 
            // btnWithdrawAccept
            // 
            this.btnWithdrawAccept.Location = new System.Drawing.Point(8, 156);
            this.btnWithdrawAccept.Name = "btnWithdrawAccept";
            this.btnWithdrawAccept.Size = new System.Drawing.Size(75, 23);
            this.btnWithdrawAccept.TabIndex = 9;
            this.btnWithdrawAccept.Text = "Accept";
            this.btnWithdrawAccept.UseVisualStyleBackColor = true;
            this.btnWithdrawAccept.Click += new System.EventHandler(this.btnWithdrawAccept_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(4, -2);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 13);
            this.label22.TabIndex = 9;
            this.label22.Text = "Withdraw";
            // 
            // lblWithdrawCurrentBalance
            // 
            this.lblWithdrawCurrentBalance.AutoSize = true;
            this.lblWithdrawCurrentBalance.Location = new System.Drawing.Point(100, 36);
            this.lblWithdrawCurrentBalance.Name = "lblWithdrawCurrentBalance";
            this.lblWithdrawCurrentBalance.Size = new System.Drawing.Size(41, 13);
            this.lblWithdrawCurrentBalance.TabIndex = 13;
            this.lblWithdrawCurrentBalance.Text = "label24";
            // 
            // txtBWithdrawAmount
            // 
            this.txtBWithdrawAmount.Location = new System.Drawing.Point(103, 58);
            this.txtBWithdrawAmount.Name = "txtBWithdrawAmount";
            this.txtBWithdrawAmount.Size = new System.Drawing.Size(100, 20);
            this.txtBWithdrawAmount.TabIndex = 12;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(5, 36);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(86, 13);
            this.label27.TabIndex = 9;
            this.label27.Text = "Current Balance:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(4, 61);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(93, 13);
            this.label26.TabIndex = 10;
            this.label26.Text = "Withdraw amount:";
            // 
            // pnlHistory
            // 
            this.pnlHistory.Controls.Add(this.lblHistoryDifference);
            this.pnlHistory.Controls.Add(this.lblHistoryError);
            this.pnlHistory.Controls.Add(this.label31);
            this.pnlHistory.Controls.Add(this.listBHistory);
            this.pnlHistory.Controls.Add(this.label28);
            this.pnlHistory.Location = new System.Drawing.Point(8, 130);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(350, 240);
            this.pnlHistory.TabIndex = 16;
            this.pnlHistory.Visible = false;
            // 
            // lblHistoryError
            // 
            this.lblHistoryError.AutoSize = true;
            this.lblHistoryError.Location = new System.Drawing.Point(16, 22);
            this.lblHistoryError.Name = "lblHistoryError";
            this.lblHistoryError.Size = new System.Drawing.Size(204, 13);
            this.lblHistoryError.TabIndex = 16;
            this.lblHistoryError.Text = "Make sure you have selected an account";
            // 
            // lblHistoryDifference
            // 
            this.lblHistoryDifference.AutoSize = true;
            this.lblHistoryDifference.Location = new System.Drawing.Point(256, 49);
            this.lblHistoryDifference.Name = "lblHistoryDifference";
            this.lblHistoryDifference.Size = new System.Drawing.Size(24, 13);
            this.lblHistoryDifference.TabIndex = 15;
            this.lblHistoryDifference.Text = "n/a";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(196, 49);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(59, 13);
            this.label31.TabIndex = 11;
            this.label31.Text = "Difference:";
            // 
            // listBHistory
            // 
            this.listBHistory.FormattingEnabled = true;
            this.listBHistory.Location = new System.Drawing.Point(19, 49);
            this.listBHistory.Name = "listBHistory";
            this.listBHistory.Size = new System.Drawing.Size(143, 186);
            this.listBHistory.TabIndex = 19;
            this.listBHistory.SelectedIndexChanged += new System.EventHandler(this.listBHistory_SelectedIndexChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(16, -2);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(96, 13);
            this.label28.TabIndex = 18;
            this.label28.Text = "Transaction history";
            // 
            // pnlBalance
            // 
            this.pnlBalance.Controls.Add(this.label9);
            this.pnlBalance.Controls.Add(this.lblBalanceShow);
            this.pnlBalance.Location = new System.Drawing.Point(8, 130);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.Size = new System.Drawing.Size(275, 67);
            this.pnlBalance.TabIndex = 17;
            this.pnlBalance.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, -1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Balance";
            // 
            // lblBalanceShow
            // 
            this.lblBalanceShow.AutoSize = true;
            this.lblBalanceShow.Location = new System.Drawing.Point(14, 29);
            this.lblBalanceShow.Name = "lblBalanceShow";
            this.lblBalanceShow.Size = new System.Drawing.Size(35, 13);
            this.lblBalanceShow.TabIndex = 0;
            this.lblBalanceShow.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 384);
            this.Controls.Add(this.pnlBalance);
            this.Controls.Add(this.pnlHistory);
            this.Controls.Add(this.pnlOpenAcc);
            this.Controls.Add(this.lblSelectAcc);
            this.Controls.Add(this.pnlDeposit);
            this.Controls.Add(this.pnlWithdraw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBAccounts);
            this.Controls.Add(this.listBCustomers);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnOpenAcc);
            this.Controls.Add(this.rBtnEmployee);
            this.Controls.Add(this.rBtnCustomer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlOpenAcc.ResumeLayout(false);
            this.pnlOpenAcc.PerformLayout();
            this.pnlDeposit.ResumeLayout(false);
            this.pnlDeposit.PerformLayout();
            this.pnlWithdraw.ResumeLayout(false);
            this.pnlWithdraw.PerformLayout();
            this.pnlHistory.ResumeLayout(false);
            this.pnlHistory.PerformLayout();
            this.pnlBalance.ResumeLayout(false);
            this.pnlBalance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBtnCustomer;
        private System.Windows.Forms.RadioButton rBtnEmployee;
        private System.Windows.Forms.Button btnOpenAcc;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.ListBox listBCustomers;
        private System.Windows.Forms.ListBox listBAccounts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSelectAcc;
        private System.Windows.Forms.Panel pnlOpenAcc;
        private System.Windows.Forms.Label lblOpenAccInfo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnConfirmAccReg;
        private System.Windows.Forms.TextBox txtBFDeposit;
        private System.Windows.Forms.TextBox txtBAccName;
        private System.Windows.Forms.TextBox txtBNumb;
        private System.Windows.Forms.TextBox txtBName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlDeposit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblDepositError;
        private System.Windows.Forms.Button btnDepositCancel;
        private System.Windows.Forms.Button btnDepositAccept;
        private System.Windows.Forms.Label lblDepositCurrentBalance;
        private System.Windows.Forms.TextBox txtBDepositAmount;
        private System.Windows.Forms.Panel pnlWithdraw;
        private System.Windows.Forms.Button btnWithdrawCancel;
        private System.Windows.Forms.Button btnWithdrawAccept;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblWithdrawCurrentBalance;
        private System.Windows.Forms.TextBox txtBWithdrawAmount;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.Label lblHistoryError;
        private System.Windows.Forms.Label lblHistoryDifference;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ListBox listBHistory;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel pnlBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBalanceShow;
        private System.Windows.Forms.Button btnCloseAccountPage;
        private System.Windows.Forms.Label lblCongratulations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rBtnNewAccount;
        private System.Windows.Forms.RadioButton rBtnNewCustomer;
    }
}

