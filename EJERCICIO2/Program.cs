using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace S4Enum
{
    internal class Program
    {



        static void Main(string[] args)

        {
            string v = "si";
            while (v == "si")
            {

                string L = "lunes";
                string m = "martes";
                string mi = "miercoles";
                string j = "jueves";
                string vi = "viernes";

                string s = "sabado";
                string d = "domingo";

                Console.WriteLine("ingrese un dia de semana");
                string dia = Console.ReadLine();

                if ((dia == L) || (dia == m) || (dia == mi) || (dia == j) || (dia == v)) { Console.WriteLine("dia de semana"); }
                else
                {
                    Console.WriteLine("finde");
                }
                Console.WriteLine("quiere seguir? estribe si");
                v = Console.ReadLine();
            }
            Console.WriteLine("programa terminado");

        }
    }
}  

