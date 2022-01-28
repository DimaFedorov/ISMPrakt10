using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Student : Human
    {
        public int Course { set; get; }
        public string Group { set; get; }
        public string Faculty { set; get; }
        public string NameUnivercity { set; get; }
        public Student(string firstname, string lastname, DateTime dateOfBirth, int course, string group, string faculty, string nameunivercity) : base(firstname, lastname, dateOfBirth)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            NameUnivercity = nameunivercity;
        }
    }

}
