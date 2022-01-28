using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Entrant : Human
    {
        public int MarkForZNO { set; get; }
        public int MarkForDocumentEducation { set; get; }
        public string NameForEducationUniversity { set; get; }

        public Entrant(string firstname, string lastname, DateTime dateOfBirth, int markforzno, int markfordocumenteducation, string nameforeducationuniversity) : base(firstname, lastname, dateOfBirth)
        {
            MarkForZNO = markforzno;
            MarkForDocumentEducation = markfordocumenteducation;
            NameForEducationUniversity = nameforeducationuniversity;
        }
        public int GetMark()
        {
            int a = 0;
            a = MarkForZNO + MarkForDocumentEducation;
            return a;
        }
    }

}
