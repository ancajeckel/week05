using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreApp.Interfaces
{
    public interface IOrder
    {
        int Nr { get; set; }

        DateTime Date { get; set; }

        DateTime EstimatedDeliveryDate { get; set; }

        OrderStatus Status { get; set; }

        ICar Car { get; set; }

        ICustomer Customer { get; set; }

        IStore Store { get; set; }

        decimal Discount { get; set; }

        decimal GetDiscountedPrice();

        void PrintDetails();

    }

    public enum OrderStatus
    {
        Pending,
        Confirmed,
        Cancelled,
        Received,
        Delivered
    }
}
