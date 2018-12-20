using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApp
{
    interface IVehicle
    {
        int GetVehicleAge();

        void ReportIssue(string issue);

        void PrintVehicleDetails();
    }
}
