using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.Interfaces;

namespace BankApp.Models
{
    public abstract class Customer : ICustomer
    {
        public string Name { get; protected set; }

        public Customer(string name)
        {
            this.Name = name;
            listCustomers.Add(this);
        }

        protected static List<ICustomer> listCustomers = new List<ICustomer>();

        public abstract string GetCustomerType();

        public static void GetListCustomers()
        {
            Console.WriteLine("List of customers:");
            int count = 0;
            foreach (var customer in listCustomers)
            {
                count++;
                Console.Write($"{count}.");
                customer.PrintDetails();
            }
            Console.WriteLine();
        }

        public string GetName()
        {
            return this.Name;
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine($"Customer {this.Name} is a(n) {this.GetCustomerType()}");
        }
    }
}
