namespace calculatorGUI
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
            this.fNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showAnswer = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.sNum = new System.Windows.Forms.TextBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fNum
            // 
            this.fNum.Location = new System.Drawing.Point(102, 6);
            this.fNum.Name = "fNum";
            this.fNum.Size = new System.Drawing.Size(67, 20);
            this.fNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Second number:";
            // 
            // showAnswer
            // 
            this.showAnswer.AutoSize = true;
            this.showAnswer.Location = new System.Drawing.Point(12, 91);
            this.showAnswer.Name = "showAnswer";
            this.showAnswer.Size = new System.Drawing.Size(0, 13);
            this.showAnswer.TabIndex = 4;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(273, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(36, 23);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "-";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // sNum
            // 
            this.sNum.Location = new System.Drawing.Point(102, 35);
            this.sNum.Name = "sNum";
            this.sNum.Size = new System.Drawing.Size(67, 20);
            this.sNum.TabIndex = 9;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(221, 38);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(36, 23);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "/";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(221, 6);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(36, 23);
            this.btn1.TabIndex = 11;
            this.btn1.Text = "+";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(273, 38);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(36, 23);
            this.btn4.TabIndex = 12;
            this.btn4.Text = "*";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 161);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.sNum);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.showAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label showAnswer;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TextBox sNum;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
    }
}

