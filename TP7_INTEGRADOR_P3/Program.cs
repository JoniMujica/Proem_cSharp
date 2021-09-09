using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7_INTEGRADOR_P3
{
    class Program
    {

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
            char[,] arrPiso = new char[val, 2 * val - 1];

            CargarArray(ref arrPiso);
            Dibujar(arrPiso);
        }
        static void CargarArray(ref char[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < 2 * i + 1 && j < arr.GetLength(1); j++)
                {
                    arr[i, j] = dibujo;
                }
            }
        }
        static void Dibujar(char[,] arr)
        {
            int mitad = (arr.GetLength(0) / 2);
            int desconteo = mitad;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int k = 1; k < arr.GetLength(0) - i; k++)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < 2 * i + 1 && j < arr.GetLength(1); j++)
                {
                    Console.Write(" {0}", arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        /*     
            
                     0 1 2 3 4 5 6 7 8
                   0         *   
                   1       * * *
                   2     * * * * *
                   3   * * * * * * *
                   4 * * * * * * * * *
             
             */
    }
}
