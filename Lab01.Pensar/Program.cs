using System;
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







        }
    }
}
