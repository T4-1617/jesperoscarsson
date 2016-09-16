namespace ACNECARS
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblCarsAvailable = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowCars = new System.Windows.Forms.Button();
            this.btnShowAddCar = new System.Windows.Forms.Button();
            this.btnReturnCar = new System.Windows.Forms.Button();
            this.pnlShowCars = new System.Windows.Forms.Panel();
            this.btnBook = new System.Windows.Forms.Button();
            this.pnlCarInfo = new System.Windows.Forms.Panel();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAvailableCars = new System.Windows.Forms.Label();
            this.listBoxAvailableCarsList = new System.Windows.Forms.ListBox();
            this.pnlAddCar = new System.Windows.Forms.Panel();
            this.btnCarAdd = new System.Windows.Forms.Button();
            this.txtBoxColor = new System.Windows.Forms.TextBox();
            this.txtBoxModel = new System.Windows.Forms.TextBox();
            this.txtBoxMake = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlReturnCar = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.listBoxReturn = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlPersDetails = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxFName = new System.Windows.Forms.TextBox();
            this.txtBoxLName = new System.Windows.Forms.TextBox();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnViewCustomers = new System.Windows.Forms.Button();
            this.pnlCustomerInfo = new System.Windows.Forms.Panel();
            this.listBoxCustomerInfo = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pnlShowCars.SuspendLayout();
            this.pnlCarInfo.SuspendLayout();
            this.pnlAddCar.SuspendLayout();
            this.pnlReturnCar.SuspendLayout();
            this.pnlPersDetails.SuspendLayout();
            this.pnlCustomerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACNE CARS v.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(22, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "We have";
            // 
            // lblCarsAvailable
            // 
            this.lblCarsAvailable.AutoSize = true;
            this.lblCarsAvailable.Location = new System.Drawing.Point(69, 34);
            this.lblCarsAvailable.Name = "lblCarsAvailable";
            this.lblCarsAvailable.Size = new System.Drawing.Size(0, 13);
            this.lblCarsAvailable.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(88, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "cars available";
            // 
            // btnShowCars
            // 
            this.btnShowCars.Location = new System.Drawing.Point(3, 65);
            this.btnShowCars.Name = "btnShowCars";
            this.btnShowCars.Size = new System.Drawing.Size(75, 23);
            this.btnShowCars.TabIndex = 4;
            this.btnShowCars.Text = "Show cars";
            this.btnShowCars.UseVisualStyleBackColor = true;
            this.btnShowCars.Click += new System.EventHandler(this.btnShowCars_Click);
            // 
            // btnShowAddCar
            // 
            this.btnShowAddCar.Location = new System.Drawing.Point(84, 65);
            this.btnShowAddCar.Name = "btnShowAddCar";
            this.btnShowAddCar.Size = new System.Drawing.Size(75, 23);
            this.btnShowAddCar.TabIndex = 5;
            this.btnShowAddCar.Text = "Add car";
            this.btnShowAddCar.UseVisualStyleBackColor = true;
            this.btnShowAddCar.Click += new System.EventHandler(this.btnShowAddCar_Click);
            // 
            // btnReturnCar
            // 
            this.btnReturnCar.Location = new System.Drawing.Point(165, 65);
            this.btnReturnCar.Name = "btnReturnCar";
            this.btnReturnCar.Size = new System.Drawing.Size(75, 23);
            this.btnReturnCar.TabIndex = 6;
            this.btnReturnCar.Text = "Return car";
            this.btnReturnCar.UseVisualStyleBackColor = true;
            this.btnReturnCar.Click += new System.EventHandler(this.btnReturnCar_Click);
            // 
            // pnlShowCars
            // 
            this.pnlShowCars.BackColor = System.Drawing.SystemColors.Control;
            this.pnlShowCars.Controls.Add(this.pnlPersDetails);
            this.pnlShowCars.Controls.Add(this.btnBook);
            this.pnlShowCars.Controls.Add(this.pnlCarInfo);
            this.pnlShowCars.Controls.Add(this.lblAvailableCars);
            this.pnlShowCars.Controls.Add(this.listBoxAvailableCarsList);
            this.pnlShowCars.Location = new System.Drawing.Point(12, 94);
            this.pnlShowCars.Name = "pnlShowCars";
            this.pnlShowCars.Size = new System.Drawing.Size(337, 347);
            this.pnlShowCars.TabIndex = 7;
            this.pnlShowCars.Visible = false;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBook.Location = new System.Drawing.Point(179, 309);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(104, 32);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Visible = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // pnlCarInfo
            // 
            this.pnlCarInfo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCarInfo.Controls.Add(this.lblColor);
            this.pnlCarInfo.Controls.Add(this.lblMake);
            this.pnlCarInfo.Controls.Add(this.lblModel);
            this.pnlCarInfo.Controls.Add(this.label6);
            this.pnlCarInfo.Controls.Add(this.label5);
            this.pnlCarInfo.Controls.Add(this.label3);
            this.pnlCarInfo.Location = new System.Drawing.Point(129, 25);
            this.pnlCarInfo.Name = "pnlCarInfo";
            this.pnlCarInfo.Size = new System.Drawing.Size(200, 140);
            this.pnlCarInfo.TabIndex = 2;
            this.pnlCarInfo.Visible = false;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(64, 66);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(0, 13);
            this.lblColor.TabIndex = 5;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(66, 44);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(0, 13);
            this.lblMake.TabIndex = 4;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(66, 22);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(0, 13);
            this.lblModel.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Make:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Model:";
            // 
            // lblAvailableCars
            // 
            this.lblAvailableCars.AutoSize = true;
            this.lblAvailableCars.Location = new System.Drawing.Point(3, 9);
            this.lblAvailableCars.Name = "lblAvailableCars";
            this.lblAvailableCars.Size = new System.Drawing.Size(74, 13);
            this.lblAvailableCars.TabIndex = 1;
            this.lblAvailableCars.Text = "Available Cars";
            // 
            // listBoxAvailableCarsList
            // 
            this.listBoxAvailableCarsList.FormattingEnabled = true;
            this.listBoxAvailableCarsList.Location = new System.Drawing.Point(3, 25);
            this.listBoxAvailableCarsList.Name = "listBoxAvailableCarsList";
            this.listBoxAvailableCarsList.Size = new System.Drawing.Size(120, 316);
            this.listBoxAvailableCarsList.TabIndex = 0;
            this.listBoxAvailableCarsList.SelectedIndexChanged += new System.EventHandler(this.listBoxAvailableCarsList_SelectedIndexChanged);
            // 
            // pnlAddCar
            // 
            this.pnlAddCar.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAddCar.Controls.Add(this.btnCarAdd);
            this.pnlAddCar.Controls.Add(this.txtBoxColor);
            this.pnlAddCar.Controls.Add(this.txtBoxModel);
            this.pnlAddCar.Controls.Add(this.txtBoxMake);
            this.pnlAddCar.Controls.Add(this.label10);
            this.pnlAddCar.Controls.Add(this.label9);
            this.pnlAddCar.Controls.Add(this.label8);
            this.pnlAddCar.Controls.Add(this.label7);
            this.pnlAddCar.Location = new System.Drawing.Point(12, 94);
            this.pnlAddCar.Name = "pnlAddCar";
            this.pnlAddCar.Size = new System.Drawing.Size(160, 121);
            this.pnlAddCar.TabIndex = 8;
            this.pnlAddCar.Visible = false;
            // 
            // btnCarAdd
            // 
            this.btnCarAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCarAdd.Location = new System.Drawing.Point(51, 92);
            this.btnCarAdd.Name = "btnCarAdd";
            this.btnCarAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCarAdd.TabIndex = 7;
            this.btnCarAdd.Text = "Add";
            this.btnCarAdd.UseVisualStyleBackColor = false;
            this.btnCarAdd.Click += new System.EventHandler(this.btnCarAdd_Click);
            // 
            // txtBoxColor
            // 
            this.txtBoxColor.Location = new System.Drawing.Point(51, 66);
            this.txtBoxColor.Name = "txtBoxColor";
            this.txtBoxColor.Size = new System.Drawing.Size(100, 20);
            this.txtBoxColor.TabIndex = 6;
            // 
            // txtBoxModel
            // 
            this.txtBoxModel.Location = new System.Drawing.Point(51, 44);
            this.txtBoxModel.Name = "txtBoxModel";
            this.txtBoxModel.Size = new System.Drawing.Size(100, 20);
            this.txtBoxModel.TabIndex = 5;
            // 
            // txtBoxMake
            // 
            this.txtBoxMake.Location = new System.Drawing.Point(51, 22);
            this.txtBoxMake.Name = "txtBoxMake";
            this.txtBoxMake.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMake.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Color";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Model";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Make";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Add a Car";
            // 
            // pnlReturnCar
            // 
            this.pnlReturnCar.BackColor = System.Drawing.SystemColors.Control;
            this.pnlReturnCar.Controls.Add(this.btnReturn);
            this.pnlReturnCar.Controls.Add(this.listBoxReturn);
            this.pnlReturnCar.Controls.Add(this.label11);
            this.pnlReturnCar.Location = new System.Drawing.Point(12, 94);
            this.pnlReturnCar.Name = "pnlReturnCar";
            this.pnlReturnCar.Size = new System.Drawing.Size(138, 181);
            this.pnlReturnCar.TabIndex = 9;
            this.pnlReturnCar.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReturn.Location = new System.Drawing.Point(30, 154);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return Car";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // listBoxReturn
            // 
            this.listBoxReturn.FormattingEnabled = true;
            this.listBoxReturn.Location = new System.Drawing.Point(6, 27);
            this.listBoxReturn.Name = "listBoxReturn";
            this.listBoxReturn.Size = new System.Drawing.Size(125, 121);
            this.listBoxReturn.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Cars to Return";
            // 
            // pnlPersDetails
            // 
            this.pnlPersDetails.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPersDetails.Controls.Add(this.label15);
            this.pnlPersDetails.Controls.Add(this.txtBoxNumber);
            this.pnlPersDetails.Controls.Add(this.txtBoxLName);
            this.pnlPersDetails.Controls.Add(this.txtBoxFName);
            this.pnlPersDetails.Controls.Add(this.label16);
            this.pnlPersDetails.Controls.Add(this.label14);
            this.pnlPersDetails.Controls.Add(this.label13);
            this.pnlPersDetails.Controls.Add(this.label12);
            this.pnlPersDetails.Location = new System.Drawing.Point(129, 171);
            this.pnlPersDetails.Name = "pnlPersDetails";
            this.pnlPersDetails.Size = new System.Drawing.Size(200, 106);
            this.pnlPersDetails.TabIndex = 10;
            this.pnlPersDetails.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Telephone*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Last name*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "First name*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Personal Details";
            // 
            // txtBoxFName
            // 
            this.txtBoxFName.Location = new System.Drawing.Point(72, 32);
            this.txtBoxFName.Name = "txtBoxFName";
            this.txtBoxFName.Size = new System.Drawing.Size(125, 20);
            this.txtBoxFName.TabIndex = 5;
            // 
            // txtBoxLName
            // 
            this.txtBoxLName.Location = new System.Drawing.Point(72, 55);
            this.txtBoxLName.Name = "txtBoxLName";
            this.txtBoxLName.Size = new System.Drawing.Size(125, 20);
            this.txtBoxLName.TabIndex = 6;
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Location = new System.Drawing.Point(72, 80);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(125, 20);
            this.txtBoxNumber.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(113, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "* Required fields";
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.Location = new System.Drawing.Point(246, 65);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Size = new System.Drawing.Size(110, 23);
            this.btnViewCustomers.TabIndex = 10;
            this.btnViewCustomers.Text = "View Customers";
            this.btnViewCustomers.UseVisualStyleBackColor = true;
            this.btnViewCustomers.Click += new System.EventHandler(this.btnViewCustomers_Click);
            // 
            // pnlCustomerInfo
            // 
            this.pnlCustomerInfo.Controls.Add(this.label17);
            this.pnlCustomerInfo.Controls.Add(this.listBoxCustomerInfo);
            this.pnlCustomerInfo.Location = new System.Drawing.Point(12, 94);
            this.pnlCustomerInfo.Name = "pnlCustomerInfo";
            this.pnlCustomerInfo.Size = new System.Drawing.Size(337, 208);
            this.pnlCustomerInfo.TabIndex = 11;
            this.pnlCustomerInfo.Visible = false;
            // 
            // listBoxCustomerInfo
            // 
            this.listBoxCustomerInfo.FormattingEnabled = true;
            this.listBoxCustomerInfo.Location = new System.Drawing.Point(3, 27);
            this.listBoxCustomerInfo.Name = "listBoxCustomerInfo";
            this.listBoxCustomerInfo.Size = new System.Drawing.Size(331, 173);
            this.listBoxCustomerInfo.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Customer Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(358, 453);
            this.Controls.Add(this.pnlCustomerInfo);
            this.Controls.Add(this.btnViewCustomers);
            this.Controls.Add(this.pnlReturnCar);
            this.Controls.Add(this.pnlAddCar);
            this.Controls.Add(this.pnlShowCars);
            this.Controls.Add(this.btnReturnCar);
            this.Controls.Add(this.btnShowAddCar);
            this.Controls.Add(this.btnShowCars);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCarsAvailable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlShowCars.ResumeLayout(false);
            this.pnlShowCars.PerformLayout();
            this.pnlCarInfo.ResumeLayout(false);
            this.pnlCarInfo.PerformLayout();
            this.pnlAddCar.ResumeLayout(false);
            this.pnlAddCar.PerformLayout();
            this.pnlReturnCar.ResumeLayout(false);
            this.pnlReturnCar.PerformLayout();
            this.pnlPersDetails.ResumeLayout(false);
            this.pnlPersDetails.PerformLayout();
            this.pnlCustomerInfo.ResumeLayout(false);
            this.pnlCustomerInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCarsAvailable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShowCars;
        private System.Windows.Forms.Button btnShowAddCar;
        private System.Windows.Forms.Button btnReturnCar;
        private System.Windows.Forms.Panel pnlShowCars;
        private System.Windows.Forms.Panel pnlCarInfo;
        private System.Windows.Forms.Label lblAvailableCars;
        private System.Windows.Forms.ListBox listBoxAvailableCarsList;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlAddCar;
        private System.Windows.Forms.Button btnCarAdd;
        private System.Windows.Forms.TextBox txtBoxColor;
        private System.Windows.Forms.TextBox txtBoxModel;
        private System.Windows.Forms.TextBox txtBoxMake;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlReturnCar;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox listBoxReturn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlPersDetails;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.TextBox txtBoxLName;
        private System.Windows.Forms.TextBox txtBoxFName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnViewCustomers;
        private System.Windows.Forms.Panel pnlCustomerInfo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox listBoxCustomerInfo;
    }
}

