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
          
            



                //Console.WriteLine("ingrese la primera letra");
                //string letra1 = Console.ReadLine();

                //Console.WriteLine("ingrese la segunda letra");
                //string letra2 = Console.ReadLine();

                //Console.WriteLine("ingrese la tercera letra");
                //string letra3 = Console.ReadLine();

                //Console.WriteLine($"Las letras ingresadas el orden inverso son: {letra3}, {letra2} y {letra1}");

                Console.WriteLine("ingrese tres y solo tres letras:");
                string letras = Console.ReadLine();

                string l1 = (letras.Substring(2));

                string l2 =(letras.Substring(1,1));
                string l3 = (letras.Substring(0,1));

                Console.WriteLine($"Las letras invertidas son: {l1}, {l2} y {l3}");



        }
    }
}

