using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.Interfaces;

namespace BankApp.Models
{
    class LoanAccount : Account
    {
        public LoanAccount(string iBAN, ICustomer customer) : base(iBAN, customer, (decimal)8) { }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            var nrFreeMonths = 0;
            if (this.Customer is Individual)
            {
                nrFreeMonths = 3;
            }
            else if (this.Customer is Company)
            {
                nrFreeMonths = 2;
            }

            if (numberOfMonths <= nrFreeMonths)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterest(numberOfMonths - nrFreeMonths);
            }
        }

        public override string GetAccountType()
        {
            return "Loan Account";
        }
    }
}
