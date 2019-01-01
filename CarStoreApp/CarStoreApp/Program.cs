using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarStoreApp.Models;
using CarStoreApp.Interfaces;

namespace CarStoreApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ICustomer alex = new Customer
            {
                Name = "Alex",
                Email = "alex@yahoo.com",
                Phone = "0712 121 212"
            };

            IStore fordStore = CreateFordStore();
            IStore skodaStore = CreateSkodaStore();

            fordStore.Visit(alex);

            IOrder fordOrderForAlex = fordStore.OrderCar(alex, "Focus", 28);
            fordStore.ConfirmOrder(1, 10);

            skodaStore.Visit(alex);

            IOrder skodaOrderForAlex = skodaStore.OrderCar(alex, "Fabia", 21);
            skodaStore.ConfirmOrder(2, 0);

            fordStore.CancelOrder(fordOrderForAlex.Nr);

            skodaStore.ReceiveOrder(skodaOrderForAlex.Nr);
            skodaStore.DeliverOrder(skodaOrderForAlex.Nr);

            IIssue iss1 = skodaStore.ReportProblem(2, $"front spoiler problem reported by {alex.Name}");
            skodaStore.CheckProblem(iss1, 2);
            skodaStore.FixProblem(iss1);

            Console.ReadKey();
        }

        private static IStore CreateSkodaStore()
        {
            IProducer skoda = new Producer
            {
                Name = "Skoda",
                Address = "Skoda address"
            };

            ICar skodaFabia = new Car
            {
                Name = "Fabia",
                Price = 14000,
                Producer = skoda,
                Year = new DateTime(2018, 1, 1)
            };

            ICar skodaOctavia = new Car
            {
                Name = "Octavia",
                Price = 19000,
                Producer = skoda,
                Year = new DateTime(2017, 1, 1)
            };

            IStore store = new Store
            {
                Name = "Skoda Store",
                Location = "Iasi"
            };

            store.AddCar(skodaFabia);
            store.AddCar(skodaOctavia);

            return store;
        }

        private static IStore CreateFordStore()
        {
            IProducer ford = new Producer
            {
                Name = "Ford",
                Address = "Ford address"
            };

            ICar fordFocus = new Car
            {
                Name = "Focus",
                Price = 16500,
                Producer = ford,
                Year = new DateTime(2015, 1, 1)
            };

            ICar fordEcosport = new Car
            {
                Name = "Ecosport",
                Price = 18000,
                Producer = ford,
                Year = new DateTime(2018, 1, 1)
            };

            IStore store = new Store
            {
                Name = "Ford Store",
                Location = "Iasi"
            };

            store.AddCar(fordFocus);
            store.AddCar(fordEcosport);

            return store;
        }
    }
}
