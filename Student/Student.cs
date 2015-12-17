using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Student : Person
    {
        private int sumOfLetterGrades;
        private int totalClassesTaken;

        public Student(int id) : base(id) { }

        public double GradePointAverage =>
            (totalClassesTaken != 0) ? (double)sumOfLetterGrades / (double)totalClassesTaken : 0;

        public void RecordClassGrade(Grade letterGrade)
        {
            this.sumOfLetterGrades += (int)letterGrade;
            this.totalClassesTaken++;
        }
    }
}
