using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Framework
{
    internal class Numere
    {
        private double a;
        private double b;
        public Numere(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double Suma()
        {
            return a + b;
        }

        public double Scadere()
        {
            return a - b;
        }

        public double Inmultire()
        {
            return a * b;
        }

        public double Divizare()
        {
            return a / b;
        }

        public void Afisare()
        {
            Console.WriteLine($"Suma: {Suma()}");
            Console.WriteLine($"Scadere: {Scadere()}");
            Console.WriteLine($"Inmultire: {Inmultire()}");
            Console.WriteLine($"Divizare: {Divizare()}");
        }
    }
}
