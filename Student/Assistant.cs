using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Assistant : Student, ITeahing
    {
        public Assistant(int id) : base(id) { }

        private List<string> classes = new List<string>();

        public IEnumerable<string> ClassTitles => classes;       

        public string SubjectArea { get; set; }

        public void AddClassTitle(string title)
        {
            if (classes.Contains(title))
                return;
            if (classes.Count < 2)
                classes.Add(title);
            else
                throw new InvalidOperationException("Fuck you");
        }

        public void RemoveClassTitle(string title)
        {
            classes.Remove(title);
        }
    }
}
