using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreApp.Interfaces
{
    public interface IProducer
    {
        string Name { get; set; }

        string Address { get; set; }
    }
}
