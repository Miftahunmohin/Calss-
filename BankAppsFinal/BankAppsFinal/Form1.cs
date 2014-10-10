using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAppsFinal
{
    public partial class Form1 : Form
    {
        private Account _account1;
        private Customer _aCustomer;

        public Form1()
        {
            InitializeComponent();
        }

        private void CustomerAccountInfoSaveButton_Click(object sender, EventArgs e)
        {
            _aCustomer = new Customer();
            _aCustomer.Name = CustomerNameEntryTextBox.Text;
            _aCustomer.Email = EmailEntryTextBox.Text;

            _account1 = new Account();
            _account1.Number = AccountNumberEntryTextBox.Text;
            _account1.Date = OpeningDateEntryTextBox.Text;
            MessageBox.Show("account has been created");
        }

        private void ShowDetailsButton_Click(object sender, EventArgs e)
        {
            CoustomerNameDisplayTextBox.Text = _aCustomer.Name;
            EmailDisplayTextBox.Text = _aCustomer.Email;

            AccountNumberDisplayTextBox.Text = _account1.Number;
            OpeningDateDisplayTextBox.Text = _account1.Date;
            BalanceTextBox.Text = _account1.balance.ToString();

            
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            _account1.Deposit(Convert.ToDouble(AmountTextBox.Text));
        }

        private void WithDrowButton_Click(object sender, EventArgs e)
        {
            _account1.Withdraw(Convert.ToDouble(AmountTextBox.Text));
        }

    }
}
