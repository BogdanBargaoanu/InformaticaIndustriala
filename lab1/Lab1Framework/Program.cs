using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Framework
{



    internal class Program
    {
        static int Fibbonaci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibbonaci(n - 1) + Fibbonaci(n - 2);
            }
        }
        static void Main(string[] args)
        {
            //ex 1
            Console.WriteLine("Introduceti nr de termeni: ");
            int n = Convert.ToInt32(Console.ReadLine()); //int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Termenul {i} este: {Fibbonaci(i)} ");
            }

            //ex 2
            Console.WriteLine("Introduceti 2 numere:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Numere num = new Numere(a, b);
            num.Afisare();
            
            //ex 3
            Console.WriteLine("Introduceti temperatura in grade Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Temperatura in grade Fahrenheit este: {Grade.ConvertToFahrenheit(celsius)}");
            Console.WriteLine("Introduceti temperatura in grade Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Temperatura in grade Celsius este: {Grade.ConvertToCelsius(fahrenheit)}");

            //ex 4
            Greutate.AfisareGreutateIdeala();

            //ex 5
            Console.WriteLine("Introduceti un sir de numere: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int medieAritmetica = 0;
            int medieGeometrica = 1;
            foreach (var number in numbers)
            {
                medieAritmetica += Convert.ToInt32(number);
                medieGeometrica *= Convert.ToInt32(number);
            }
            double medieAritmeticaRez = (double)medieAritmetica / numbers.Length;
            double medieGeometricaRez = Math.Sqrt((double)medieGeometrica);
            Console.WriteLine($"Medie aritmetica: {medieAritmeticaRez}, Medie geometrica: {medieGeometricaRez}");
        }
    }
}
