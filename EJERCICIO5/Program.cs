//Ejercicio 5: Realice un programa que muestre en pantalla la tabla de multiplicar de un número
//entre 0 y 10 ingresado por el usuario. La visualización debe ser de la siguiente forma:
//“Tabla del 4:
//4x0 = 0
//4x1 = 4
//4x2 = 8
//4x3 = 12
//Etc”

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace EJERCICIO5

{
    internal class Program
    {



        static void Main(string[] args)

        {
            Console.WriteLine("ingrese un número entero:");
            int numero = Int32.Parse(Console.ReadLine());

            int x = 1;
            while (x < 11) {
                Console.WriteLine($"{numero} X {x} = {numero*x}");
                x++;
            }
 

        }
    }
}