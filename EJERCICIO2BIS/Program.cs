﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4Enum
{
    internal class Program
    {
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(WeekDays.Friday); //output: Friday 

            //int day = (int)WeekDays.Friday; // enum to int conversion
            //Console.WriteLine(day); //output: 4 

            // var wd = (WeekDays)5; // int to enum conversion
            //WeekDays wd = (WeekDays)5; // int to enum conversion

            //Console.WriteLine(wd.GetType());//output: Saturday 
            //Console.WriteLine(wd.GetTypeCode());//output: Saturday 
            //Console.WriteLine(wd);//output: Saturday 

            string seleccion = "";
            Console.WriteLine("Ingrese el dia de la semana");
            seleccion = Console.ReadLine();

            //var today = WeekDays.Tuesday;
            if (seleccion == WeekDays.Saturday.ToString() || seleccion == WeekDays.Sunday.ToString())
            {
                Console.WriteLine("It's the weekend!");
            }
            else
            {
                Console.WriteLine("It's a weekday.");
            }

            Console.Write("Una cosa \n");
            Console.Write("Otra cosa");

            Console.WriteLine("Presione ENTER para salir");
            Console.ReadLine();

        }
    }
}
