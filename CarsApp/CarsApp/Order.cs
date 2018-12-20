using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApp
{
    class Order : IOrder
    {
        private int lastOrderNo = 0;

        public int OrderNo { get; private set; }

        public DateTime DateOfEntry { get; private set; }

        public Customer Buyer { get; private set; }

        public Store Seller { get; private set; }

        public Car Item { get; private set; }

        public string Status { get; private set; }

        public decimal Discount { get; private set; }

        public Order(Customer buyer, Store seller, Car car, Decimal discount)
        {
            lastOrderNo++;
            this.OrderNo = lastOrderNo;
            this.DateOfEntry = DateTime.Now;
            this.Buyer = buyer;
            this.Seller = seller;
            this.Item = car;
            this.Discount = discount;
            this.Status = "new";
        }

        public decimal GetAgreedPrice()
        {
            return this.Item.BasePrice - (this.Item.BasePrice * this.Discount / 100);
        }

        public void PrintOrderDetails()
        {
            Console.WriteLine($"Order nr. {this.OrderNo}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"entered {this.DateOfEntry}, between {this.Buyer.Name} (buyer) and {this.Seller.Name} (seller)");
            this.Item.PrintVehicleDetails();
            Console.WriteLine($"Price with discount: {this.GetAgreedPrice()}");
            Console.WriteLine($"Status: {this.Status}");
        }
    }
}
