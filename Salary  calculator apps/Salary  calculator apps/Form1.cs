using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary__calculator_apps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Employee aEmployee;
        private double _amount;
        private double _hoseRent;
        private double _medicalAllowance;

        private void button1_Click(object sender, EventArgs e)
        {
            aEmployee = new Employee();
            aEmployee.name = employeeNameTextBox.Text;
            _amount = Convert.ToDouble(BasicAmountTextBox.Text);
            _hoseRent = Convert.ToDouble(HouseRentTextBox.Text);
            _medicalAllowance = Convert.ToDouble(MedicalAllownaceTextBox.Text);
            MessageBox.Show(aEmployee.name+" your salary : "+aEmployee.CulculatedSalary(_amount, _hoseRent, _medicalAllowance).ToString());

        }
    }
}
