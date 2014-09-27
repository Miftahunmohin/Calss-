namespace Salary__calculator_apps
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.BasicAmountTextBox = new System.Windows.Forms.TextBox();
            this.HouseRentTextBox = new System.Windows.Forms.TextBox();
            this.MedicalAllownaceTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Basic Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "House Rent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medical Allowance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "% Of Basic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "% Of Basic";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(134, 39);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(171, 20);
            this.employeeNameTextBox.TabIndex = 6;
            // 
            // BasicAmountTextBox
            // 
            this.BasicAmountTextBox.Location = new System.Drawing.Point(134, 65);
            this.BasicAmountTextBox.Name = "BasicAmountTextBox";
            this.BasicAmountTextBox.Size = new System.Drawing.Size(171, 20);
            this.BasicAmountTextBox.TabIndex = 7;
            // 
            // HouseRentTextBox
            // 
            this.HouseRentTextBox.Location = new System.Drawing.Point(134, 99);
            this.HouseRentTextBox.Name = "HouseRentTextBox";
            this.HouseRentTextBox.Size = new System.Drawing.Size(171, 20);
            this.HouseRentTextBox.TabIndex = 8;
            // 
            // MedicalAllownaceTextBox
            // 
            this.MedicalAllownaceTextBox.Location = new System.Drawing.Point(134, 132);
            this.MedicalAllownaceTextBox.Name = "MedicalAllownaceTextBox";
            this.MedicalAllownaceTextBox.Size = new System.Drawing.Size(171, 20);
            this.MedicalAllownaceTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Show Me Salary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MedicalAllownaceTextBox);
            this.Controls.Add(this.HouseRentTextBox);
            this.Controls.Add(this.BasicAmountTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.TextBox BasicAmountTextBox;
        private System.Windows.Forms.TextBox HouseRentTextBox;
        private System.Windows.Forms.TextBox MedicalAllownaceTextBox;
        private System.Windows.Forms.Button button1;
    }
}

