using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startIndex = 0;
            int maxRows = 20;

            using(dbObjectEntities entities = new dbObjectEntities())
            {
                IList<Facultati> facultatiList = (from Facultati in entities.Facultatis select Facultati)
                    .OrderBy(Facultati => Facultati.Id)
                    .Skip(startIndex).Take(maxRows) .ToList();
                foreach(Facultati cust in facultatiList)
                {
                    Console.WriteLine($"Nume facultate: {cust.NumeFac} , cod: {cust.Code} , id: {cust.Id}");
                }
            }
        }
    }
}
