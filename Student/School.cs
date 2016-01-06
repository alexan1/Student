using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class School
    {
        
    }   

    public static class Extensions
    {
        public static IEnumerable<Student> SortByName(this IEnumerable<Student> students)
        {
            return students.OrderBy(s => s.LastName)
                .ThenBy(s => s.FirstName);
        }

        public static IEnumerable<Student> SortByGrade(this IEnumerable<Student> students)
        {
            return students.OrderByDescending(s => s.GradePointAverage);
        }

        public static Teacher HardestGrader(this IEnumerable<Teacher> instructors)
        {
            return instructors.Aggregate((min, current) =>
            {
                if (min.AverageStudentGrade() < current.AverageStudentGrade())
                    return min;
                else
                    return current;
            });
        }

        public static Teacher EasiestGrader(this IEnumerable<Teacher> instructors)
        {
            return instructors.Aggregate((max, current) =>
            {
                if (max.AverageStudentGrade() < current.AverageStudentGrade())
                    return max;
                else
                    return current;
            });
        }
    }
}
