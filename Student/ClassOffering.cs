using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class ClassOffering
    {
        private readonly Teacher leadInstructor;
        private readonly List<TeachingAssistant> assistants = new List<TeachingAssistant>();
        private readonly List<Student> students = new List<Student>();
        private readonly Func<string, string, int> gradingFunc;

        public ClassOffering(Teacher leadInstructor, Func<string, string, int> gradingFunction)
        {
            this.leadInstructor = leadInstructor;
            this.gradingFunc = gradingFunction;
        }

        public void TurnInAssigment(Student enrollee, string assigment, string result)
        {
            var points = gradingFunc(assigment, result);
            enrollee.AssignGrade(assigment, points);
        }

        public double AverageGPAForStudents()
        {
            return Enumerable.Average(students.Select(s => s.GradePointAverage));
        }
    }
}
