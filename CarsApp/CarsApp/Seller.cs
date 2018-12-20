using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApp
{
    public class Seller : IPerson
    {
        public string Name { get; private set; }

        public int LicenseNo { get; private set; }

        public Seller(string name, int licenseNo)
        {
            this.Name = name;
            this.LicenseNo = licenseNo;
        }

        public string GetName()
        {
            return this.Name;
        }

        public void PrintPersonDetails()
        {
            Console.WriteLine($"Seller representant {this.Name} (license no={this.LicenseNo})");
        }
    }
}
