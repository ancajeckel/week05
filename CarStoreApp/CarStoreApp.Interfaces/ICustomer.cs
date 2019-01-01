using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreApp.Interfaces
{
    public interface ICustomer
    {
        string Name { get; set; }

        string Email { get; set; }

        string Phone { get; set; }
    }
}
