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
            this.pnlShowCars.SuspendLayout();
            this.pnlCarInfo.SuspendLayout();
            this.pnlAddCar.SuspendLayout();
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
            // 
            // pnlShowCars
            // 
            this.pnlShowCars.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlShowCars.Controls.Add(this.btnBook);
            this.pnlShowCars.Controls.Add(this.pnlCarInfo);
            this.pnlShowCars.Controls.Add(this.lblAvailableCars);
            this.pnlShowCars.Controls.Add(this.listBoxAvailableCarsList);
            this.pnlShowCars.Location = new System.Drawing.Point(12, 94);
            this.pnlShowCars.Name = "pnlShowCars";
            this.pnlShowCars.Size = new System.Drawing.Size(339, 347);
            this.pnlShowCars.TabIndex = 7;
            this.pnlShowCars.Visible = false;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBook.Location = new System.Drawing.Point(180, 190);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(104, 62);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Visible = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // pnlCarInfo
            // 
            this.pnlCarInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.pnlAddCar.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.pnlAddCar.Size = new System.Drawing.Size(161, 122);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 453);
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
    }
}

