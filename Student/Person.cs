﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public abstract class Person
    {
        protected Person(int id)
        {
            this.Id = id;
        }
        public int Id { get; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
