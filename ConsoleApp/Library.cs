using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Library : Student
    {
        public int ReadersTicketNumber { set; get; }

        public DateTime DateOfIssue { set; get; }
        public int MonthlyFee { set; get; }

        public Library(string firstname, string lastname, DateTime dateOfBirth, int course, string group, string faculty, string nameunivercity,
            int readersticketnumber, DateTime dateTime, int monthlyfee) : base(firstname, lastname, dateOfBirth, course, group, faculty, nameunivercity)
        {
            ReadersTicketNumber = readersticketnumber;
            DateOfIssue = dateTime;
            MonthlyFee = monthlyfee;
        }
        public void GetTeach()
        {
            Console.WriteLine($"Номер квитка :{GetReadersTicketNumber()}, Розмір щомісячного читацького внеску : {GetMonthlyFee()}");
        }
        public int GetReadersTicketNumber()
        {
            return ReadersTicketNumber;
        }
        public int GetMonthlyFee()
        {
            return MonthlyFee;
        }
    }

}
