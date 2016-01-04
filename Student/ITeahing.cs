using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Student
{
    interface ITeahing
    {
        string SubjectArea { get; set; }

        IEnumerable<string> ClassTitles { get; }

        void AddClassTitle(string title);

        void RemoveClassTitle(string title);

    }
}
