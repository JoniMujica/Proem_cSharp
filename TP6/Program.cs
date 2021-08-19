using System;

namespace TP6
{
    class Program
    {
        /*2. Crear un proyecto de consola que permita cargar 5 nombres de personas y sus
        edades respectivas.
        a. Realizar la carga pidiendo los datos al usuario.
        b. Imprimir los nombres de las personas junto con su edad.
        c. Informar cuántos mayores de edad (mayores o iguales a 18 años) y mostrar
        sus nombres.
        d. Mostrar los nombres en orden ascendente por edad.*/
        static void Main(string[] args)
        {
            string[] nombres = new string[5];
            int[] edad = new int[5];

            for (int i = 0; i < edad.Length && i<nombres.Length; i++)
            {
                Console.WriteLine("Ingrese su nombre: ");
                nombres[i] = Console.ReadLine();
                Console.WriteLine("Ingrese su edad: ");
                edad[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < edad.Length && i < nombres.Length; i++)
            {
                Console.WriteLine("Nombre {0} Edad {1}", nombres[i], edad[i]);
            }

            int may = 0;
            
            for (int i = 0; i < edad.Length; i++)
            {
                if (edad[i] >= 18)
                {
                    may++;
                }
            }
            string[] nmay = new string[may];
            for (int i = 0; i < nmay.Length; i++)
            {
                if (edad[i] >= 18)
                {
                   nmay[i] = nombres[i];
                }
            }
            Console.WriteLine("Hay {0} mayores de edad y son: ", may);
            for (int i = 0; i < nmay.Length; i++)
            {
                Console.WriteLine(nmay[i]);
            }

            int[] edadOr = new int[edad.Length];
            string [] nombreOr = new string[nombres.Length];
            for (int x = 0; x < edad.Length -1; x++)
            {
                for (int k = x +1; k < edad.Length - x; k++)
                {

                    if (edad[x] > edad[k + 1])
                    {
                        string straux;
                        int aux;

                        aux = edadOr[x];
                        straux = nombres[k];
                        nombres[k] = nombres[k + 1];
                        edad[k] = edad[k + 1];
                        nombres[k + 1] = straux;
                        edad[k + 1] = aux;
                    }

                }
            }

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Nombre {0} Edad {1}", nombreOr[i], edadOr[i]);
            }
        }
    }
}
