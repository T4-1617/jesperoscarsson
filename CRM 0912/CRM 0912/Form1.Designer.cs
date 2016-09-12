namespace CRM_0912
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
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUnderLeftListBox = new System.Windows.Forms.Label();
            this.UnderRightListBox = new System.Windows.Forms.Label();
            this.listBoxMain = new System.Windows.Forms.ListBox();
            this.txtBoxFName = new System.Windows.Forms.TextBox();
            this.txtBoxLName = new System.Windows.Forms.TextBox();
            this.txtBoxRegCustomers = new System.Windows.Forms.TextBox();
            this.lblAboveListBox = new System.Windows.Forms.Label();
            this.lblProgName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRM v.1";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(12, 50);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(55, 13);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "First name";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(12, 84);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(58, 13);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 10;
            // 
            // lblUnderLeftListBox
            // 
            this.lblUnderLeftListBox.AutoSize = true;
            this.lblUnderLeftListBox.Location = new System.Drawing.Point(5, 269);
            this.lblUnderLeftListBox.Name = "lblUnderLeftListBox";
            this.lblUnderLeftListBox.Size = new System.Drawing.Size(48, 13);
            this.lblUnderLeftListBox.TabIndex = 4;
            this.lblUnderLeftListBox.Text = "There is ";
            // 
            // UnderRightListBox
            // 
            this.UnderRightListBox.AutoSize = true;
            this.UnderRightListBox.Location = new System.Drawing.Point(70, 269);
            this.UnderRightListBox.Name = "UnderRightListBox";
            this.UnderRightListBox.Size = new System.Drawing.Size(107, 13);
            this.UnderRightListBox.TabIndex = 5;
            this.UnderRightListBox.Text = " registered customers";
            // 
            // listBoxMain
            // 
            this.listBoxMain.FormattingEnabled = true;
            this.listBoxMain.Location = new System.Drawing.Point(8, 158);
            this.listBoxMain.Name = "listBoxMain";
            this.listBoxMain.Size = new System.Drawing.Size(276, 95);
            this.listBoxMain.TabIndex = 6;
            // 
            // txtBoxFName
            // 
            this.txtBoxFName.Location = new System.Drawing.Point(73, 47);
            this.txtBoxFName.Name = "txtBoxFName";
            this.txtBoxFName.Size = new System.Drawing.Size(177, 20);
            this.txtBoxFName.TabIndex = 7;
            // 
            // txtBoxLName
            // 
            this.txtBoxLName.Location = new System.Drawing.Point(73, 81);
            this.txtBoxLName.Name = "txtBoxLName";
            this.txtBoxLName.Size = new System.Drawing.Size(177, 20);
            this.txtBoxLName.TabIndex = 8;
            // 
            // txtBoxRegCustomers
            // 
            this.txtBoxRegCustomers.Location = new System.Drawing.Point(49, 266);
            this.txtBoxRegCustomers.Name = "txtBoxRegCustomers";
            this.txtBoxRegCustomers.Size = new System.Drawing.Size(21, 20);
            this.txtBoxRegCustomers.TabIndex = 9;
            // 
            // lblAboveListBox
            // 
            this.lblAboveListBox.AutoSize = true;
            this.lblAboveListBox.Location = new System.Drawing.Point(15, 142);
            this.lblAboveListBox.Name = "lblAboveListBox";
            this.lblAboveListBox.Size = new System.Drawing.Size(110, 13);
            this.lblAboveListBox.TabIndex = 11;
            this.lblAboveListBox.Text = "Registered Customers";
            // 
            // lblProgName
            // 
            this.lblProgName.AutoSize = true;
            this.lblProgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgName.Location = new System.Drawing.Point(12, 9);
            this.lblProgName.Name = "lblProgName";
            this.lblProgName.Size = new System.Drawing.Size(65, 16);
            this.lblProgName.TabIndex = 12;
            this.lblProgName.Text = "CRM v.1";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(225, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 293);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblProgName);
            this.Controls.Add(this.lblAboveListBox);
            this.Controls.Add(this.txtBoxRegCustomers);
            this.Controls.Add(this.txtBoxLName);
            this.Controls.Add(this.txtBoxFName);
            this.Controls.Add(this.listBoxMain);
            this.Controls.Add(this.UnderRightListBox);
            this.Controls.Add(this.lblUnderLeftListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUnderLeftListBox;
        private System.Windows.Forms.Label UnderRightListBox;
        private System.Windows.Forms.ListBox listBoxMain;
        private System.Windows.Forms.TextBox txtBoxFName;
        private System.Windows.Forms.TextBox txtBoxLName;
        private System.Windows.Forms.TextBox txtBoxRegCustomers;
        private System.Windows.Forms.Label lblAboveListBox;
        private System.Windows.Forms.Label lblProgName;
        private System.Windows.Forms.Button btnAdd;
    }
}

