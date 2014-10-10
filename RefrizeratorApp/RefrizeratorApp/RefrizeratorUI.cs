using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RefrizeratorApp
{
    public partial class RefrizeratorUI : Form
    {
        private Refrizerator aRefrizerator;
        public RefrizeratorUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aRefrizerator = new Refrizerator(Convert.ToDouble(maxWeightTextBox.Text));
            MessageBox.Show("Created");
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            int noOfItems = Convert.ToInt16(noOfItemsTextBox.Text);
            double weightPerUnit = Convert.ToDouble(weightPerUnitTextBox.Text);
            try
            {
                aRefrizerator.AddItems(noOfItems, weightPerUnit);
            }
            catch (Exception)
            {
                MessageBox.Show("Overflow");
            }

            currentWeightTextBox.Text = aRefrizerator.CurrentWeight.ToString();
            remainingWeightTextBox.Text = aRefrizerator.RemainingWeight.ToString();
        }
    }
}
