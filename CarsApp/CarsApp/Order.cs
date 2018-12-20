using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApp
{
    class Order : IOrder
    {
        private static int lastOrderNo;

        public int OrderNo { get; private set; }

        public DateTime DateOfEntry { get; private set; }

        public Customer Buyer { get; private set; }

        public Store Dealer { get; private set; }

        public Car Item { get; private set; }

        public int Quantity { get; private set; }

        public string Status { get; private set; }

        public decimal Discount { get; private set; }

        public int EstimatedDeliveryTime { get; set; }

        public IPerson LastUpdatedBy { get; set; }

        public Order(Customer buyer, Store dealer, Car car, int quantity)
        {
            lastOrderNo++;
            this.OrderNo = lastOrderNo;
            this.DateOfEntry = DateTime.Now;
            this.Buyer = buyer;
            this.Dealer = dealer;
            this.Item = car;
            this.Quantity = quantity;
            this.Status = "new";
            this.LastUpdatedBy = this.Buyer;
            Message.Print($"{this.Buyer.Name} is placing the order:");
        }

        public decimal GetAgreedPrice()
        {
            return this.Quantity * ( this.Item.BasePrice - (this.Item.BasePrice * this.Discount / 100) );
        }

        public void ValidateOrder(int estDeliveryTimeWeeks, decimal discount)
        {
            this.EstimatedDeliveryTime = estDeliveryTimeWeeks;
            this.Discount = discount;
            this.Status = "confirmed";
            this.LastUpdatedBy = this.Dealer.Representant;
            Message.Print($"{this.Dealer.Name} validated the order and offered discount");
        }

        public void CancelOrder(IPerson byPerson)
        {
            this.Quantity = 0;
            this.Status = "cancelled";
            this.EstimatedDeliveryTime = 0;
            this.LastUpdatedBy = byPerson;
            PrintNewStatus();
        }

        public void UpdateOrder(IPerson person, string newStatus)
        {
            this.Status = newStatus;
            if (newStatus == "delivered")
            {
                this.EstimatedDeliveryTime = 0;
            }
            this.LastUpdatedBy = person;
            PrintNewStatus();
        }

        private void PrintNewStatus()
        {
            Message.Print($"Order {this.OrderNo} has now the status: {this.Status} (by {this.LastUpdatedBy.GetName()})");
        }

        public void PrintOrderDetails()
        {
            Console.WriteLine($"Order nr. {this.OrderNo}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"entered {this.DateOfEntry}, between {this.Buyer.Name} (buyer) and {this.Dealer.Name} (seller)");
            this.Item.PrintVehicleDetails();
            if (this.Discount != 0)
            {
                Console.WriteLine($"Price with discount: ${this.GetAgreedPrice()}");
            }
            Console.WriteLine($"Status: {this.Status}");
            if (this.EstimatedDeliveryTime != 0)
            {
                Console.WriteLine($"Estimated delivery time: {this.EstimatedDeliveryTime} weeks");
            }
            Console.WriteLine($"(last updated by {this.LastUpdatedBy.GetName()})");
        }
    }
}
