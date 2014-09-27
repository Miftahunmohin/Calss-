namespace tranzasion
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
            this.createButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrowButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customarNameTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DepositTextBox = new System.Windows.Forms.TextBox();
            this.withdrowTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(321, 86);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(77, 90);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 1;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // withdrowButton
            // 
            this.withdrowButton.Location = new System.Drawing.Point(255, 90);
            this.withdrowButton.Name = "withdrowButton";
            this.withdrowButton.Size = new System.Drawing.Size(75, 23);
            this.withdrowButton.TabIndex = 2;
            this.withdrowButton.Text = "Withdrow";
            this.withdrowButton.UseVisualStyleBackColor = true;
            this.withdrowButton.Click += new System.EventHandler(this.withdrowButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(238, 307);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 3;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customarNameTextBox);
            this.groupBox1.Controls.Add(this.accountNumberTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Location = new System.Drawing.Point(68, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 115);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Account Creation";
            // 
            // customarNameTextBox
            // 
            this.customarNameTextBox.Location = new System.Drawing.Point(123, 64);
            this.customarNameTextBox.Name = "customarNameTextBox";
            this.customarNameTextBox.Size = new System.Drawing.Size(195, 20);
            this.customarNameTextBox.TabIndex = 4;
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(123, 34);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(195, 20);
            this.accountNumberTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customar Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DepositTextBox);
            this.groupBox2.Controls.Add(this.withdrowTextBox);
            this.groupBox2.Controls.Add(this.withdrowButton);
            this.groupBox2.Controls.Add(this.depositButton);
            this.groupBox2.Location = new System.Drawing.Point(68, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 130);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trensection";
            // 
            // DepositTextBox
            // 
            this.DepositTextBox.Location = new System.Drawing.Point(32, 54);
            this.DepositTextBox.Name = "DepositTextBox";
            this.DepositTextBox.Size = new System.Drawing.Size(163, 20);
            this.DepositTextBox.TabIndex = 5;
            // 
            // withdrowTextBox
            // 
            this.withdrowTextBox.Location = new System.Drawing.Point(214, 54);
            this.withdrowTextBox.Name = "withdrowTextBox";
            this.withdrowTextBox.Size = new System.Drawing.Size(148, 20);
            this.withdrowTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 342);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportButton);
            this.Name = "Form1";
            this.Text = "Customar transection";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button withdrowButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DepositTextBox;
        private System.Windows.Forms.TextBox customarNameTextBox;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox withdrowTextBox;
    }
}

