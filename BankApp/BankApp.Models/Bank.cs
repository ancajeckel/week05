using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.Interfaces;

namespace BankApp.Models
{
    public class Bank : IBank
    {
        public string Name { get; private set; }

        public string Location { get; private set; }

        private int NextAccountNr = 0;

        private List<IAccount> listAccounts = new List<IAccount>();

        public Bank(string name, string location)
        {
            this.Name = name;
            this.Location = location;
        }

        public IAccount OpenAccount(ICustomer customer, string accountType)
        {
            var nextIBAN = GenerateIBAN();
            if (accountType.ToLower().Contains("mortgage"))
            {
                Account newAccount = new MortgageAccount(nextIBAN, customer);
                listAccounts.Add(newAccount);
                return newAccount;
            }
            else if (accountType.ToLower().Contains("loan"))
            {
                Account newAccount = new LoanAccount(nextIBAN, customer);
                listAccounts.Add(newAccount);
                return newAccount;
            }
            else
            {
                Account newAccount = new DepositAccount(nextIBAN, customer);
                listAccounts.Add(newAccount);
                return newAccount;
            }
        }

        private string GenerateIBAN()
        {
            NextAccountNr++;
            return this.Name.Substring(0, 5) + NextAccountNr.ToString("00000");
        }

        public void CloseAccount(IAccount account)
        {
            listAccounts.Remove(account);
        }

        public List<IAccount> GetListAccounts()
        {
            return listAccounts;
        }
    }
}
