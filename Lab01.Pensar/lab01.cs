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



            // EJERCICIO 5
            string mes = Console.ReadLine();

            switch (mes)
            {
                case (mes=="enero"):

                    Console.WriteLine(mes+"1");
                    break;

                case (mes=="febrero"):
                    Console.WriteLine(mes+"2");
                    break;

                case (mes == "marzo"):
                    Console.WriteLine(mes + "3");
                    break;

                case (mes == "abril"):
                    Console.WriteLine(mes + "4");
                    break;

                case (mes == "mayo"):
                    Console.WriteLine(mes + "5");
                    break;

                case (mes == "junio"):
                    Console.WriteLine(mes + "6");
                    break;

                case (mes == "julio"):
                    Console.WriteLine(mes + "7");
                    break;

                case (mes == "agosto"):
                    Console.WriteLine(mes + "8");
                    break;

                case (mes == "septiembre"):
                    Console.WriteLine(mes + "9");
                    break;

                case (mes == "octubre"):
                    Console.WriteLine(mes + "10");
                    break;

                case (mes == "noviembre"):
                    Console.WriteLine(mes + "11");
                    break;

                case (mes == "diciembre"):
                    Console.WriteLine(mes + "12");
                    break;









                default:
                    Console.WriteLine("error");
            }






        }
    }
}
