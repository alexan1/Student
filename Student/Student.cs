using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Student
{
    public class Student : Person
    {
        private int sumOfLetterGrades;
        private int totalClassesTaken;
        //protected ArrayList classes = new ArrayList();

        public Student(int id) : base(id) { }

        public double GradePointAverage =>
            (totalClassesTaken != 0) ? (double)sumOfLetterGrades / (double)totalClassesTaken : 0;

        public void RecordClassGrade(Grade letterGrade)
        {
            this.sumOfLetterGrades += (int)letterGrade;
            this.totalClassesTaken++;
        }

        //public virtual string SubjectArea { get; set; }

        //public IEnumerable ClassTitles { get; set; }

        //public void AddClassTitle(string title)
        //{
        //    if (!classes.Contains(title))
        //        classes.Add(title);
        //}

        //public void RemoveClassTitle(string title)
        //{
        //    classes.Remove(title);
        //}

    }
}
