namespace WindowsFormsApplication1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxForInputAmount = new System.Windows.Forms.TextBox();
            this.textBoxForInputParticular = new System.Windows.Forms.TextBox();
            this.textBoxForTotalExpense = new System.Windows.Forms.TextBox();
            this.textBoxForMaximumExpense = new System.Windows.Forms.TextBox();
            this.textBoxForTotal = new System.Windows.Forms.TextBox();
            this.buttonForSave = new System.Windows.Forms.Button();
            this.buttonForShowViewSummary = new System.Windows.Forms.Button();
            this.buttonForViewCategoryWiseExpense = new System.Windows.Forms.Button();
            this.comboBoxForInputCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxForInputCategory2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(503, 126);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(204, 144);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Category";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Daily Expense Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "particular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "View Summary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Expense";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Maximum Expense";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "View Categorywise Expense";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(448, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Category";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(448, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Total";
            // 
            // textBoxForInputAmount
            // 
            this.textBoxForInputAmount.Location = new System.Drawing.Point(188, 78);
            this.textBoxForInputAmount.Name = "textBoxForInputAmount";
            this.textBoxForInputAmount.Size = new System.Drawing.Size(205, 20);
            this.textBoxForInputAmount.TabIndex = 11;
            // 
            // textBoxForInputParticular
            // 
            this.textBoxForInputParticular.Location = new System.Drawing.Point(188, 126);
            this.textBoxForInputParticular.Multiline = true;
            this.textBoxForInputParticular.Name = "textBoxForInputParticular";
            this.textBoxForInputParticular.Size = new System.Drawing.Size(205, 46);
            this.textBoxForInputParticular.TabIndex = 12;
            // 
            // textBoxForTotalExpense
            // 
            this.textBoxForTotalExpense.Location = new System.Drawing.Point(188, 335);
            this.textBoxForTotalExpense.Name = "textBoxForTotalExpense";
            this.textBoxForTotalExpense.Size = new System.Drawing.Size(205, 20);
            this.textBoxForTotalExpense.TabIndex = 13;
            this.textBoxForTotalExpense.TextChanged += new System.EventHandler(this.textBoxForTotalExpense_TextChanged);
            // 
            // textBoxForMaximumExpense
            // 
            this.textBoxForMaximumExpense.Location = new System.Drawing.Point(188, 361);
            this.textBoxForMaximumExpense.Name = "textBoxForMaximumExpense";
            this.textBoxForMaximumExpense.Size = new System.Drawing.Size(205, 20);
            this.textBoxForMaximumExpense.TabIndex = 14;
            // 
            // textBoxForTotal
            // 
            this.textBoxForTotal.Location = new System.Drawing.Point(523, 354);
            this.textBoxForTotal.Name = "textBoxForTotal";
            this.textBoxForTotal.Size = new System.Drawing.Size(165, 20);
            this.textBoxForTotal.TabIndex = 15;
            this.textBoxForTotal.TextChanged += new System.EventHandler(this.textBoxForTotal_TextChanged);
            // 
            // buttonForSave
            // 
            this.buttonForSave.Location = new System.Drawing.Point(318, 187);
            this.buttonForSave.Name = "buttonForSave";
            this.buttonForSave.Size = new System.Drawing.Size(75, 23);
            this.buttonForSave.TabIndex = 16;
            this.buttonForSave.Text = "Save";
            this.buttonForSave.UseVisualStyleBackColor = true;
            this.buttonForSave.Click += new System.EventHandler(this.buttonForSave_Click);
            // 
            // buttonForShowViewSummary
            // 
            this.buttonForShowViewSummary.Location = new System.Drawing.Point(318, 306);
            this.buttonForShowViewSummary.Name = "buttonForShowViewSummary";
            this.buttonForShowViewSummary.Size = new System.Drawing.Size(75, 23);
            this.buttonForShowViewSummary.TabIndex = 17;
            this.buttonForShowViewSummary.Text = "Show";
            this.buttonForShowViewSummary.UseVisualStyleBackColor = true;
            this.buttonForShowViewSummary.Click += new System.EventHandler(this.buttonForShowViewSummary_Click);
            // 
            // buttonForViewCategoryWiseExpense
            // 
            this.buttonForViewCategoryWiseExpense.Location = new System.Drawing.Point(632, 97);
            this.buttonForViewCategoryWiseExpense.Name = "buttonForViewCategoryWiseExpense";
            this.buttonForViewCategoryWiseExpense.Size = new System.Drawing.Size(75, 23);
            this.buttonForViewCategoryWiseExpense.TabIndex = 18;
            this.buttonForViewCategoryWiseExpense.Text = "Show";
            this.buttonForViewCategoryWiseExpense.UseVisualStyleBackColor = true;
            this.buttonForViewCategoryWiseExpense.Click += new System.EventHandler(this.buttonForViewCategoryWiseExpense_Click);
            // 
            // comboBoxForInputCategory
            // 
            this.comboBoxForInputCategory.FormattingEnabled = true;
            this.comboBoxForInputCategory.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.comboBoxForInputCategory.Location = new System.Drawing.Point(188, 104);
            this.comboBoxForInputCategory.Name = "comboBoxForInputCategory";
            this.comboBoxForInputCategory.Size = new System.Drawing.Size(205, 21);
            this.comboBoxForInputCategory.TabIndex = 19;
            // 
            // comboBoxForInputCategory2
            // 
            this.comboBoxForInputCategory2.FormattingEnabled = true;
            this.comboBoxForInputCategory2.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.comboBoxForInputCategory2.Location = new System.Drawing.Point(557, 53);
            this.comboBoxForInputCategory2.Name = "comboBoxForInputCategory2";
            this.comboBoxForInputCategory2.Size = new System.Drawing.Size(150, 21);
            this.comboBoxForInputCategory2.TabIndex = 20;
            this.comboBoxForInputCategory2.SelectedIndexChanged += new System.EventHandler(this.comboBoxForInputCategory2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 395);
            this.Controls.Add(this.comboBoxForInputCategory2);
            this.Controls.Add(this.comboBoxForInputCategory);
            this.Controls.Add(this.buttonForViewCategoryWiseExpense);
            this.Controls.Add(this.buttonForShowViewSummary);
            this.Controls.Add(this.buttonForSave);
            this.Controls.Add(this.textBoxForTotal);
            this.Controls.Add(this.textBoxForMaximumExpense);
            this.Controls.Add(this.textBoxForTotalExpense);
            this.Controls.Add(this.textBoxForInputParticular);
            this.Controls.Add(this.textBoxForInputAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Daily Expense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxForInputAmount;
        private System.Windows.Forms.TextBox textBoxForInputParticular;
        private System.Windows.Forms.TextBox textBoxForTotalExpense;
        private System.Windows.Forms.TextBox textBoxForMaximumExpense;
        private System.Windows.Forms.TextBox textBoxForTotal;
        private System.Windows.Forms.Button buttonForSave;
        private System.Windows.Forms.Button buttonForShowViewSummary;
        private System.Windows.Forms.Button buttonForViewCategoryWiseExpense;
        private System.Windows.Forms.ComboBox comboBoxForInputCategory;
        private System.Windows.Forms.ComboBox comboBoxForInputCategory2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

