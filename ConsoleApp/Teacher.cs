using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Teacher : Student
    {
        public string Position { set; get; }
        public string Chair { set; get; }
        public string NameOfUnivercity { set; get; }

        public Teacher(string firstname, string lastname, DateTime dateOfBirth, int course, string group, string faculty, string nameunivercity,
            string position, string chair, string nameofunivercity) : base(firstname, lastname, dateOfBirth, course, group, faculty, nameunivercity)
        {
            Position = position;
            Chair = chair;
            NameOfUnivercity = nameunivercity;
        }
        public void GetTeach()
        {
            Console.WriteLine($"Посада: {GetPosition()}\nКафедра: {GetChair()}");
        }
        public string GetPosition()
        {
            return Position;
        }
        public string GetChair()
        {
            return Chair;
        }
    }

}
