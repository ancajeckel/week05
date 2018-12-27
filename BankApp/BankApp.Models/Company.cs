using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Models
{
    public class Company : Customer
    {
        public int RegistrationNr { get; private set; }

        public Company(string name, int registrationNr ) : base(name)
        {
            this.RegistrationNr = registrationNr;
        }

        public override string GetCustomerType()
        {
            return "Company";
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"Customer {this.Name} is a(n) {this.GetCustomerType()} (registration: {this.RegistrationNr})");
        }
    }
}
