using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tranzasion
{
    class Account
    {
      private string number;
      private string name;
      private double balance=0;

      #region old private data access use 
      //public void SetNumber(string number)
      //  {
      //      this.number = number;
      //  }

      //  public string GetNumber()
      //  {
      //      return number;
      //  }
      //  public void SetName(string name)
      //  {
      //      this.name = name;
      //  }

      //  public string GetName()
      //  {
      //      return name;
      //  }
      //  public void SetBlance(double blance)
      //  {
      //      this.balance = blance;
      //  }

      //  public double GetBlance()
      //  {
      //      return balance;
      //  }
      #endregion

      public string Number
      {
          get { return number; }
          set { number = value; }
      }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Balance
        {
            get { return balance; }
            
        }

        public void Deposit(double inAmount)
        {
            balance += inAmount;
        }

        public void WithDorow(double outAmount)
        {
            balance -= outAmount;
        }

       
    }
}
