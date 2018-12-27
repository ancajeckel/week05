using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Interfaces
{
    public interface IBank
    {
        IAccount OpenAccount(ICustomer customer, string accountType);

        void CloseAccount(IAccount account);

        List<IAccount> GetListAccounts();
    }
}
