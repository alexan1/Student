using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Student
    {
        private int sumOfLetterGrades;
        private int totalClassesTaken;

        public Student(int id)
        {
            this.Id = id;
        }

        public int Id { get; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double GradePointAverage =>
            (totalClassesTaken != 0) ? (double)sumOfLetterGrades / (double)totalClassesTaken : 0;

        public void RecordClassGrade(Grade letterGrade)
        {
            this.sumOfLetterGrades += (int)letterGrade;
            this.totalClassesTaken++;
        }
    }
}
