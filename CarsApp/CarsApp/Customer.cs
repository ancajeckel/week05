using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApp
{
    class Customer : IPerson
    {
        public string Name { get; set; }

        public string TelNumber { get; set; }

        public Customer(string name, string telNumber)
        {
            this.Name = name;
            this.TelNumber = telNumber;
        }

        public void PrintPersonDetails()
        {
            Console.WriteLine($"Customer {this.Name}, contact number{this.TelNumber}");
        }
    }
}
