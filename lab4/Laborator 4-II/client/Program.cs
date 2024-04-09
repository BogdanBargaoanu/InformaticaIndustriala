using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            localhost.WebService1 webService1 = new localhost.WebService1();
            string[] list = new string[5];
            list[0] = "adsd";
            list[1] = "asdasdasd";
            list[2] = "adasdasdasasds";
            list[3] = "test";
            list[4] = "testare";
            Console.Write($"{webService1.FtoC(3f)} {webService1.EuroToLei(10)} {webService1.FtoC(3)} {webService1.CtoF(10)} {webService1.DataSiOra()} {webService1.AfisareLista(list)}");
        }
    }
}
