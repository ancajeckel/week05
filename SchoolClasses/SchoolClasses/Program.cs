using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClasses.Models;

namespace SchoolClasses.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateSchoolData();
            DisplaySchoolData();
            Console.ReadKey();
        }

        public static void DisplaySchoolData()
        {
            // loop through all classes
            foreach (var classs in Classs.setClasses)
            {
                classs.PrintDetails();

                // get teachers
                foreach (var teacher in classs.setTeachers)
                {
                    teacher.PrintDetails();
                }

                // get students
                foreach (var student in Student.GetListStudents())
                {
                    if (student.Classs.ClassNo == classs.ClassNo)
                    {
                        student.PrintDetails();
                    }
                }
            }
        }

        public static void CreateSchoolData()
        {
            // create classes
            Classs fiveB = new Classs("5B");
            Classs nineA = new Classs("9A");
            nineA.AddComments("some comments go here");

            // create students
            Student s1 = new Student("Student 1", fiveB);
            Student s2 = new Student("Student 2", fiveB);
            Student s3 = new Student("Student 3", nineA);
            Student s4 = new Student("Student 4", nineA);
            Student s5 = new Student("Student 5", nineA);

            // create discipline
            Discipline english = new Discipline("English", 5, 20);
            Discipline math = new Discipline("Math", 6, 25);
            Discipline chemistry = new Discipline("Chemistry", 2, 10);

            // create teachers and assign disciplines, resp. classes
            Teacher teach1 = new Teacher("Teach1");
            teach1.AddDiscipline(english);
            Teacher teach2 = new Teacher("Teach2");
            teach2.AddDiscipline(math);
            teach2.AddDiscipline(chemistry);
            Teacher teach3 = new Teacher("Teach3");
            teach3.AddDiscipline(english);
            teach3.AddDiscipline(math);

            fiveB.AddTeacher(teach1);
            fiveB.AddTeacher(teach2);
            nineA.AddTeacher(teach3);
        }
    }
}
