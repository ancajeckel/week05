using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.Interfaces;

namespace BankApp.Models
{
    public abstract class Account : IAccount
    {
        public string IBAN { get; private set; }

        public ICustomer Customer { get; private set; }

        public decimal Balance { get; protected set; }

        public decimal InterestRate { get; }

        public DateTime OpeningDate { get; }

        public Account(string iBAN, ICustomer customer, decimal interestRate)
        {
            this.IBAN = iBAN;
            this.Customer = customer;
            this.Balance = 0;
            this.InterestRate = interestRate;
            this.OpeningDate = DateTime.Now;
        }

        public virtual decimal CalculateInterest(int numberOfMonths)
        {
            return this.Balance * numberOfMonths * this.InterestRate / 100;
        }

        public void PrintCalculatedInterest(int months)
        {
            Console.WriteLine($"{this.IBAN} - Balance ${this.Balance}, interest {months} months: ${this.CalculateInterest(months)}");
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public decimal GetCurrentBalance()
        {
            return this.Balance;
        }

        public int GetAccountMonths()
        {
            return DateTime.Now.Subtract(this.OpeningDate).Days / 30;
        }

        public abstract string GetAccountType();

        public virtual void PrintDetails()
        {
            Console.WriteLine($"{this.IBAN} - {this.GetAccountType()}, {this.InterestRate}%, belongs to: {this.Customer.GetName()} ({this.Customer.GetCustomerType()})");
        }
    }
}
