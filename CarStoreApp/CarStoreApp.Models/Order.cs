using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarStoreApp.Interfaces;

namespace CarStoreApp.Models
{
    public class Order : IOrder
    {
        public int Nr { get; set; }

        private static int nrCount = 0;

        public DateTime Date { get; set; }

        public DateTime EstimatedDeliveryDate { get; set; }

        public OrderStatus Status { get; set; }

        public ICar Car { get; set; }

        public ICustomer Customer { get; set; }

        public IStore Store { get; set; }

        public decimal Discount { get; set; }

        public static int GetNextNr()
        {
            nrCount++;
            return nrCount;
        }

        public decimal GetDiscountedPrice()
        {
            if (this.Discount != 0)
            {
                return this.Car.Price - this.Car.Price * this.Discount / 100;
            }
            return this.Car.Price;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Order {this.Nr} for {this.Car.Name} {this.Car.Year}, ${this.GetDiscountedPrice()} ({this.Status})");
            if (this.EstimatedDeliveryDate > DateTime.Now)
            {
                Console.WriteLine($"\t* estimated delivery date: {this.EstimatedDeliveryDate}");
            }
        }
    }
}
