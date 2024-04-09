using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace LAB4_Web_server
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {

            return "Hello World";
        }
        //adunare
        [WebMethod]
        public int Add(int a, int b)
        {
            return a + b;
        }
        // conversie grade 
        [WebMethod]
       public double FtoC (double f)

        {
            return (f -32) *5/9;
        }
        [WebMethod]
        public double CtoF (double c)
        {
            return (c * 9 / 5) + 32;
        }
        [WebMethod]
        public string AfisareLista(string[] lista)
        {
            string rez = string.Empty;
            foreach (string s in lista)
            {
                rez += $" {s}";
            }
            return rez;
        }
        [WebMethod]
        public string DataSiOra()
        {
            return DateTime.Now.ToString();
        }
        [WebMethod]
        public double EuroToLei(double euro)
        {
            return euro * 4.97;
        }

    }
}
