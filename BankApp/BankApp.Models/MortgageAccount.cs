using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.Interfaces;

namespace BankApp.Models
{
    class MortgageAccount : Account
    {
        public MortgageAccount(string iBAN, ICustomer customer) : base(iBAN, customer, (decimal)2.5) { }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (this.Customer is Individual)
            {
                if (numberOfMonths <= 6)
                {
                    return 0;
                }
                return base.CalculateInterest(numberOfMonths - 6);
            }

            if (this.Customer is Company)
            {
                if (numberOfMonths <= 12)
                {
                    return base.CalculateInterest(numberOfMonths) / 2;
                }
                return base.CalculateInterest(12) / 2 + base.CalculateInterest(numberOfMonths - 12);

            }
            return base.CalculateInterest(numberOfMonths);
        }

        public override string GetAccountType()
        {
            return "Mortgage Account";
        }
    }
}
