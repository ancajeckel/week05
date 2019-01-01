using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreApp.Interfaces
{
    public interface ICar
    {
        string Name { get; set; }

        decimal Price { get; set; }

        DateTime Year { get; set; }

        IProducer Producer { get; set; }
    }
}
