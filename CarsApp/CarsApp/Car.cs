using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApp
{
    class Car : IVehicle
    {
        public Producer Model { get; private set; }

        public int Year { get; private set; }

        public int BasePrice { get; private set; }

        public Car(Producer model, int year, int basePrice)
        {
            this.Model = model;
            this.Year = year;
            this.BasePrice = basePrice;
        }

        public int GetVehicleAge()
        {
            return DateTime.Now.Year - this.Year;
        }

        public void PrintVehicleDetails()
        {
            Console.WriteLine($"Car model: {this.Model.Name} ({this.Year}), base price: {this.BasePrice}");
        }
    }
}
