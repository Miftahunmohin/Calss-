using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppsFinal
{
    class Account
    {
        public string Number { set; get; }
        public string Date { set; get; }
        public double balance {private set; get; }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }

    }
}
