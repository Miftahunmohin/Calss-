using System;
using System.Windows.Forms;

namespace tranzasion
{
    public partial class Form1 : Form
    {
        private Account account;
        public Form1()
        {
            InitializeComponent();
        }


      
        private void button1_Click(object sender, EventArgs e)
        {
            account = new Account(); 
            account.Number =  ( accountNumberTextBox.Text);
            account.Name= ( customarNameTextBox.Text);
            MessageBox.Show("Account created!!!!!");
            accountNumberTextBox.Text=string.Empty;
            customarNameTextBox.Text=string.Empty;
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
         //   MessageBox.Show(account.Report());
            string mess = account.Name + " your account is : " + account.Number + " it's balance is : " + account.Balance;
            MessageBox.Show(mess);
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (account!=null)
            {
                account.Deposit(Convert.ToDouble(DepositTextBox.Text));
                DepositTextBox.Text = string.Empty;
                MessageBox.Show(@"succesfully Deposit!!!");
            }
            else
            {
                MessageBox.Show(@"please create a account first!!!");
            }
        }

        private void withdrowButton_Click(object sender, EventArgs e)
        {
            if (account != null)
            {
                account.WithDorow(Convert.ToDouble(withdrowTextBox.Text));
                withdrowTextBox.Text = string.Empty;
                MessageBox.Show(@"succesfully WithDorow!!!");
            }
            else
            {
                MessageBox.Show(@"please create a account first!!!");
            }
        }
    }
}
