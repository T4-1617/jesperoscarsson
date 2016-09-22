namespace _22092016_onlineBanking
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
            this.lblOpenAccInfo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblOpenAccDepositError = new System.Windows.Forms.Label();
            this.lblAccNameError = new System.Windows.Forms.Label();
            this.lblNumbError = new System.Windows.Forms.Label();
            this.lblLNameError = new System.Windows.Forms.Label();
            this.lblFNameError = new System.Windows.Forms.Label();
            this.btnConfirmAccReg = new System.Windows.Forms.Button();
            this.txtBFDeposit = new System.Windows.Forms.TextBox();
            this.txtBAccName = new System.Windows.Forms.TextBox();
            this.txtBNumb = new System.Windows.Forms.TextBox();
            this.txtBLName = new System.Windows.Forms.TextBox();
            this.txtBFName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlDeposit = new System.Windows.Forms.Panel();
            this.lblDepositError = new System.Windows.Forms.Label();
            this.btnDepositCancel = new System.Windows.Forms.Button();
            this.btnDepositAccept = new System.Windows.Forms.Button();
            this.lblDepositNewBalance = new System.Windows.Forms.Label();
            this.lblDepositCurrentBalance = new System.Windows.Forms.Label();
            this.txtBDepositAmount = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlWithdraw = new System.Windows.Forms.Panel();
            this.lblWithdrawError = new System.Windows.Forms.Label();
            this.btnWithdrawCancel = new System.Windows.Forms.Button();
            this.btnWithdrawAccept = new System.Windows.Forms.Button();
            this.lblWithdrawNewBalance = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblWithdrawCurrentBalance = new System.Windows.Forms.Label();
            this.txtBWithdrawAmount = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.lblHistoryError = new System.Windows.Forms.Label();
            this.pnlHistoryDetails = new System.Windows.Forms.Panel();
            this.lblHistoryDifference = new System.Windows.Forms.Label();
            this.lblHistoryBalanceAfter = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblHistoryBalanceBefore = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.listBHistory = new System.Windows.Forms.ListBox();
            this.label28 = new System.Windows.Forms.Label();
            this.pnlBalance = new System.Windows.Forms.Panel();
            this.lblPnlBalanceShow = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlOpenAcc.SuspendLayout();
            this.pnlDeposit.SuspendLayout();
            this.pnlWithdraw.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            this.pnlHistoryDetails.SuspendLayout();
            this.pnlBalance.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select role";
            // 
            // rBtnCustomer
            // 
            this.rBtnCustomer.AutoSize = true;
            this.rBtnCustomer.Location = new System.Drawing.Point(335, 21);
            this.rBtnCustomer.Name = "rBtnCustomer";
            this.rBtnCustomer.Size = new System.Drawing.Size(69, 17);
            this.rBtnCustomer.TabIndex = 1;
            this.rBtnCustomer.TabStop = true;
            this.rBtnCustomer.Text = "Customer";
            this.rBtnCustomer.UseVisualStyleBackColor = true;
            // 
            // rBtnEmployee
            // 
            this.rBtnEmployee.AutoSize = true;
            this.rBtnEmployee.Location = new System.Drawing.Point(335, 44);
            this.rBtnEmployee.Name = "rBtnEmployee";
            this.rBtnEmployee.Size = new System.Drawing.Size(71, 17);
            this.rBtnEmployee.TabIndex = 2;
            this.rBtnEmployee.TabStop = true;
            this.rBtnEmployee.Text = "Employee";
            this.rBtnEmployee.UseVisualStyleBackColor = true;
            // 
            // btnOpenAcc
            // 
            this.btnOpenAcc.Location = new System.Drawing.Point(49, 94);
            this.btnOpenAcc.Name = "btnOpenAcc";
            this.btnOpenAcc.Size = new System.Drawing.Size(128, 23);
            this.btnOpenAcc.TabIndex = 3;
            this.btnOpenAcc.Text = "Open account";
            this.btnOpenAcc.UseVisualStyleBackColor = true;
            this.btnOpenAcc.Click += new System.EventHandler(this.btnOpenAcc_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(49, 134);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(128, 23);
            this.btnDeposit.TabIndex = 4;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(49, 210);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(128, 23);
            this.btnBalance.TabIndex = 6;
            this.btnBalance.Text = "Balance";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(49, 252);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(128, 23);
            this.btnHistory.TabIndex = 7;
            this.btnHistory.Text = "Transaction History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(49, 172);
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
            this.listBCustomers.Location = new System.Drawing.Point(49, 304);
            this.listBCustomers.Name = "listBCustomers";
            this.listBCustomers.Size = new System.Drawing.Size(124, 147);
            this.listBCustomers.TabIndex = 9;
            // 
            // listBAccounts
            // 
            this.listBAccounts.FormattingEnabled = true;
            this.listBAccounts.Location = new System.Drawing.Point(49, 495);
            this.listBAccounts.Name = "listBAccounts";
            this.listBAccounts.Size = new System.Drawing.Size(124, 147);
            this.listBAccounts.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select customer";
            // 
            // lblSelectAcc
            // 
            this.lblSelectAcc.AutoSize = true;
            this.lblSelectAcc.Location = new System.Drawing.Point(46, 479);
            this.lblSelectAcc.Name = "lblSelectAcc";
            this.lblSelectAcc.Size = new System.Drawing.Size(79, 13);
            this.lblSelectAcc.TabIndex = 12;
            this.lblSelectAcc.Text = "Select account";
            // 
            // pnlOpenAcc
            // 
            this.pnlOpenAcc.Controls.Add(this.lblOpenAccInfo);
            this.pnlOpenAcc.Controls.Add(this.label14);
            this.pnlOpenAcc.Controls.Add(this.lblOpenAccDepositError);
            this.pnlOpenAcc.Controls.Add(this.lblAccNameError);
            this.pnlOpenAcc.Controls.Add(this.lblNumbError);
            this.pnlOpenAcc.Controls.Add(this.lblLNameError);
            this.pnlOpenAcc.Controls.Add(this.lblFNameError);
            this.pnlOpenAcc.Controls.Add(this.btnConfirmAccReg);
            this.pnlOpenAcc.Controls.Add(this.txtBFDeposit);
            this.pnlOpenAcc.Controls.Add(this.txtBAccName);
            this.pnlOpenAcc.Controls.Add(this.txtBNumb);
            this.pnlOpenAcc.Controls.Add(this.txtBLName);
            this.pnlOpenAcc.Controls.Add(this.txtBFName);
            this.pnlOpenAcc.Controls.Add(this.label8);
            this.pnlOpenAcc.Controls.Add(this.label7);
            this.pnlOpenAcc.Controls.Add(this.label6);
            this.pnlOpenAcc.Controls.Add(this.label5);
            this.pnlOpenAcc.Controls.Add(this.label4);
            this.pnlOpenAcc.Location = new System.Drawing.Point(217, 100);
            this.pnlOpenAcc.Name = "pnlOpenAcc";
            this.pnlOpenAcc.Size = new System.Drawing.Size(287, 241);
            this.pnlOpenAcc.TabIndex = 13;
            this.pnlOpenAcc.Visible = false;
            // 
            // lblOpenAccInfo
            // 
            this.lblOpenAccInfo.AutoSize = true;
            this.lblOpenAccInfo.Location = new System.Drawing.Point(19, 32);
            this.lblOpenAccInfo.Name = "lblOpenAccInfo";
            this.lblOpenAccInfo.Size = new System.Drawing.Size(156, 13);
            this.lblOpenAccInfo.TabIndex = 17;
            this.lblOpenAccInfo.Text = "you need to make sure jsdiofjod";
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
            // lblOpenAccDepositError
            // 
            this.lblOpenAccDepositError.AutoSize = true;
            this.lblOpenAccDepositError.Location = new System.Drawing.Point(239, 179);
            this.lblOpenAccDepositError.Name = "lblOpenAccDepositError";
            this.lblOpenAccDepositError.Size = new System.Drawing.Size(41, 13);
            this.lblOpenAccDepositError.TabIndex = 15;
            this.lblOpenAccDepositError.Text = "label13";
            // 
            // lblAccNameError
            // 
            this.lblAccNameError.AutoSize = true;
            this.lblAccNameError.Location = new System.Drawing.Point(240, 148);
            this.lblAccNameError.Name = "lblAccNameError";
            this.lblAccNameError.Size = new System.Drawing.Size(41, 13);
            this.lblAccNameError.TabIndex = 14;
            this.lblAccNameError.Text = "label12";
            // 
            // lblNumbError
            // 
            this.lblNumbError.AutoSize = true;
            this.lblNumbError.Location = new System.Drawing.Point(241, 124);
            this.lblNumbError.Name = "lblNumbError";
            this.lblNumbError.Size = new System.Drawing.Size(41, 13);
            this.lblNumbError.TabIndex = 13;
            this.lblNumbError.Text = "label11";
            // 
            // lblLNameError
            // 
            this.lblLNameError.AutoSize = true;
            this.lblLNameError.Location = new System.Drawing.Point(241, 95);
            this.lblLNameError.Name = "lblLNameError";
            this.lblLNameError.Size = new System.Drawing.Size(41, 13);
            this.lblLNameError.TabIndex = 12;
            this.lblLNameError.Text = "label10";
            // 
            // lblFNameError
            // 
            this.lblFNameError.AutoSize = true;
            this.lblFNameError.Location = new System.Drawing.Point(242, 66);
            this.lblFNameError.Name = "lblFNameError";
            this.lblFNameError.Size = new System.Drawing.Size(35, 13);
            this.lblFNameError.TabIndex = 11;
            this.lblFNameError.Text = "label9";
            // 
            // btnConfirmAccReg
            // 
            this.btnConfirmAccReg.Location = new System.Drawing.Point(34, 202);
            this.btnConfirmAccReg.Name = "btnConfirmAccReg";
            this.btnConfirmAccReg.Size = new System.Drawing.Size(192, 23);
            this.btnConfirmAccReg.TabIndex = 10;
            this.btnConfirmAccReg.Text = "Confirm account registration";
            this.btnConfirmAccReg.UseVisualStyleBackColor = true;
            this.btnConfirmAccReg.Click += new System.EventHandler(this.btnConfirmAccReg_Click);
            // 
            // txtBFDeposit
            // 
            this.txtBFDeposit.Location = new System.Drawing.Point(135, 176);
            this.txtBFDeposit.Name = "txtBFDeposit";
            this.txtBFDeposit.Size = new System.Drawing.Size(100, 20);
            this.txtBFDeposit.TabIndex = 9;
            // 
            // txtBAccName
            // 
            this.txtBAccName.Location = new System.Drawing.Point(135, 145);
            this.txtBAccName.Name = "txtBAccName";
            this.txtBAccName.Size = new System.Drawing.Size(100, 20);
            this.txtBAccName.TabIndex = 8;
            // 
            // txtBNumb
            // 
            this.txtBNumb.Location = new System.Drawing.Point(135, 119);
            this.txtBNumb.Name = "txtBNumb";
            this.txtBNumb.Size = new System.Drawing.Size(100, 20);
            this.txtBNumb.TabIndex = 7;
            // 
            // txtBLName
            // 
            this.txtBLName.Location = new System.Drawing.Point(135, 93);
            this.txtBLName.Name = "txtBLName";
            this.txtBLName.Size = new System.Drawing.Size(100, 20);
            this.txtBLName.TabIndex = 6;
            // 
            // txtBFName
            // 
            this.txtBFName.Location = new System.Drawing.Point(135, 62);
            this.txtBFName.Name = "txtBFName";
            this.txtBFName.Size = new System.Drawing.Size(100, 20);
            this.txtBFName.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "First deposit amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Account name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "First name";
            // 
            // pnlDeposit
            // 
            this.pnlDeposit.Controls.Add(this.lblDepositError);
            this.pnlDeposit.Controls.Add(this.btnDepositCancel);
            this.pnlDeposit.Controls.Add(this.btnDepositAccept);
            this.pnlDeposit.Controls.Add(this.lblDepositNewBalance);
            this.pnlDeposit.Controls.Add(this.lblDepositCurrentBalance);
            this.pnlDeposit.Controls.Add(this.txtBDepositAmount);
            this.pnlDeposit.Controls.Add(this.label19);
            this.pnlDeposit.Controls.Add(this.label18);
            this.pnlDeposit.Controls.Add(this.label17);
            this.pnlDeposit.Controls.Add(this.label16);
            this.pnlDeposit.Location = new System.Drawing.Point(218, 347);
            this.pnlDeposit.Name = "pnlDeposit";
            this.pnlDeposit.Size = new System.Drawing.Size(286, 178);
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
            this.btnDepositCancel.Location = new System.Drawing.Point(109, 145);
            this.btnDepositCancel.Name = "btnDepositCancel";
            this.btnDepositCancel.Size = new System.Drawing.Size(75, 23);
            this.btnDepositCancel.TabIndex = 8;
            this.btnDepositCancel.Text = "Cancel";
            this.btnDepositCancel.UseVisualStyleBackColor = true;
            // 
            // btnDepositAccept
            // 
            this.btnDepositAccept.Location = new System.Drawing.Point(28, 145);
            this.btnDepositAccept.Name = "btnDepositAccept";
            this.btnDepositAccept.Size = new System.Drawing.Size(75, 23);
            this.btnDepositAccept.TabIndex = 7;
            this.btnDepositAccept.Text = "Accept";
            this.btnDepositAccept.UseVisualStyleBackColor = true;
            // 
            // lblDepositNewBalance
            // 
            this.lblDepositNewBalance.AutoSize = true;
            this.lblDepositNewBalance.Location = new System.Drawing.Point(111, 118);
            this.lblDepositNewBalance.Name = "lblDepositNewBalance";
            this.lblDepositNewBalance.Size = new System.Drawing.Size(41, 13);
            this.lblDepositNewBalance.TabIndex = 6;
            this.lblDepositNewBalance.Text = "label21";
            // 
            // lblDepositCurrentBalance
            // 
            this.lblDepositCurrentBalance.AutoSize = true;
            this.lblDepositCurrentBalance.Location = new System.Drawing.Point(111, 41);
            this.lblDepositCurrentBalance.Name = "lblDepositCurrentBalance";
            this.lblDepositCurrentBalance.Size = new System.Drawing.Size(41, 13);
            this.lblDepositCurrentBalance.TabIndex = 5;
            this.lblDepositCurrentBalance.Text = "label20";
            // 
            // txtBDepositAmount
            // 
            this.txtBDepositAmount.Location = new System.Drawing.Point(113, 77);
            this.txtBDepositAmount.Name = "txtBDepositAmount";
            this.txtBDepositAmount.Size = new System.Drawing.Size(100, 20);
            this.txtBDepositAmount.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 118);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "New balance";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Deposit amount";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Current Balance";
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
            this.pnlWithdraw.Controls.Add(this.lblWithdrawError);
            this.pnlWithdraw.Controls.Add(this.btnWithdrawCancel);
            this.pnlWithdraw.Controls.Add(this.btnWithdrawAccept);
            this.pnlWithdraw.Controls.Add(this.lblWithdrawNewBalance);
            this.pnlWithdraw.Controls.Add(this.label22);
            this.pnlWithdraw.Controls.Add(this.lblWithdrawCurrentBalance);
            this.pnlWithdraw.Controls.Add(this.txtBWithdrawAmount);
            this.pnlWithdraw.Controls.Add(this.label27);
            this.pnlWithdraw.Controls.Add(this.label25);
            this.pnlWithdraw.Controls.Add(this.label26);
            this.pnlWithdraw.Location = new System.Drawing.Point(219, 532);
            this.pnlWithdraw.Name = "pnlWithdraw";
            this.pnlWithdraw.Size = new System.Drawing.Size(285, 183);
            this.pnlWithdraw.TabIndex = 15;
            this.pnlWithdraw.Visible = false;
            // 
            // lblWithdrawError
            // 
            this.lblWithdrawError.AutoSize = true;
            this.lblWithdrawError.Location = new System.Drawing.Point(7, 14);
            this.lblWithdrawError.Name = "lblWithdrawError";
            this.lblWithdrawError.Size = new System.Drawing.Size(140, 13);
            this.lblWithdrawError.TabIndex = 22;
            this.lblWithdrawError.Text = "need to select account error";
            // 
            // btnWithdrawCancel
            // 
            this.btnWithdrawCancel.Location = new System.Drawing.Point(109, 150);
            this.btnWithdrawCancel.Name = "btnWithdrawCancel";
            this.btnWithdrawCancel.Size = new System.Drawing.Size(75, 23);
            this.btnWithdrawCancel.TabIndex = 10;
            this.btnWithdrawCancel.Text = "Cancel";
            this.btnWithdrawCancel.UseVisualStyleBackColor = true;
            // 
            // btnWithdrawAccept
            // 
            this.btnWithdrawAccept.Location = new System.Drawing.Point(28, 150);
            this.btnWithdrawAccept.Name = "btnWithdrawAccept";
            this.btnWithdrawAccept.Size = new System.Drawing.Size(75, 23);
            this.btnWithdrawAccept.TabIndex = 9;
            this.btnWithdrawAccept.Text = "Accept";
            this.btnWithdrawAccept.UseVisualStyleBackColor = true;
            // 
            // lblWithdrawNewBalance
            // 
            this.lblWithdrawNewBalance.AutoSize = true;
            this.lblWithdrawNewBalance.Location = new System.Drawing.Point(111, 113);
            this.lblWithdrawNewBalance.Name = "lblWithdrawNewBalance";
            this.lblWithdrawNewBalance.Size = new System.Drawing.Size(41, 13);
            this.lblWithdrawNewBalance.TabIndex = 14;
            this.lblWithdrawNewBalance.Text = "label23";
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
            this.lblWithdrawCurrentBalance.Location = new System.Drawing.Point(111, 36);
            this.lblWithdrawCurrentBalance.Name = "lblWithdrawCurrentBalance";
            this.lblWithdrawCurrentBalance.Size = new System.Drawing.Size(41, 13);
            this.lblWithdrawCurrentBalance.TabIndex = 13;
            this.lblWithdrawCurrentBalance.Text = "label24";
            // 
            // txtBWithdrawAmount
            // 
            this.txtBWithdrawAmount.Location = new System.Drawing.Point(118, 72);
            this.txtBWithdrawAmount.Name = "txtBWithdrawAmount";
            this.txtBWithdrawAmount.Size = new System.Drawing.Size(100, 20);
            this.txtBWithdrawAmount.TabIndex = 12;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(5, 36);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(83, 13);
            this.label27.TabIndex = 9;
            this.label27.Text = "Current Balance";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(7, 113);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(70, 13);
            this.label25.TabIndex = 11;
            this.label25.Text = "New balance";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(5, 68);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(90, 13);
            this.label26.TabIndex = 10;
            this.label26.Text = "Withdraw amount";
            // 
            // pnlHistory
            // 
            this.pnlHistory.Controls.Add(this.lblHistoryError);
            this.pnlHistory.Controls.Add(this.pnlHistoryDetails);
            this.pnlHistory.Controls.Add(this.listBHistory);
            this.pnlHistory.Controls.Add(this.label28);
            this.pnlHistory.Location = new System.Drawing.Point(510, 172);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(354, 240);
            this.pnlHistory.TabIndex = 16;
            this.pnlHistory.Visible = false;
            // 
            // lblHistoryError
            // 
            this.lblHistoryError.AutoSize = true;
            this.lblHistoryError.Location = new System.Drawing.Point(16, 31);
            this.lblHistoryError.Name = "lblHistoryError";
            this.lblHistoryError.Size = new System.Drawing.Size(140, 13);
            this.lblHistoryError.TabIndex = 16;
            this.lblHistoryError.Text = "need to select account error";
            // 
            // pnlHistoryDetails
            // 
            this.pnlHistoryDetails.Controls.Add(this.lblHistoryDifference);
            this.pnlHistoryDetails.Controls.Add(this.lblHistoryBalanceAfter);
            this.pnlHistoryDetails.Controls.Add(this.label33);
            this.pnlHistoryDetails.Controls.Add(this.lblHistoryBalanceBefore);
            this.pnlHistoryDetails.Controls.Add(this.label32);
            this.pnlHistoryDetails.Controls.Add(this.label31);
            this.pnlHistoryDetails.Location = new System.Drawing.Point(175, 50);
            this.pnlHistoryDetails.Name = "pnlHistoryDetails";
            this.pnlHistoryDetails.Size = new System.Drawing.Size(159, 185);
            this.pnlHistoryDetails.TabIndex = 20;
            // 
            // lblHistoryDifference
            // 
            this.lblHistoryDifference.AutoSize = true;
            this.lblHistoryDifference.Location = new System.Drawing.Point(86, 123);
            this.lblHistoryDifference.Name = "lblHistoryDifference";
            this.lblHistoryDifference.Size = new System.Drawing.Size(41, 13);
            this.lblHistoryDifference.TabIndex = 15;
            this.lblHistoryDifference.Text = "label34";
            // 
            // lblHistoryBalanceAfter
            // 
            this.lblHistoryBalanceAfter.AutoSize = true;
            this.lblHistoryBalanceAfter.Location = new System.Drawing.Point(86, 78);
            this.lblHistoryBalanceAfter.Name = "lblHistoryBalanceAfter";
            this.lblHistoryBalanceAfter.Size = new System.Drawing.Size(41, 13);
            this.lblHistoryBalanceAfter.TabIndex = 14;
            this.lblHistoryBalanceAfter.Text = "label29";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(3, 31);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(79, 13);
            this.label33.TabIndex = 9;
            this.label33.Text = "Balance before";
            // 
            // lblHistoryBalanceBefore
            // 
            this.lblHistoryBalanceBefore.AutoSize = true;
            this.lblHistoryBalanceBefore.Location = new System.Drawing.Point(86, 32);
            this.lblHistoryBalanceBefore.Name = "lblHistoryBalanceBefore";
            this.lblHistoryBalanceBefore.Size = new System.Drawing.Size(41, 13);
            this.lblHistoryBalanceBefore.TabIndex = 13;
            this.lblHistoryBalanceBefore.Text = "label30";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(3, 77);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(70, 13);
            this.label32.TabIndex = 10;
            this.label32.Text = "Balance after";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(5, 122);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(56, 13);
            this.label31.TabIndex = 11;
            this.label31.Text = "Difference";
            // 
            // listBHistory
            // 
            this.listBHistory.FormattingEnabled = true;
            this.listBHistory.Location = new System.Drawing.Point(19, 49);
            this.listBHistory.Name = "listBHistory";
            this.listBHistory.Size = new System.Drawing.Size(143, 186);
            this.listBHistory.TabIndex = 19;
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
            this.pnlBalance.Controls.Add(this.lblPnlBalanceShow);
            this.pnlBalance.Location = new System.Drawing.Point(510, 99);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.Size = new System.Drawing.Size(354, 67);
            this.pnlBalance.TabIndex = 17;
            this.pnlBalance.Visible = false;
            // 
            // lblPnlBalanceShow
            // 
            this.lblPnlBalanceShow.AutoSize = true;
            this.lblPnlBalanceShow.Location = new System.Drawing.Point(14, 33);
            this.lblPnlBalanceShow.Name = "lblPnlBalanceShow";
            this.lblPnlBalanceShow.Size = new System.Drawing.Size(35, 13);
            this.lblPnlBalanceShow.TabIndex = 0;
            this.lblPnlBalanceShow.Text = "label3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Balance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 909);
            this.Controls.Add(this.pnlBalance);
            this.Controls.Add(this.pnlHistory);
            this.Controls.Add(this.pnlWithdraw);
            this.Controls.Add(this.pnlDeposit);
            this.Controls.Add(this.pnlOpenAcc);
            this.Controls.Add(this.lblSelectAcc);
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
            this.pnlHistoryDetails.ResumeLayout(false);
            this.pnlHistoryDetails.PerformLayout();
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
        private System.Windows.Forms.Label lblOpenAccDepositError;
        private System.Windows.Forms.Label lblAccNameError;
        private System.Windows.Forms.Label lblNumbError;
        private System.Windows.Forms.Label lblLNameError;
        private System.Windows.Forms.Label lblFNameError;
        private System.Windows.Forms.Button btnConfirmAccReg;
        private System.Windows.Forms.TextBox txtBFDeposit;
        private System.Windows.Forms.TextBox txtBAccName;
        private System.Windows.Forms.TextBox txtBNumb;
        private System.Windows.Forms.TextBox txtBLName;
        private System.Windows.Forms.TextBox txtBFName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlDeposit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblDepositError;
        private System.Windows.Forms.Button btnDepositCancel;
        private System.Windows.Forms.Button btnDepositAccept;
        private System.Windows.Forms.Label lblDepositNewBalance;
        private System.Windows.Forms.Label lblDepositCurrentBalance;
        private System.Windows.Forms.TextBox txtBDepositAmount;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel pnlWithdraw;
        private System.Windows.Forms.Label lblWithdrawError;
        private System.Windows.Forms.Button btnWithdrawCancel;
        private System.Windows.Forms.Button btnWithdrawAccept;
        private System.Windows.Forms.Label lblWithdrawNewBalance;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblWithdrawCurrentBalance;
        private System.Windows.Forms.TextBox txtBWithdrawAmount;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.Label lblHistoryError;
        private System.Windows.Forms.Panel pnlHistoryDetails;
        private System.Windows.Forms.Label lblHistoryDifference;
        private System.Windows.Forms.Label lblHistoryBalanceAfter;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblHistoryBalanceBefore;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ListBox listBHistory;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel pnlBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPnlBalanceShow;
    }
}

