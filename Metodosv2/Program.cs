using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodosv2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 45, 72, 99, 12, 5 };

            int maximo = Maximo(numeros);
            Console.WriteLine("El numero maximo del array es {0}",maximo);
        }
        static int Maximo(int[] numeros) {
            int max = int.MinValue;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > max)
                {
                    max = numeros[i];
                }
            }
            return max;
        }
    }
}
