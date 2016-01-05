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
        private int totalPoints;
        //protected ArrayList classes = new ArrayList();

        public Student(int id) : base(id) { }

        public double GradePointAverage =>
            (totalClassesTaken != 0) ? (double)sumOfLetterGrades / (double)totalClassesTaken : 0;

        public void RecordClassGrade(Grade letterGrade)
        {
            this.sumOfLetterGrades += (int)letterGrade;
            this.totalClassesTaken++;
        }

        internal void AssignGrade(string assigment, int points)
        {
            totalPoints += points;
        }

    }
}
