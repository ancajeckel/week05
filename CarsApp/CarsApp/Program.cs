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
            // add car brands
            Producer ford = new Producer("Ford");
            Producer skoda = new Producer("Skoda");

            // add stores
            Store fordStoreBuc = new Store("Ford Store", "Bucuresti", ford);
            fordStoreBuc.PrintStoreDetails();
            Store skodaStoreIs = new Store("Skoda Store", "Iasi", skoda);


            
            Console.ReadKey();
        }
    }
}
