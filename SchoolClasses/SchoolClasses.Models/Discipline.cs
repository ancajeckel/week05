using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClasses.Interfaces;

namespace SchoolClasses.Models
{
    public class Discipline : IFreeTexts
    {
        public string Name { get; private set; }

        public int NoOfLectures { get; private set; }

        public int NoOfExercises { get; private set; }

        public string Comments { get; private set; }

        public Discipline(string name, int noOfLectures, int noOfExercises)
        {
            this.Name = name;
            this.NoOfLectures = noOfLectures;
            this.NoOfExercises = noOfExercises;
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
