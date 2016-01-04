using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Professor : Person, ITeahing
    {
        public Professor(int id) : base(id) { }              

        public string SubjectArea { get; set; }

        private List<string> classTitles = new List<string>();

        public void AddClassTitle(string title)
        {
            if (!classTitles.Contains(title))
                classTitles.Add(title);
        }

        public void RemoveClassTitle(string title)
        {           
            classTitles.Remove(title);
        }

        public IEnumerable<string> ClassTitles => classTitles;

        //public IEnumerable ClassTitles { get; set; }
    }
}
