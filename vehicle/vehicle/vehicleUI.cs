using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vehicle
{
    public partial class vehicleUI : Form
    {
        public vehicleUI()
        {
            InitializeComponent();
        }
        private Culculat aCulculat;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            aCulculat = new Culculat();
            aCulculat.Name = VehicleNameTextBox.Text;
            aCulculat.Reg = RegNoTextBox.Text;
            MessageBox.Show(@"vehicle Account has been created   ");

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            maxSpeedTextBox.Text=  aCulculat.MaxCalculator().ToString();
            minSpeedTextBox.Text=aCulculat.MinCalculator().ToString();
            avarageTextBox.Text = aCulculat.SpeedClculate().ToString();

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (aCulculat != null)
            {
                aCulculat.Speed = Convert.ToDouble(speedTextBox.Text);
            }
            else
            {
                MessageBox.Show(@"please create a account !");
            }
           
    
        }
    }
}
