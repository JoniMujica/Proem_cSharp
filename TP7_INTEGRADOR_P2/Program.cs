using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7_INTEGRADOR_P2
{
    class Program
    {
        /*
         3. Escribir un programa que imprima por pantalla una pirámide como la siguiente:
        *
        ***
        *****
        *******
        *********
        El usuario indicará cuál será la altura de la pirámide ingresando un número entero
        positivo. Para el ejemplo anterior la altura ingresada fue de 5.
        Nota: Utilizar estructuras repetitivas y selectivas.*/

        const char dibujo = '*';
        static void Main(string[] args)
        {
            int a;
            do
            {
                Console.WriteLine("Digite un numero: ");
                while (!Int32.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("ERROR: el digito ingresado es invalido, por favor ingrese un valor numerico: ");
                }
                if (a <= 0)
                    Console.WriteLine("Error: el valor ingresado es incorrecto, digite un numero mayor a cero: ");
                else
                    Estrcuturar(a);
            } while (a <= 0);

            Console.ReadKey();
        }
        static void Estrcuturar(int val)
        {
            //char[,] arrPiso = new char[val, val];
            char[,] arrPiso = new char [val,2*val-1];

            CargarArray(ref arrPiso);
            Dibujar(arrPiso);
        }
        static void CargarArray(ref char[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = dibujo;
                }
            }
        }
        static void Dibujar(char [,] arr)
        {
            /*
            Console.Write("{0}", '\n');
            Console.Write("{0}", '\n');
            Console.Write("{0}", '\n');
            Console.Write("{0} x {1}", arr.GetLength(0),arr.GetLength(1));
            Console.Write("{0}", '\n');
            Console.Write("{0}", '\n');
            Console.Write("{0}", '\n');*/
            /*
            for (int i = 0; i < arr.GetLength(0); i++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    //Console.Write("{0} ", (j == 0) ?  $"{'\n' + arr[i,j]}" : arr[i, j]);
                    //Console.Write("{0}",arr[i,j]);

                    Console.Write("{0} ",arr[i,j]);
                }
                Console.WriteLine();
            }*/
            //int dec = arr.GetLength(1) - 1;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j< 2*i+1 && j < arr.GetLength(1); j++)
                {
                    Console.Write(" {0}", arr[i, j]);
                } 
                Console.WriteLine();
            }

            /*     
            
                     0 1 2 3 4 5 6 7 8
                   0 *   
                   1 * * *
                   2 * * * * *
                   3 * * * * * * *
                   4 * * * * * * * * *
             
             */
        }
    }
}
