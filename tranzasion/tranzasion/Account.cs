using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tranzasion
{
    class Account
    {
        public string number;
        public string name;
        public double blance=0;



        public void Deposit(double inAmount)
        {
            blance += inAmount;
        }

        public void WithDorow(double outAmount)
        {
            blance -= outAmount;
        }

       
    }
}
