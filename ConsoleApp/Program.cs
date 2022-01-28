using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Entrant entrant = new Entrant("Dmytro", "Fedorov", new DateTime(2003, 05, 13), 352, 112, "School #12");
            
            Teacher teacher = new Teacher("Dmytro", "Fedorov", new DateTime(2003, 05, 13), 2, "Бд-ПОцфт", "Фізико-математичний", "ЖДУ імені Іфана Франка",
                "Вчитель математики", "Фізико-математичний", "ЖДУ імені Іфана Франка");

            Library library = new Library("Dmytro", "Fedorov", new DateTime(2003, 05, 13), 2, "Бд-ПОцфт", "Фізико-математичний", "ЖДУ імені Іфана Франка",152,new DateTime(2021,09,25),82);

            Console.WriteLine($"Вік: {entrant.GetAge()}");
            Console.WriteLine($"Cумарна кількість балів ЗНО та за документ про освіту: {entrant.GetMark()}");
            teacher.GetStud();
            teacher.GetTeach();
            library.GetLib();
            Console.ReadKey();
        }
    }
}
