using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // add car brands (producers)
            Producer ford = new Producer("Ford");
            Producer skoda = new Producer("Skoda");

            // add stores
            Store fordStoreBuc = new Store("Ford Store", "Bucuresti", ford);
            fordStoreBuc.PrintStoreDetails();
            Store skodaStoreIs = new Store("Skoda Store", "Iasi", skoda);
            skodaStoreIs.PrintStoreDetails();

            // add cars stock
            Car fordFocus = new Car(ford, 2015, 15625);
            Car fordFiesta = new Car(ford, 2010, 11500);
            Car fordEcosport = new Car(ford, 2018, 18000);


            // here Alex comes to the story
            Customer Alex = new Customer("Alex", "+40-755-012345");

            // Alex goes to the FordStore and checks the offer
            Console.WriteLine("Ford offer: ");
            foreach (var car in Car.GetListCars(ford))
            {
                car.PrintVehicleDetails();
            }

            // Alex decides for FordFocus and places an order
            Console.WriteLine("Placing offer: ");
            Order order1 = new Order(Alex, fordStoreBuc, fordFocus, 4);
            order1.PrintOrderDetails();

            Console.ReadKey();
        }
    }
}
