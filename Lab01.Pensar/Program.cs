﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.Pensar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* EJERCICIO 1
            
            Console.WriteLine("Ingrese numero 1: ");
             int num1 = int.Parse(Console.ReadLine());
    
            Console.Write("Ingrese numero 2: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = num1 + num2;
            Console.WriteLine("El resultado de la suma de "+num1+" y "+num2+" es "+resultado); */


            /*// EJERCICIO 2


            int anio = int.Parse(Console.ReadLine());

            if (anio % 4 == 0)
            {
                if (anio % 100 == 0)
                {
                    if (anio % 400 == 0) Console.WriteLine("El " + anio + " es bisiesto.");

                    else Console.WriteLine("El " + anio + " no es bisiesto.");
                }

                else Console.WriteLine("El " + anio + " es bisiesto.");
            }
            else Console.WriteLine("El " + anio + " no es bisiesto."); */


            /*// EJERCICIO 3


            int n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            int c = 0;

            for (int i = 1; i < n; i++)
            {
               
                Console.Write(c + " ");
                c = a + b;
                a = b;
                b = c;

            }*/



            /*// EJERCICIO 4

            for (int i = 1; i < 100; i++)
            {
                if (i%2 == 0) Console.Write(i + " ");
                
            }*/



            /* // EJERCICIO 5
            string mes = Console.ReadLine();

            switch (mes)
            {
                case "enero":

                    Console.WriteLine(mes+" 1");
                    break;

                case "febrero":
                    Console.WriteLine(mes+" 2");
                    break;

                case "marzo":
                    Console.WriteLine(mes + " 3");
                    break;

                case "abril":
                    Console.WriteLine(mes + " 4");
                    break;

                case  "mayo":
                    Console.WriteLine(mes + " 5");
                    break;

                case "junio":
                    Console.WriteLine(mes + " 6");
                    break;

                case "julio":
                    Console.WriteLine(mes + " 7");
                    break;

                case "agosto":
                    Console.WriteLine(mes + " 8");
                    break;

                case "septiembre":
                    Console.WriteLine(mes + " 9");
                    break;

                case "octubre":
                    Console.WriteLine(mes + " 10");
                    break;

                case "noviembre":
                    Console.WriteLine(mes + " 11");
                    break;

                case "diciembre":
                    Console.WriteLine(mes + " 12");
                    break;









                default:
                    Console.WriteLine("error");
                    break;
            }
            */





            // EJERCICIO 6

            //Se ve bastante complejho, no encontre una funcion q lo haga automaticamente



            /* //EJERCICIO 7

             int n = int.Parse(Console.ReadLine());


             for(int i =0; i<= n; i++) {
                 int cont = 0;
                 for (int j = 1; j <= n; j++)
                 {
                     if (i % j == 0) cont++;

                 }
                 if (cont < 3) Console.WriteLine(i);

             }



             */



































        }

    }
}



