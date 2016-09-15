namespace CustomerAndEmpolyeeTracker
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
            this.txtBoxFName = new System.Windows.Forms.TextBox();
            this.txtBoxLName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rdbtnCustomer = new System.Windows.Forms.RadioButton();
            this.rdbtnEmployee = new System.Windows.Forms.RadioButton();
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxFName
            // 
            this.txtBoxFName.Location = new System.Drawing.Point(74, 34);
            this.txtBoxFName.Name = "txtBoxFName";
            this.txtBoxFName.Size = new System.Drawing.Size(158, 20);
            this.txtBoxFName.TabIndex = 0;
            // 
            // txtBoxLName
            // 
            this.txtBoxLName.Location = new System.Drawing.Point(74, 70);
            this.txtBoxLName.Name = "txtBoxLName";
            this.txtBoxLName.Size = new System.Drawing.Size(158, 20);
            this.txtBoxLName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(183, 113);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rdbtnCustomer
            // 
            this.rdbtnCustomer.AutoSize = true;
            this.rdbtnCustomer.Location = new System.Drawing.Point(15, 116);
            this.rdbtnCustomer.Name = "rdbtnCustomer";
            this.rdbtnCustomer.Size = new System.Drawing.Size(69, 17);
            this.rdbtnCustomer.TabIndex = 3;
            this.rdbtnCustomer.TabStop = true;
            this.rdbtnCustomer.Text = "Customer";
            this.rdbtnCustomer.UseVisualStyleBackColor = true;
            // 
            // rdbtnEmployee
            // 
            this.rdbtnEmployee.AutoSize = true;
            this.rdbtnEmployee.Location = new System.Drawing.Point(90, 116);
            this.rdbtnEmployee.Name = "rdbtnEmployee";
            this.rdbtnEmployee.Size = new System.Drawing.Size(71, 17);
            this.rdbtnEmployee.TabIndex = 4;
            this.rdbtnEmployee.TabStop = true;
            this.rdbtnEmployee.Text = "Employee";
            this.rdbtnEmployee.UseVisualStyleBackColor = true;
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.Location = new System.Drawing.Point(11, 179);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(259, 108);
            this.listBoxCustomers.TabIndex = 5;
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.Location = new System.Drawing.Point(11, 315);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(259, 108);
            this.listBoxEmployees.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Customers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Employees";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 429);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxEmployees);
            this.Controls.Add(this.listBoxCustomers);
            this.Controls.Add(this.rdbtnEmployee);
            this.Controls.Add(this.rdbtnCustomer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxLName);
            this.Controls.Add(this.txtBoxFName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxFName;
        private System.Windows.Forms.TextBox txtBoxLName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rdbtnCustomer;
        private System.Windows.Forms.RadioButton rdbtnEmployee;
        private System.Windows.Forms.ListBox listBoxCustomers;
        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

