using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Framework
{
    internal class Greutate
    {
        public static double GreutateIdeala()
        {
            Console.WriteLine("Introduceti inaltimea in cm: ");
            double inaltime = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduceti varsta: ");
            double varsta = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduceti sexul (m/f): ");
            char input = Convert.ToChar(Console.ReadLine());
            if(input == 'm')
            {
                return inaltime - 100 - (inaltime - 150) / 4 + (varsta - 20) / 4; 
            }
            else if(input == 'f')
            {
                return inaltime - 100 - (inaltime - 150) / 2.5 + (varsta - 20) / 6;
            }
            else
            {
                Console.WriteLine("Optiune invalida!");
                return 0;
            }
        }
        public static void AfisareGreutateIdeala()
        {
            int greutate = Convert.ToInt32(GreutateIdeala());
            if(greutate != 0) Console.WriteLine(greutate);
        }
    }
}
