using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses.Models
{
    public class Student : People
    {
        public Classs Classs { get; }

        private static List<Student> listStudents = new List<Student>();

        public Student(string name, Classs classs) : base(name)
        {
            this.Classs = classs;
            listStudents.Add(this);
        }

        public static List<Student> GetListStudents()
        {
            return listStudents;
        }

        public override string GetPeopleType()
        {
            return "student";
        }
    }
}
