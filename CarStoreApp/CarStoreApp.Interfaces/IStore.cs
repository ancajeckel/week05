using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreApp.Interfaces
{
    public interface IStore
    {
        string Name { get; set; }

        string Location { get; set; }

        void AddCar(ICar car);

        void RemoveCar(ICar car);

        void Visit(ICustomer customer);

        IOrder OrderCar(ICustomer customer, string modelName, int estDaysDelivery);

        void ConfirmOrder(int orderNumber, decimal discount);

        void CancelOrder(int orderNumber);

        void ReceiveOrder(int orderNumber);

        void DeliverOrder(int orderNumber);

        IIssue ReportProblem(int orderNumber, string problem);

        void CheckProblem(IIssue issue, int fixInDays);

        void FixProblem(IIssue issue);
    }
}
