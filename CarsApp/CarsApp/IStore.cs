using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApp
{
    interface IStore
    {
        void CheckStoreOffer(IPerson person);

        void PrintStoreDetails();
    }
}
