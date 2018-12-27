using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.Interfaces;
using BankApp.Models;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateBankData();
            Console.ReadKey();
        }

        public static void CreateBankData()
        {
            // create customers
            Individual person1 = new Individual("Alex");
            Company comp1 = new Company("SC UBS Ltd.", 45252);
            Customer.GetListCustomers();

            // create bank and add data to it
            Bank bank1 = new Bank("Raiffeisen", "Iasi");
            Account acc1 = (Account)bank1.OpenAccount(person1, "deposit");
            acc1.DepositMoney(1200);
            Account acc2 = (Account)bank1.OpenAccount(comp1, "deposit");
            acc2.DepositMoney(800);
            Account acc3 = (Account)bank1.OpenAccount(person1, "loan");
            acc3.DepositMoney(7500);
            Account acc4 = (Account)bank1.OpenAccount(comp1, "loan");
            acc4.DepositMoney(5000);
            Account acc5 = (Account)bank1.OpenAccount(person1, "mortgage");
            acc5.DepositMoney(7500);
            Account acc6 = (Account)bank1.OpenAccount(comp1, "mortgage");
            acc6.DepositMoney(5000);

            foreach (var account in bank1.GetListAccounts())
            {
                account.PrintDetails();
            }

            // get interest 3 months
            Console.WriteLine();
            foreach (var account in bank1.GetListAccounts())
            {
                account.PrintCalculatedInterest(3);
            }

            // get interest 24 months
            Console.WriteLine();
            acc2.DepositMoney(500);
            ((DepositAccount)acc1).WithdrawMoney(500);
            acc5.DepositMoney(200);
            foreach (var account in bank1.GetListAccounts())
            {
                account.PrintCalculatedInterest(24);
            }
        }
    }
}
