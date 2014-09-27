using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary__calculator_apps
{
    class Employee
    {
        public string name;

        public double CulculatedSalary(double amount,double hoseRent,double medicalAllowance)
        {
            double Total = amount + ((hoseRent * amount)/100)+((medicalAllowance*amount)/100);
            return Total;
        }
    }
}
