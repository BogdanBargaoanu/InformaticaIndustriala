using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(DataClasses1DataContext db = new DataClasses1DataContext())
            {
                try
                {
                    var query = from Facultati in db.Facultatis
                                select new
                                {
                                    Id = Facultati.Id,
                                    NumeFac = Facultati.NumeFac,
                                    Code  = Facultati.Code
                                };
                    foreach (var item in query)
                    {
                        Console.WriteLine($"Nume fac: {item.NumeFac}, cod: {item.Code}, id: {item.Id}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
