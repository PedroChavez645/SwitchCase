﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //opciones
            Console.WriteLine("Elige una opcion\n" + 
                "\n1.- Suma" +
                "\n2.- Resta" +
                "\n3.- Multiplicacion" +
                "\n4.- Division" +
                "\n5.- Salir");

           // String s1 = null;
            int i1 = 0;
            //s1 = Console.ReadLine();
            i1 = Convert.ToInt32(Console.ReadLine());

            switch(i1)
            {
                case 1:
                    Console.WriteLine("Seleccionaste la suma");
                    break;

                case 2:
                    Console.WriteLine("Seleccionaste la resta");
                    break;

                case 3:
                    Console.WriteLine("Seleccionaste la multiplicacion");
                    break;

                case 4:
                    Console.WriteLine("Seleccionaste la division");
                    break;

                case 5:
                    Console.WriteLine("Seleccionaste salir");
                    break;
                
                default:
                    Console.WriteLine("La opcion es incorrecta");
                    break;
            }

            Console.ReadKey();
        }
    }
}
