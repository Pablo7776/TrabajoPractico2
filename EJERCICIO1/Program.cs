using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Probando GIT

namespace S6_EC_SWITCH
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ingrese el primer numero");
            int numero1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero");
            int numero2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el tercer numero");
            int numero3 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el cuarto numero");
            int numero4 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el quinto numero");
            int numero5 = Int32.Parse(Console.ReadLine());


            /////////////////////////////////////////////////////////////////
            ///MAYORES
            ////////////////////////////////////////////////////////////////

            if ((numero1 > numero2) & (numero1 > numero3) & (numero1 > numero4) & (numero1 > numero5))
            {
                Console.WriteLine($"el numero {numero1} el el mayor");
            }

            else if ((numero2 > numero1) & (numero2 > numero3) & (numero2 > numero4) & (numero2 > numero5))
            {
                Console.WriteLine($"el numero {numero2} el el mayor");
            }

            else if ((numero3 > numero1) & (numero3 > numero2) & (numero3 > numero4) & (numero3 > numero5))
            {
                Console.WriteLine($"el numero {numero3} el el mayor");
            }

            else if ((numero4 > numero1) & (numero4 > numero2) & (numero4 > numero3) & (numero4 > numero5))
            {
                Console.WriteLine($"el numero {numero4} el el mayor");
            }
            else
            {
                Console.WriteLine($"el numero {numero5} es el mayor");
            }

            ////////////////////////////////////////////////////////////
            ///MENORES
            /////////////////////////////////////////////////////////////

            if ((numero1 < numero2) & (numero1 < numero3) & (numero1 < numero4) & (numero1 < numero5))
            {
                Console.WriteLine($"el numero {numero1} el el menor");
            }

            else if ((numero2 < numero1) & (numero2 < numero3) & (numero2 < numero4) & (numero2 < numero5))
            {
                Console.WriteLine($"el numero {numero2} el el menor");
            }

            else if ((numero3 < numero1) & (numero3 < numero2) & (numero3 < numero4) & (numero3 < numero5))
            {
                Console.WriteLine($"el numero {numero3} el el menor");
            }

            else if ((numero4 < numero1) & (numero4 < numero2) & (numero4 < numero3) & (numero4 < numero5))
            {
                Console.WriteLine($"el numero {numero4} el el menor");
            }
            else
            {
                Console.WriteLine($"el numero {numero5} es el menor");
            }
        }
    }

}