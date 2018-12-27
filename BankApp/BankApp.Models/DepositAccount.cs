using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.Interfaces;

namespace BankApp.Models
{
    public class DepositAccount : Account
    {
        public DepositAccount(string iBAN, ICustomer customer) : base(iBAN, customer, 4) { }

        public void WithdrawMoney(decimal amount)
        {
            this.Balance -= amount; 
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (this.Balance >= 0 && this.Balance < 1000)
            {
                return 0;
            }
            return base.CalculateInterest(numberOfMonths);
        }

        public override string GetAccountType()
        {
            return "Deposit Account";
        }
    }
}
