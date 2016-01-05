using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Teacher : Person, ITeahing
    {

        public EventHandler<AddClassEventArgs> OnClassAdded;
        public Teacher(int id) : base(id) { }              

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

        public void AddNewClassTitle(string title)
        {
            if(!ClassTitles.Contains(title))
            {
                classTitles.Add(title);
                OnClassAdded?.Invoke(this, new AddClassEventArgs(title, this.SubjectArea));
            }
        }

        //public IEnumerable ClassTitles { get; set; }
    }

    public class AddClassEventArgs : EventArgs
    {
        public string ClassTitle { get; }

        public string Subject { get; }

        public AddClassEventArgs(string title, string subject)
        {
            this.ClassTitle = title;
            this.Subject = subject;
        }
    }
}
