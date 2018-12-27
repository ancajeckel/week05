using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Interfaces
{
    public interface IAccount
    {
        string GetAccountType();

        void DepositMoney(decimal amount);

        decimal GetCurrentBalance();

        decimal CalculateInterest(int months);

        void PrintCalculatedInterest(int months);

        int GetAccountMonths();

        void PrintDetails();
    }
}
