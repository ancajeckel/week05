using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClasses.Interfaces;

namespace SchoolClasses.Models
{
    public abstract class People : IPeople, IFreeTexts
    {
        public string Name { get; private set; }

        public string Comments { get; private set; }

        public People (string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return this.Name;
        }

        public abstract string GetPeopleType();

        public virtual void PrintDetails()
        {
            Console.WriteLine($"Person {this.Name} is a {this.GetPeopleType()}");
        }

        public void AddComments(string comments)
        {
            this.Comments = comments;
        }

        public string GetComments()
        {
            return this.Comments;
        }
    }
}
