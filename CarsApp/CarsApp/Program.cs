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
            Seller s1 = new Seller("Mr. X", 12345);
            Store fordStoreBuc = new Store("Ford Store", "Bucuresti", ford, s1);
            Console.WriteLine("Alex checks Ford store: ");
            fordStoreBuc.PrintStoreDetails();

            Seller s2 = new Seller("Mr. W", 55467);
            Store skodaStoreIs = new Store("Skoda Store", "Iasi", skoda, s2);
            //skodaStoreIs.PrintStoreDetails();

            // add cars stock
            Car fordFocus = new Car(ford, 2015, "icy blue", 15625);
            Car fordFiesta = new Car(ford, 2010, "metallic grey", 11500);
            Car fordEcosport = new Car(ford, 2018, "red", 19800);
            Car skodaOctavia = new Car(skoda, 2018, "frog green", 20500);
            Car skodaFabia = new Car(skoda, 2018, "white", 17500);

            // here Alex comes to the story
            Customer Alex = new Customer("Alex", "+40-755-012345");

            // Alex goes to the FordStore and checks the offer
            fordStoreBuc.CheckStoreOffer(Alex);

            // Alex decides for FordFocus and places an order
            Order order1 = new Order(Alex, fordStoreBuc, fordFocus, 1);
            order1.PrintOrderDetails();

            // Ford store validates the order
            order1.ValidateOrder(4, 4);
            order1.PrintOrderDetails();

            // Alex goes also to Skoda store and checks the offer
            skodaStoreIs.CheckStoreOffer(Alex);

            // Alex decides for SkodaFabia and places an order
            Order order2 = new Order(Alex, skodaStoreIs, skodaFabia, 1);
            order2.PrintOrderDetails();

            // Skoda store validates the order
            order2.ValidateOrder(3, 20);
            order2.PrintOrderDetails();

            // Alex cancels original order
            order1.CancelOrder(Alex);

            // Car was delivered
            order2.UpdateOrder(skodaStoreIs.Representant, "delivered");

            // Alex report problem
            order2.UpdateOrder(Alex, "issue reported - front spoiler");

            // Dealer forwards problem
            skodaFabia.ReportIssue("front spoiler");

            Console.ReadKey();
        }
    }
}
