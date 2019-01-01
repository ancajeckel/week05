using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarStoreApp.Interfaces;

namespace CarStoreApp.Models
{
    public class Issue : IIssue
    {
        private static int _nextIssueNr = 0;

        public int Nr { get; set; }

        public ICar Car { get; set; }

        public string Details { get; set; }

        public IssueStatus Status { get; set; }

        public Issue(ICar car, string details)
        {
            _nextIssueNr++;
            this.Nr = _nextIssueNr;
            this.Car = car;
            this.Details = details;
            this.Status = IssueStatus.Pending;
            PrintDetails();
        }

        public DateTime EstimatedFixDate { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"Issue {this.Nr}: {this.Details} ({this.Status})");
            if (this.EstimatedFixDate >= DateTime.Now)
            {
                Console.WriteLine($"\t*Estimated Fix Day: {this.EstimatedFixDate}");
            }
        }
    }
}
