using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarStoreApp.Interfaces;

namespace CarStoreApp.Models
{
    public class Car : ICar
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public DateTime Year { get; set; }

        public IProducer Producer { get; set; }
    }
}
