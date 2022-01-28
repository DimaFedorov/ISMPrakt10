using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Human
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }

        public Human(string firstname, string lastname, DateTime dateTime)
        {
            LastName = lastname;
            FirstName = firstname;
            DateOfBirth = dateTime;
        }
        public int GetAge()
        {
            TimeSpan age = DateTime.Now - DateOfBirth;
            return (int)(age.TotalDays / 365);
        }
    }

}
