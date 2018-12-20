using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApp
{
    class Store : IStore
    {
        public string Name { get; private set; }

        public string City { get; private set; }

        public Producer MainBrand { get; private set; }

        public IPerson Representant { get; private set; }

        public Store(string name, string city, Producer mainBrand, IPerson representant)
        {
            this.Name = name;
            this.City = city;
            this.MainBrand = mainBrand;
            this.Representant = representant;
        }

        public void CheckStoreOffer(IPerson person)
        {
            Console.WriteLine("");
            Console.WriteLine($"{person.GetName()} checks {this.MainBrand.Name} offer: ");
            foreach (var car in Car.GetListCars(this.MainBrand))
            {
                car.PrintVehicleDetails();
            }
        }
        
        public void PrintStoreDetails()
        {
            Console.WriteLine($"The store {this.Name} is located in {this.City} and deals {this.MainBrand.Name}");
        }
    }
}
