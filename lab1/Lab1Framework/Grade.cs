using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Framework
{
    internal class Grade
    {
        static  public double ConvertToFahrenheit(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }

        static public double ConvertToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
