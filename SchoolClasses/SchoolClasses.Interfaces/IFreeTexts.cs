using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses.Interfaces
{
    public interface IFreeTexts
    {
        void AddComments(string comments);

        string GetComments();
    }
}
