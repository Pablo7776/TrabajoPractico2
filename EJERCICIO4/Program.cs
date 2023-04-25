using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


//Ejercicio 4: Realice un programa que muestre un menú con las operaciones de suma, resta,
//división y multiplicación de 2 números ingresados por el usuario, muestre el resultado en pantalla.


namespace S4Enum
{
    internal class Program
    {



        static void Main(string[] args)

        {
            Console.WriteLine("ingrese el primer numero entero:");
            int numero1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero entero:");
            int numero2 = Int32.Parse(Console.ReadLine());


            Console.WriteLine("ingrese 1 para sumar, 2 para restar, 3 para dividir y 4 para multiplicar");
            int valor = Int32.Parse(Console.ReadLine());

            if (valor == 1) {
                Console.WriteLine(numero1 + numero2);
                    }
            else if (valor == 2) {
                Console.WriteLine(numero1 - numero2);
            }
            else if (valor == 3)
            {
                Console.WriteLine(numero1 / numero2);
            }
            else if(valor == 4)
            {
                Console.WriteLine(numero1 * numero2);
            }
            else {
                Console.WriteLine("solo se ceptan numeros del 1 al 4");
                    }

        }
    }
}