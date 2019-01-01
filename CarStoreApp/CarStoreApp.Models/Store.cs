using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarStoreApp.Interfaces;

namespace CarStoreApp.Models
{
    public class Store : IStore
    {
        private readonly List<ICar> _cars = new List<ICar>();

        private readonly List<IOrder> _orders = new List<IOrder>();

        public string Name { get; set; }

        public string Location { get; set; }

        public void AddCar(ICar car)
        {
            _cars.Add(car);
        }

        public void RemoveCar(ICar car)
        {
            _cars.Remove(car);
        }

        public void Visit(ICustomer customer)
        {
            Console.WriteLine($"{customer.Name} visits {Name} store:");

            foreach (var _car in _cars)
            {
                Console.WriteLine($"\tCar {_car.Name}, model {_car.Year}, base price ${_car.Price}");
            }
        }

        public IOrder OrderCar(ICustomer customer, string modelName, int estDaysDelivery)
        {
            var car = FindCar(modelName);

            IOrder order = new Order
            {
                Car = car,
                Customer = customer,
                Date = DateTime.Now,
                EstimatedDeliveryDate = DateTime.Now.AddDays(estDaysDelivery),
                Nr = Order.GetNextNr(),
                Status = OrderStatus.Pending,
                Store = this
            };

            _orders.Add(order);

            order.PrintDetails();

            return order;
        }

        public IOrder FindOrderByNumber(int nr)
        {
            foreach (var _order in _orders)
            {
                if (_order.Nr == nr)
                {
                    return _order;
                }
            }
            Console.WriteLine($"The order {nr} could not been found!");
            return null;
        }

        public void ConfirmOrder(int orderNumber, decimal discount)
        {
            IOrder tempOrder = FindOrderByNumber(orderNumber);
            if (tempOrder != null)
            {
                tempOrder.Status = OrderStatus.Confirmed;
                tempOrder.Discount = discount;
                tempOrder.PrintDetails();
            }
        }

        public void CancelOrder(int orderNumber)
        {
            IOrder tempOrder = FindOrderByNumber(orderNumber);
            if (tempOrder != null)
            {
                tempOrder.Status = OrderStatus.Cancelled;
                tempOrder.EstimatedDeliveryDate = DateTime.MinValue;
                tempOrder.PrintDetails();
            }
        }

        public void ReceiveOrder(int orderNumber)
        {
            IOrder tempOrder = FindOrderByNumber(orderNumber);
            if (tempOrder != null)
            {
                tempOrder.Status = OrderStatus.Received;
                tempOrder.EstimatedDeliveryDate = DateTime.MinValue;
                tempOrder.PrintDetails();
            }
        }

        public void DeliverOrder(int orderNumber)
        {
            IOrder tempOrder = FindOrderByNumber(orderNumber);
            if (tempOrder != null)
            {
                tempOrder.Status = OrderStatus.Delivered;
                tempOrder.EstimatedDeliveryDate = DateTime.MinValue;
                tempOrder.PrintDetails();
            }
        }

        public IIssue ReportProblem(int orderNumber, string problem)
        {
            IOrder tempOrder = FindOrderByNumber(orderNumber);
            if (tempOrder != null)
            {
                IIssue issue = new Issue(tempOrder.Car, problem);
                return issue;
            }
            return null;
        }

        public void CheckProblem(IIssue issue, int fixInDays)
        {
            issue.Status = IssueStatus.InWork;
            issue.EstimatedFixDate = DateTime.Now.AddDays(fixInDays);
            issue.PrintDetails();
        }

        public void FixProblem(IIssue issue)
        {
            issue.Status = IssueStatus.Closed;
            issue.EstimatedFixDate = DateTime.MinValue;
            issue.PrintDetails();
        }

        private ICar FindCar(string modelName)
        {
            foreach (var car in _cars)
                if (car.Name.ToLower() == modelName.ToLower())
                    return car;

            return null;
        }
    }
}
