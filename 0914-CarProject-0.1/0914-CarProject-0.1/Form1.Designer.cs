namespace _0914_CarProject_0._1
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
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxCarList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.txtDoors = new System.Windows.Forms.TextBox();
            this.txtTrans = new System.Windows.Forms.TextBox();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.txtBag = new System.Windows.Forms.TextBox();
            this.txtProp = new System.Windows.Forms.TextBox();
            this.txtRegNumb = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cars";
            // 
            // listBoxCarList
            // 
            this.listBoxCarList.FormattingEnabled = true;
            this.listBoxCarList.Location = new System.Drawing.Point(12, 57);
            this.listBoxCarList.Name = "listBoxCarList";
            this.listBoxCarList.Size = new System.Drawing.Size(120, 186);
            this.listBoxCarList.TabIndex = 1;
            this.listBoxCarList.SelectedIndexChanged += new System.EventHandler(this.listBoxCarList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Car project v.1";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.txtDoors);
            this.panel.Controls.Add(this.txtSeats);
            this.panel.Controls.Add(this.label11);
            this.panel.Controls.Add(this.txtBag);
            this.panel.Controls.Add(this.txtAvailable);
            this.panel.Controls.Add(this.txtTrans);
            this.panel.Controls.Add(this.txtProp);
            this.panel.Controls.Add(this.txtRegNumb);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.txtModel);
            this.panel.Controls.Add(this.label10);
            this.panel.Controls.Add(this.label9);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.btnCancel);
            this.panel.Controls.Add(this.btnSave);
            this.panel.Controls.Add(this.btnEdit);
            this.panel.Controls.Add(this.label3);
            this.panel.Location = new System.Drawing.Point(138, 57);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(249, 262);
            this.panel.TabIndex = 4;
            this.panel.Visible = false;
            // 
            // txtDoors
            // 
            this.txtDoors.Location = new System.Drawing.Point(124, 125);
            this.txtDoors.Name = "txtDoors";
            this.txtDoors.ReadOnly = true;
            this.txtDoors.Size = new System.Drawing.Size(100, 20);
            this.txtDoors.TabIndex = 5;
            // 
            // txtTrans
            // 
            this.txtTrans.Location = new System.Drawing.Point(124, 151);
            this.txtTrans.Name = "txtTrans";
            this.txtTrans.ReadOnly = true;
            this.txtTrans.Size = new System.Drawing.Size(100, 20);
            this.txtTrans.TabIndex = 6;
            // 
            // txtSeats
            // 
            this.txtSeats.Location = new System.Drawing.Point(124, 99);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.ReadOnly = true;
            this.txtSeats.Size = new System.Drawing.Size(100, 20);
            this.txtSeats.TabIndex = 17;
            // 
            // txtAvailable
            // 
            this.txtAvailable.Location = new System.Drawing.Point(124, 203);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.ReadOnly = true;
            this.txtAvailable.Size = new System.Drawing.Size(100, 20);
            this.txtAvailable.TabIndex = 16;
            // 
            // txtBag
            // 
            this.txtBag.Location = new System.Drawing.Point(124, 73);
            this.txtBag.Name = "txtBag";
            this.txtBag.ReadOnly = true;
            this.txtBag.Size = new System.Drawing.Size(100, 20);
            this.txtBag.TabIndex = 15;
            // 
            // txtProp
            // 
            this.txtProp.Location = new System.Drawing.Point(124, 177);
            this.txtProp.Name = "txtProp";
            this.txtProp.ReadOnly = true;
            this.txtProp.Size = new System.Drawing.Size(100, 20);
            this.txtProp.TabIndex = 14;
            // 
            // txtRegNumb
            // 
            this.txtRegNumb.Location = new System.Drawing.Point(124, 47);
            this.txtRegNumb.Name = "txtRegNumb";
            this.txtRegNumb.ReadOnly = true;
            this.txtRegNumb.Size = new System.Drawing.Size(100, 20);
            this.txtRegNumb.TabIndex = 13;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(124, 21);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 206);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label11.Size = new System.Drawing.Size(50, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Available";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 154);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label10.Size = new System.Drawing.Size(68, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Transmission";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 128);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Doors";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 102);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Seats";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 76);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Baggage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 180);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Propelant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 50);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Registration Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 24);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Model";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(165, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(84, 235);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(3, 235);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 323);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCarList);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxCarList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDoors;
        private System.Windows.Forms.TextBox txtTrans;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.TextBox txtBag;
        private System.Windows.Forms.TextBox txtProp;
        private System.Windows.Forms.TextBox txtRegNumb;
        private System.Windows.Forms.TextBox txtModel;
    }
}

