namespace CRMv3_GUI
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
            this.dropDownList = new System.Windows.Forms.ComboBox();
            this.pnlRegisterNewUser = new System.Windows.Forms.Panel();
            this.txtBoxSalary = new System.Windows.Forms.TextBox();
            this.txtBoxTitel = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.txtBoxCompany = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.txtBoxLName = new System.Windows.Forms.TextBox();
            this.txtBoxFName = new System.Windows.Forms.TextBox();
            this.btnRegisterNewUserSave = new System.Windows.Forms.Button();
            this.btnRegisterNewUserCancel = new System.Windows.Forms.Button();
            this.lblTellHowManyRegistered = new System.Windows.Forms.Label();
            this.listBoxRegisteredUsers = new System.Windows.Forms.ListBox();
            this.pnlRegisteredUsersInfo = new System.Windows.Forms.Panel();
            this.txtBoxID_Display = new System.Windows.Forms.TextBox();
            this.lbl_ID_Display = new System.Windows.Forms.Label();
            this.btnRegisteredUsersCancelChanges = new System.Windows.Forms.Button();
            this.btnRegisteredUsersSaveChanges = new System.Windows.Forms.Button();
            this.txtBoxRegedCompany = new System.Windows.Forms.TextBox();
            this.lblRegedCompany = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxRegedNumb = new System.Windows.Forms.TextBox();
            this.txtBoxRegedLName = new System.Windows.Forms.TextBox();
            this.txtBoxRegedFName = new System.Windows.Forms.TextBox();
            this.txtBoxRegedSalary = new System.Windows.Forms.TextBox();
            this.txtBoxRegedTitel = new System.Windows.Forms.TextBox();
            this.lblRegedSalary = new System.Windows.Forms.Label();
            this.lblRegedTitel = new System.Windows.Forms.Label();
            this.pnlRegisterNewUser.SuspendLayout();
            this.pnlRegisteredUsersInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRMv3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jag vill registrera en ny:";
            // 
            // dropDownList
            // 
            this.dropDownList.FormattingEnabled = true;
            this.dropDownList.Location = new System.Drawing.Point(171, 49);
            this.dropDownList.Name = "dropDownList";
            this.dropDownList.Size = new System.Drawing.Size(270, 21);
            this.dropDownList.TabIndex = 2;
            this.dropDownList.SelectedIndexChanged += new System.EventHandler(this.dropDownList_SelectedIndexChanged);
            // 
            // pnlRegisterNewUser
            // 
            this.pnlRegisterNewUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRegisterNewUser.Controls.Add(this.txtBoxSalary);
            this.pnlRegisterNewUser.Controls.Add(this.txtBoxTitel);
            this.pnlRegisterNewUser.Controls.Add(this.lblSalary);
            this.pnlRegisterNewUser.Controls.Add(this.lblTitel);
            this.pnlRegisterNewUser.Controls.Add(this.txtBoxCompany);
            this.pnlRegisterNewUser.Controls.Add(this.lblCompany);
            this.pnlRegisterNewUser.Controls.Add(this.lblNumber);
            this.pnlRegisterNewUser.Controls.Add(this.lblLName);
            this.pnlRegisterNewUser.Controls.Add(this.lblFName);
            this.pnlRegisterNewUser.Controls.Add(this.txtBoxNumber);
            this.pnlRegisterNewUser.Controls.Add(this.txtBoxLName);
            this.pnlRegisterNewUser.Controls.Add(this.txtBoxFName);
            this.pnlRegisterNewUser.Controls.Add(this.btnRegisterNewUserSave);
            this.pnlRegisterNewUser.Controls.Add(this.btnRegisterNewUserCancel);
            this.pnlRegisterNewUser.Location = new System.Drawing.Point(28, 91);
            this.pnlRegisterNewUser.Name = "pnlRegisterNewUser";
            this.pnlRegisterNewUser.Size = new System.Drawing.Size(413, 185);
            this.pnlRegisterNewUser.TabIndex = 3;
            // 
            // txtBoxSalary
            // 
            this.txtBoxSalary.Location = new System.Drawing.Point(254, 33);
            this.txtBoxSalary.Name = "txtBoxSalary";
            this.txtBoxSalary.Size = new System.Drawing.Size(137, 20);
            this.txtBoxSalary.TabIndex = 14;
            this.txtBoxSalary.Visible = false;
            // 
            // txtBoxTitel
            // 
            this.txtBoxTitel.Location = new System.Drawing.Point(254, 4);
            this.txtBoxTitel.Name = "txtBoxTitel";
            this.txtBoxTitel.Size = new System.Drawing.Size(137, 20);
            this.txtBoxTitel.TabIndex = 13;
            this.txtBoxTitel.Visible = false;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(203, 36);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(25, 13);
            this.lblSalary.TabIndex = 11;
            this.lblSalary.Text = "Lön";
            this.lblSalary.Visible = false;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(203, 7);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(27, 13);
            this.lblTitel.TabIndex = 10;
            this.lblTitel.Text = "Titel";
            this.lblTitel.Visible = false;
            // 
            // txtBoxCompany
            // 
            this.txtBoxCompany.Location = new System.Drawing.Point(70, 85);
            this.txtBoxCompany.Name = "txtBoxCompany";
            this.txtBoxCompany.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCompany.TabIndex = 9;
            this.txtBoxCompany.Visible = false;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(3, 88);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(43, 13);
            this.lblCompany.TabIndex = 8;
            this.lblCompany.Text = "Företag";
            this.lblCompany.Visible = false;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(3, 62);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(46, 13);
            this.lblNumber.TabIndex = 7;
            this.lblNumber.Text = "Nummer";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(3, 36);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(55, 13);
            this.lblLName.TabIndex = 6;
            this.lblLName.Text = "Efternamn";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(3, 10);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(48, 13);
            this.lblFName.TabIndex = 5;
            this.lblFName.Text = "Förnamn";
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Location = new System.Drawing.Point(70, 59);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNumber.TabIndex = 4;
            // 
            // txtBoxLName
            // 
            this.txtBoxLName.Location = new System.Drawing.Point(70, 33);
            this.txtBoxLName.Name = "txtBoxLName";
            this.txtBoxLName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLName.TabIndex = 3;
            // 
            // txtBoxFName
            // 
            this.txtBoxFName.Location = new System.Drawing.Point(70, 7);
            this.txtBoxFName.Name = "txtBoxFName";
            this.txtBoxFName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFName.TabIndex = 2;
            // 
            // btnRegisterNewUserSave
            // 
            this.btnRegisterNewUserSave.Location = new System.Drawing.Point(254, 157);
            this.btnRegisterNewUserSave.Name = "btnRegisterNewUserSave";
            this.btnRegisterNewUserSave.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterNewUserSave.TabIndex = 1;
            this.btnRegisterNewUserSave.Text = "Save";
            this.btnRegisterNewUserSave.UseVisualStyleBackColor = true;
            this.btnRegisterNewUserSave.Click += new System.EventHandler(this.btnRegisterNewUserSave_Click);
            // 
            // btnRegisterNewUserCancel
            // 
            this.btnRegisterNewUserCancel.Location = new System.Drawing.Point(335, 157);
            this.btnRegisterNewUserCancel.Name = "btnRegisterNewUserCancel";
            this.btnRegisterNewUserCancel.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterNewUserCancel.TabIndex = 0;
            this.btnRegisterNewUserCancel.Text = "Cancel";
            this.btnRegisterNewUserCancel.UseVisualStyleBackColor = true;
            this.btnRegisterNewUserCancel.Click += new System.EventHandler(this.btnRegisterNewUserCancel_Click);
            // 
            // lblTellHowManyRegistered
            // 
            this.lblTellHowManyRegistered.AutoSize = true;
            this.lblTellHowManyRegistered.Location = new System.Drawing.Point(25, 300);
            this.lblTellHowManyRegistered.Name = "lblTellHowManyRegistered";
            this.lblTellHowManyRegistered.Size = new System.Drawing.Size(282, 13);
            this.lblTellHowManyRegistered.TabIndex = 4;
            this.lblTellHowManyRegistered.Text = "Du har registrerat 0 kunder, 0 anställda och 0 leverantörer.";
            // 
            // listBoxRegisteredUsers
            // 
            this.listBoxRegisteredUsers.FormattingEnabled = true;
            this.listBoxRegisteredUsers.Location = new System.Drawing.Point(28, 361);
            this.listBoxRegisteredUsers.Name = "listBoxRegisteredUsers";
            this.listBoxRegisteredUsers.Size = new System.Drawing.Size(147, 225);
            this.listBoxRegisteredUsers.TabIndex = 5;
            this.listBoxRegisteredUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxRegisteredUsers_SelectedIndexChanged);
            // 
            // pnlRegisteredUsersInfo
            // 
            this.pnlRegisteredUsersInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRegisteredUsersInfo.Controls.Add(this.txtBoxRegedSalary);
            this.pnlRegisteredUsersInfo.Controls.Add(this.txtBoxRegedTitel);
            this.pnlRegisteredUsersInfo.Controls.Add(this.lblRegedSalary);
            this.pnlRegisteredUsersInfo.Controls.Add(this.lblRegedTitel);
            this.pnlRegisteredUsersInfo.Controls.Add(this.txtBoxRegedCompany);
            this.pnlRegisteredUsersInfo.Controls.Add(this.lblRegedCompany);
            this.pnlRegisteredUsersInfo.Controls.Add(this.label4);
            this.pnlRegisteredUsersInfo.Controls.Add(this.label5);
            this.pnlRegisteredUsersInfo.Controls.Add(this.label6);
            this.pnlRegisteredUsersInfo.Controls.Add(this.txtBoxRegedNumb);
            this.pnlRegisteredUsersInfo.Controls.Add(this.txtBoxRegedLName);
            this.pnlRegisteredUsersInfo.Controls.Add(this.txtBoxRegedFName);
            this.pnlRegisteredUsersInfo.Controls.Add(this.txtBoxID_Display);
            this.pnlRegisteredUsersInfo.Controls.Add(this.lbl_ID_Display);
            this.pnlRegisteredUsersInfo.Controls.Add(this.btnRegisteredUsersCancelChanges);
            this.pnlRegisteredUsersInfo.Controls.Add(this.btnRegisteredUsersSaveChanges);
            this.pnlRegisteredUsersInfo.Location = new System.Drawing.Point(181, 361);
            this.pnlRegisteredUsersInfo.Name = "pnlRegisteredUsersInfo";
            this.pnlRegisteredUsersInfo.Size = new System.Drawing.Size(260, 225);
            this.pnlRegisteredUsersInfo.TabIndex = 6;
            // 
            // txtBoxID_Display
            // 
            this.txtBoxID_Display.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBoxID_Display.Location = new System.Drawing.Point(217, 3);
            this.txtBoxID_Display.Name = "txtBoxID_Display";
            this.txtBoxID_Display.ReadOnly = true;
            this.txtBoxID_Display.Size = new System.Drawing.Size(38, 20);
            this.txtBoxID_Display.TabIndex = 3;
            // 
            // lbl_ID_Display
            // 
            this.lbl_ID_Display.AutoSize = true;
            this.lbl_ID_Display.Location = new System.Drawing.Point(190, 6);
            this.lbl_ID_Display.Name = "lbl_ID_Display";
            this.lbl_ID_Display.Size = new System.Drawing.Size(21, 13);
            this.lbl_ID_Display.TabIndex = 2;
            this.lbl_ID_Display.Text = "ID:";
            // 
            // btnRegisteredUsersCancelChanges
            // 
            this.btnRegisteredUsersCancelChanges.Location = new System.Drawing.Point(182, 199);
            this.btnRegisteredUsersCancelChanges.Name = "btnRegisteredUsersCancelChanges";
            this.btnRegisteredUsersCancelChanges.Size = new System.Drawing.Size(75, 23);
            this.btnRegisteredUsersCancelChanges.TabIndex = 1;
            this.btnRegisteredUsersCancelChanges.Text = "Cancel";
            this.btnRegisteredUsersCancelChanges.UseVisualStyleBackColor = true;
            this.btnRegisteredUsersCancelChanges.Click += new System.EventHandler(this.btnRegisteredUsersCancelChanges_Click);
            // 
            // btnRegisteredUsersSaveChanges
            // 
            this.btnRegisteredUsersSaveChanges.Location = new System.Drawing.Point(101, 199);
            this.btnRegisteredUsersSaveChanges.Name = "btnRegisteredUsersSaveChanges";
            this.btnRegisteredUsersSaveChanges.Size = new System.Drawing.Size(75, 23);
            this.btnRegisteredUsersSaveChanges.TabIndex = 0;
            this.btnRegisteredUsersSaveChanges.Text = "Save";
            this.btnRegisteredUsersSaveChanges.UseVisualStyleBackColor = true;
            // 
            // txtBoxRegedCompany
            // 
            this.txtBoxRegedCompany.Location = new System.Drawing.Point(70, 81);
            this.txtBoxRegedCompany.Name = "txtBoxRegedCompany";
            this.txtBoxRegedCompany.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRegedCompany.TabIndex = 17;
            this.txtBoxRegedCompany.Visible = false;
            // 
            // lblRegedCompany
            // 
            this.lblRegedCompany.AutoSize = true;
            this.lblRegedCompany.Location = new System.Drawing.Point(3, 84);
            this.lblRegedCompany.Name = "lblRegedCompany";
            this.lblRegedCompany.Size = new System.Drawing.Size(43, 13);
            this.lblRegedCompany.TabIndex = 16;
            this.lblRegedCompany.Text = "Företag";
            this.lblRegedCompany.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nummer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Efternamn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Förnamn";
            // 
            // txtBoxRegedNumb
            // 
            this.txtBoxRegedNumb.Location = new System.Drawing.Point(70, 55);
            this.txtBoxRegedNumb.Name = "txtBoxRegedNumb";
            this.txtBoxRegedNumb.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRegedNumb.TabIndex = 12;
            // 
            // txtBoxRegedLName
            // 
            this.txtBoxRegedLName.Location = new System.Drawing.Point(70, 29);
            this.txtBoxRegedLName.Name = "txtBoxRegedLName";
            this.txtBoxRegedLName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRegedLName.TabIndex = 11;
            // 
            // txtBoxRegedFName
            // 
            this.txtBoxRegedFName.Location = new System.Drawing.Point(70, 3);
            this.txtBoxRegedFName.Name = "txtBoxRegedFName";
            this.txtBoxRegedFName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRegedFName.TabIndex = 10;
            // 
            // txtBoxRegedSalary
            // 
            this.txtBoxRegedSalary.Location = new System.Drawing.Point(70, 137);
            this.txtBoxRegedSalary.Name = "txtBoxRegedSalary";
            this.txtBoxRegedSalary.Size = new System.Drawing.Size(141, 20);
            this.txtBoxRegedSalary.TabIndex = 21;
            this.txtBoxRegedSalary.Visible = false;
            // 
            // txtBoxRegedTitel
            // 
            this.txtBoxRegedTitel.Location = new System.Drawing.Point(70, 108);
            this.txtBoxRegedTitel.Name = "txtBoxRegedTitel";
            this.txtBoxRegedTitel.Size = new System.Drawing.Size(141, 20);
            this.txtBoxRegedTitel.TabIndex = 20;
            this.txtBoxRegedTitel.Visible = false;
            // 
            // lblRegedSalary
            // 
            this.lblRegedSalary.AutoSize = true;
            this.lblRegedSalary.Location = new System.Drawing.Point(3, 140);
            this.lblRegedSalary.Name = "lblRegedSalary";
            this.lblRegedSalary.Size = new System.Drawing.Size(25, 13);
            this.lblRegedSalary.TabIndex = 19;
            this.lblRegedSalary.Text = "Lön";
            this.lblRegedSalary.Visible = false;
            // 
            // lblRegedTitel
            // 
            this.lblRegedTitel.AutoSize = true;
            this.lblRegedTitel.Location = new System.Drawing.Point(3, 111);
            this.lblRegedTitel.Name = "lblRegedTitel";
            this.lblRegedTitel.Size = new System.Drawing.Size(27, 13);
            this.lblRegedTitel.TabIndex = 18;
            this.lblRegedTitel.Text = "Titel";
            this.lblRegedTitel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 599);
            this.Controls.Add(this.pnlRegisteredUsersInfo);
            this.Controls.Add(this.listBoxRegisteredUsers);
            this.Controls.Add(this.lblTellHowManyRegistered);
            this.Controls.Add(this.pnlRegisterNewUser);
            this.Controls.Add(this.dropDownList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlRegisterNewUser.ResumeLayout(false);
            this.pnlRegisterNewUser.PerformLayout();
            this.pnlRegisteredUsersInfo.ResumeLayout(false);
            this.pnlRegisteredUsersInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dropDownList;
        private System.Windows.Forms.Panel pnlRegisterNewUser;
        private System.Windows.Forms.Button btnRegisterNewUserSave;
        private System.Windows.Forms.Button btnRegisterNewUserCancel;
        private System.Windows.Forms.Label lblTellHowManyRegistered;
        private System.Windows.Forms.ListBox listBoxRegisteredUsers;
        private System.Windows.Forms.Panel pnlRegisteredUsersInfo;
        private System.Windows.Forms.Button btnRegisteredUsersCancelChanges;
        private System.Windows.Forms.Button btnRegisteredUsersSaveChanges;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.TextBox txtBoxLName;
        private System.Windows.Forms.TextBox txtBoxFName;
        private System.Windows.Forms.TextBox txtBoxCompany;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.TextBox txtBoxSalary;
        private System.Windows.Forms.TextBox txtBoxTitel;
        private System.Windows.Forms.TextBox txtBoxID_Display;
        private System.Windows.Forms.Label lbl_ID_Display;
        private System.Windows.Forms.TextBox txtBoxRegedCompany;
        private System.Windows.Forms.Label lblRegedCompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxRegedNumb;
        private System.Windows.Forms.TextBox txtBoxRegedLName;
        private System.Windows.Forms.TextBox txtBoxRegedFName;
        private System.Windows.Forms.TextBox txtBoxRegedSalary;
        private System.Windows.Forms.TextBox txtBoxRegedTitel;
        private System.Windows.Forms.Label lblRegedSalary;
        private System.Windows.Forms.Label lblRegedTitel;
    }
}

