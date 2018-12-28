using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses.Models
{
    public class Teacher : People
    {
        public Teacher(string name) : base(name) { }

        private List<Discipline> setDisciplines = new List<Discipline>();

        public void AddDiscipline(Discipline discipline)
        {
            setDisciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            setDisciplines.Remove(discipline);
        }

        public string GetSetDisciplines()
        {
            var listDisc = "";
            foreach (var discipline in setDisciplines)
            {
                listDisc = listDisc + discipline.Name + ",";
            }
            return listDisc.Substring(0,listDisc.Length - 1);
        }

        public override string GetPeopleType()
        {
            return "teacher";
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"Person {this.Name} is a {this.GetPeopleType()} ({GetSetDisciplines()})");
        }
    }
}
