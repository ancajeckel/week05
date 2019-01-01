using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreApp.Interfaces
{
    public interface IIssue
    {
        int Nr { get; set; }

        ICar Car { get; set; }

        string Details { get; set; }

        IssueStatus Status { get; set; }

        DateTime EstimatedFixDate { get; set; }

        void PrintDetails();
    }

    public enum IssueStatus
    {
        Pending,
        InWork,
        Closed
    }
}
