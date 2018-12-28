using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClasses.Interfaces;

namespace SchoolClasses.Models
{
    public class Classs : IFreeTexts
    {
        public string ClassNo { get; private set; }

        public string Comments { get; protected set; }

        public static List<Classs> setClasses = new List<Classs>();

        public Classs(string classNo)
        {
            this.ClassNo = classNo;
            setClasses.Add(this);
        }

        public List<Teacher> setTeachers = new List<Teacher>();

        public void AddTeacher(Teacher teacher)
        {
            setTeachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            setTeachers.Remove(teacher);
        }

        public List<Teacher> GetSetTeachers()
        {
            return setTeachers;
        }

        public void AddComments(string comments)
        {
            this.Comments = comments;
        }

        public string GetComments()
        {
            return this.Comments;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"--------Class {this.ClassNo}----------");
            if (this.Comments != "" && this.Comments != null)
            {
                Console.WriteLine($"({this.Comments})");
            }
        }
    }
}
