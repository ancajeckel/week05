using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApp
{
    interface IOrder
    {
        decimal GetAgreedPrice();

        void ValidateOrder(int estDeliveryTimeWeeks, decimal discount);

        void UpdateOrder(IPerson person, string newStatus);

        void CancelOrder(IPerson byPerson);

        void PrintOrderDetails();
    }
}
